Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports System.Windows.Media.Media3D
Imports MySql.Data.MySqlClient

Public Class birthingServices

    Private connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim errorProvider As New ErrorProvider()

    Private Sub LoadDataIntoDataGridView()
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Add a WHERE clause to filter the results based on the search criteria
                Dim selectQuery As String = "SELECT b.birthing_id, p.patient_id, CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS Fullname, b.attending_healthworker_midwife, TIMESTAMPDIFF(YEAR, p.dob, CURDATE()) AS Age, b.date_of_delivery  " &
                                        "FROM bzvhcims.birthing b " &
                                        "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                                        "WHERE CONCAT(p.fname, ' ', p.mname, ' ', p.lname) LIKE @searchKeyword"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    ' Add the parameter for the search keyword
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & txtSearch.Text.Trim() & "%")

                    adapter.Fill(dataTable)
                    BirthDataGrid.DataSource = dataTable


                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub LoadPatientData()
        Dim selectedPatientName As String = search.Text.Trim()

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT fname, mname, lname, dob FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) = @selectedPatientName", conn)
            cmd.Parameters.AddWithValue("@selectedPatientName", selectedPatientName)

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    ' Display the first matching record in the textboxes
                    tof.Text = DateTime.Now.ToString("HH:mm tt")

                    Dim row As DataRow = dt.Rows(0)
                    patientsname.Text = row("fname").ToString() & " " & row("mname").ToString() & " " & row("lname").ToString()
                    dob.Text = row("dob").ToString()
                    age.Text = CalculateAge(row.Field(Of DateTime)("dob")).ToString()

                Else
                    ' Clear textboxes if no matching record is found
                    patientsname.Text = ""
                    dob.Value = DateTime.Today
                    age.Text = ""
                    typdelivered.Text = ""
                    dtDelivered.Value = DateTime.Today
                    tof.Text = ""
                    nmAttend.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving patient data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function CalculateAge(birthdate As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthdate.Year

        If birthdate > today.AddYears(-age) Then
            age -= 1
        End If

        Return age
    End Function

    Private Sub PerformSearch()
        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT fname, mname, lname, dob, gender FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) LIKE @searchText", conn)
            cmd.Parameters.AddWithValue("@searchText", "%" & search.Text.Trim() & "%")

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)

                Dim column1 As New AutoCompleteStringCollection
                For i As Integer = 0 To dt.Rows.Count - 1
                    column1.Add(dt.Rows(i)("fname").ToString() & " " & dt.Rows(i)("mname").ToString() & " " & dt.Rows(i)("lname").ToString())
                Next

                search.AutoCompleteSource = AutoCompleteSource.CustomSource
                search.AutoCompleteCustomSource = column1
                search.AutoCompleteMode = AutoCompleteMode.Suggest

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("Error performing search: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub birthingServices_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
        LoadPatientData()
    End Sub


    Private Sub BirthDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BirthDataGrid.CellContentClick
        If e.ColumnIndex = BirthDataGrid.Columns("information").Index AndAlso e.RowIndex >= 0 Then
            'Try
            Dim row As DataGridViewRow = BirthDataGrid.Rows(e.RowIndex)
            Dim patientId As Integer = Convert.ToInt32(BirthDataGrid.Rows(e.RowIndex).Cells("patient_id").Value)
            Dim fullName As String = row.Cells("fullname").Value.ToString()
            Dim view As New birthingServiceView(fullName, patientId)
            view.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - view.Width) / 2, 0)
            tranparentBG.ShowForm(view)
            'Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message)
            'End Try
        End If
    End Sub

    Private Sub BirthDataGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BirthDataGrid.CellContentDoubleClick
        ' Check if the clicked cell is not a header cell and a valid row is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the ID from the selected row
            Dim birthId As Integer = Convert.ToInt32(BirthDataGrid.Rows(e.RowIndex).Cells("birthing_id").Value)
            ' Assuming "ID" is the name of the column containing the referral ID.

            ' Open the edit form with the selected ID
            Dim frm As New editBirthing(birthId)
            frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
            tranparentBG.ShowForm(frm)
        End If

        LoadDataIntoDataGridView()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                If String.IsNullOrEmpty(patientsname.Text.Trim()) Then
                    MessageBox.Show("Please select a patient.")
                    Return
                End If

                If String.IsNullOrEmpty(typdelivered.Text.Trim()) Then
                    errorProvider.SetError(typdelivered, "Weight is required.")
                Else
                    errorProvider.SetError(typdelivered, "") ' Clear error if valid
                End If

                If String.IsNullOrEmpty(nmAttend.Text.Trim()) Then
                    errorProvider.SetError(nmAttend, "Weight is required.")
                Else
                    errorProvider.SetError(nmAttend, "") ' Clear error if valid
                End If

                If errorProvider.GetError(typdelivered) <> "" OrElse errorProvider.GetError(nmAttend) <> "" Then
                    MessageBox.Show("Please fill in all required fields.")
                    Return
                End If

                ' Retrieve patient_id based on the selected patient's name
                Dim patientIdQuery As String = "SELECT patient_id FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) = @selectedPatientName"
                Dim patientIdCmd As New MySqlCommand(patientIdQuery, conn)
                patientIdCmd.Parameters.AddWithValue("@selectedPatientName", patientsname.Text.Trim())

                Dim patientId As Object = patientIdCmd.ExecuteScalar()

                If patientId IsNot Nothing Then
                    ' Check if data already exists in referral table for the given patient
                    Dim checkExistingQuery As String = "SELECT COUNT(*) FROM bzvhcims.birthing WHERE patient_id = @patientId"
                    Dim checkExistingCmd As New MySqlCommand(checkExistingQuery, conn)
                    checkExistingCmd.Parameters.AddWithValue("@patientId", patientId)

                    Dim existingCount As Integer = CInt(checkExistingCmd.ExecuteScalar())

                    If existingCount = 0 Then
                        ' Insert data into the referral table with patient_id as a foreign key
                        Dim query As String = "INSERT INTO bzvhcims.birthing (type_of_delivery, date_of_delivery, time_of_delivery, attending_healthworker_midwife, patient_id) VALUES (@value4, @value5, @value6,  @value7,  @value8)"
                        Dim cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@value4", typdelivered.SelectedItem)
                        cmd.Parameters.AddWithValue("@value5", dtDelivered.Value)
                        cmd.Parameters.AddWithValue("@value6", tof.Text)
                        cmd.Parameters.AddWithValue("@value7", nmAttend.Text)
                        cmd.Parameters.AddWithValue("@value8", patientId)

                        Dim rowAffected As Integer = cmd.ExecuteNonQuery()

                        If rowAffected > 0 Then
                            MessageBox.Show("Data inserted successfully into the birthing table!")
                            LoadDataIntoDataGridView()
                        Else
                            MessageBox.Show("Failed to insert data into birthing table.")
                        End If

                    Else
                        MessageBox.Show("Data already exists in birthing table for the given patient.")
                    End If
                Else
                    MessageBox.Show("Patient not found.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub


    Private Sub search_TextChanged_1(sender As Object, e As EventArgs) Handles search.TextChanged
        PerformSearch()
        LoadPatientData()
    End Sub

    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDataIntoDataGridView()
    End Sub

End Class
