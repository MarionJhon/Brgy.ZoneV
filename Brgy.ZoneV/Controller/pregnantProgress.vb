Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Relational

Public Class pregnantProgress

    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"

    Sub childForm(ByVal panel As Form)
        ' Clear any existing forms in the main panel
        mainPanel.Controls.Clear()

        ' Set the parent form before showing
        panel.TopLevel = False
        panel.Parent = mainPanel
        panel.Dock = DockStyle.Fill
        panel.BringToFront()
        panel.Show()
    End Sub


    Private Sub LoadDataIntoDataGridView()
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Add a space before the FROM clause
                Dim selectQuery As String = "SELECT n.pregnant_id, n.patient_id, CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS Fullname, TIMESTAMPDIFF(YEAR, p.dob, CURDATE()) AS Age, n.edd, n.date_of_visit " &
                                        "FROM bzvhcims.pregnant n " &
                                        "INNER JOIN bzvhcims.patient p ON n.patient_id = p.patient_id " &
                                        "WHERE CONCAT(p.fname, ' ', p.mname, ' ', p.lname) LIKE @searchKeyword " &
                                        "ORDER BY n.pregnant_id ASC"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    ' Add the parameter for the search keyword
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & txtSearch.Text.Trim() & "%")

                    adapter.Fill(dataTable)
                    pregnantProgressDataGrid.DataSource = dataTable
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub PerformSearch()
        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT patient_id, fname, mname, lname, dob, gender FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) LIKE @searchText", conn)
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

            Catch ex As Exception
                MessageBox.Show("Error performing search: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadPatientData()
        Dim selectedPatientName As String = search.Text.Trim()

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT patient_id, fname, mname, lname, dob, gender FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) = @selectedPatientName", conn)
            cmd.Parameters.AddWithValue("@selectedPatientName", selectedPatientName)

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    ' Display the first matching record in the textboxes
                    Dim row As DataRow = dt.Rows(0)
                    pID.Text = row("patient_id").ToString()
                    patientsname.Text = row("fname").ToString() & " " & row("mname").ToString() & " " & row("lname").ToString()
                    dob.Text = row("dob").ToString()
                    age.Text = CalculateAge(row.Field(Of DateTime)("dob")).ToString()
                Else
                    ' Clear textboxes if no matching record is found
                    patientsname.Text = ""
                    dob.Value = DateTime.Today
                    age.Text = ""
                    LMP.Value = DateTime.Today
                    EDD.Value = DateTime.Today
                    dtVisit.Value = DateTime.Today
                    selectTr.SelectedIndex = -1
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving pregnant data: " & ex.Message)
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

    Private Sub pregnantProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
    End Sub

    Private Sub pregnantProgressDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles pregnantProgressDataGrid.CellContentClick
        Using conn As New MySqlConnection(connString)
            If e.ColumnIndex = pregnantProgressDataGrid.Columns("information").Index AndAlso e.RowIndex >= 0 Then
                Try
                    Dim row As DataGridViewRow = pregnantProgressDataGrid.Rows(e.RowIndex)
                    'Dim referralId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("referral").Value)
                    Dim patientId As Integer = Convert.ToInt32(pregnantProgressDataGrid.Rows(e.RowIndex).Cells("patient_id").Value)
                    Dim fullName As String = row.Cells("fullname").Value.ToString()
                    Dim view As New pregnantView(fullName, patientId)
                    view.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - view.Width) / 2, 0)
                    tranparentBG.ShowForm(view)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            ElseIf e.RowIndex >= 0 Then
                ' Get the selected row's ID
                Dim selectedID As Integer = CInt(pregnantProgressDataGrid.Rows(e.RowIndex).Cells("pregnant_id").Value)


                ' Retrieve data from the database based on the selected ID using a parameterized query
                Dim query As String = "SELECT p.patient_id, n.pregnant_id, n.date_lmp, p.fname, p.mname, p.lname, n.edd, n.date_of_visit, p.dob" &
                                      " FROM bzvhcims.pregnant n " &
                                      " INNER JOIN bzvhcims.patient p ON n.patient_id = p.patient_id " &
                                      " WHERE n.pregnant_id = @SelectedID"

                Using cmd As New MySqlCommand(query, conn)
                    ' Add the parameter to the query
                    cmd.Parameters.AddWithValue("@SelectedID", selectedID)

                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Display the data in TextBoxes
                            pID.Text = Convert.ToInt32(reader("patient_id"))
                            patientsname.Text = reader("fname").ToString() & " " & reader("mname").ToString() & " " & reader("lname").ToString()

                            ' Check if 'dob' is not DBNull before converting
                            If Not IsDBNull(reader("dob")) Then
                                dob.Value = Convert.ToDateTime(reader("dob"))
                                age.Text = CalculateAge(Convert.ToDateTime(reader("dob"))).ToString()
                            Else
                                dob.Value = DateTime.Today ' Set a default value or handle accordingly
                                age.Text = "" ' Set a default value or handle accordingly
                            End If

                            ' Check if 'date_lmp' is not DBNull before converting
                            If Not IsDBNull(reader("date_lmp")) Then
                                LMP.Value = Convert.ToDateTime(reader("date_lmp"))
                            Else
                                LMP.Value = DateTime.Today ' Set a default value or handle accordingly
                            End If

                            ' Check if 'edd' is not DBNull before converting
                            If Not IsDBNull(reader("edd")) Then
                                EDD.Value = Convert.ToDateTime(reader("edd"))
                            Else
                                EDD.Value = DateTime.Today ' Set a default value or handle accordingly
                            End If

                            ' Check if 'date_of_visit' is not DBNull before converting
                            If Not IsDBNull(reader("date_of_visit")) Then
                                dtVisit.Value = Convert.ToDateTime(reader("date_of_visit"))
                            Else
                                dtVisit.Value = DateTime.Today ' Set a default value or handle accordingly
                            End If
                            ' Additional TextBoxes for other columns can be updated similarly
                        End If

                    End Using
                End Using
            End If

        End Using

        ' Refresh the DataGridView after adding a new record
        LoadDataIntoDataGridView()
    End Sub

    Private Sub pregnantProgressDataGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles pregnantProgressDataGrid.CellContentDoubleClick
        ' Check if the clicked cell is not a header cell and a valid row is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the ID from the selected row
            Dim pregnantlId As Integer = Convert.ToInt32(pregnantProgressDataGrid.Rows(e.RowIndex).Cells("pregnant_id").Value)
            ' Assuming "ID" is the name of the column containing the referral ID.

            ' Open the edit form with the selected ID
            Dim frm As New editPregnant(pregnantlId)
            frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
            tranparentBG.ShowForm(frm)
        End If

        LoadDataIntoDataGridView()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Using conn As New MySqlConnection(connString)
            'Try
            conn.Open()

            ' Retrieve patient_id based on the selected patient's name
            Dim patientIdQuery As String = "SELECT patient_id FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) = @selectedPatientName"
            Dim patientIdCmd As New MySqlCommand(patientIdQuery, conn)
            patientIdCmd.Parameters.AddWithValue("@selectedPatientName", patientsname.Text.Trim())

            Dim patientId As Object = patientIdCmd.ExecuteScalar()

            If patientId IsNot Nothing Then
                ' Check if data already exists in referral table for the given patient
                Dim checkExistingQuery As String = "SELECT COUNT(*) FROM bzvhcims.pregnant WHERE patient_id = @patientId"
                Dim checkExistingCmd As New MySqlCommand(checkExistingQuery, conn)
                checkExistingCmd.Parameters.AddWithValue("@patientId", patientId)

                Dim existingCount As Integer = CInt(checkExistingCmd.ExecuteScalar())

                If existingCount = 0 Then
                    ' Insert data into the referral table with patient_id as a foreign key
                    Dim query As String = "INSERT INTO bzvhcims.pregnant (date_lmp,edd,date_of_visit,patient_id) VALUES (@value1, @value2, @value3, @value4)"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@value1", LMP.Value)
                    cmd.Parameters.AddWithValue("@value2", EDD.Value)
                    cmd.Parameters.AddWithValue("@value3", dtVisit.Value)
                    cmd.Parameters.AddWithValue("@value4", patientId)

                    Dim rowAffected As Integer = cmd.ExecuteNonQuery()

                    If rowAffected > 0 Then
                        MessageBox.Show("Data inserted successfully into the pregnant table!")
                        LoadDataIntoDataGridView()
                    Else
                        MessageBox.Show("Failed to insert data into pregnant table.")
                    End If

                    Dim pregnantSaveRecordQuery As String = "INSERT INTO bzvhcims.pregnantsaverecord ( patient_id, date_of_visit, lmp, edd) VALUES (@value1, @value2, @value3, @value4)"

                    Using pregnantSaveRecordCmd As New MySqlCommand(pregnantSaveRecordQuery, conn)
                        ' Set parameters for the insert query
                        pregnantSaveRecordCmd.Parameters.AddWithValue("@value1", patientId)
                        pregnantSaveRecordCmd.Parameters.AddWithValue("@value2", dtVisit.Value)
                        pregnantSaveRecordCmd.Parameters.AddWithValue("@value3", LMP.Value)
                        pregnantSaveRecordCmd.Parameters.AddWithValue("@value4", EDD.Value)

                        Dim rowsAffectedBloodPressureSaveRecord As Integer = pregnantSaveRecordCmd.ExecuteNonQuery()
                    End Using

                Else
                    MessageBox.Show("Data already exists in pregnant table for the given patient.")
                End If
            Else
                MessageBox.Show("Patient not found.")
            End If

            'Catch ex As Exception
            '    ' MessageBox.Show("Error: " & ex.Message)
            'Finally
            '    conn.Close()
            'End Try
        End Using
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        PerformSearch()
        LoadPatientData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDataIntoDataGridView()
    End Sub

    ' Function to show the pregnant progress form and hide other forms
    Public Sub ShowPregnantProgressForm()
        ' Clear any existing controls in the main panel
        mainPanel.Controls.Clear()

        ' Load data into the DataGridView
        LoadDataIntoDataGridView()

        ' Create an instance of the pregnantProgress form
        Dim pregnantForm As New pregnantProgress()

        ' Set its properties (if needed)
        pregnantForm.TopLevel = False
        pregnantForm.Parent = mainPanel
        pregnantForm.Dock = DockStyle.Fill

        ' Show the pregnantForm
        pregnantForm.Show()

        ' Show the main panel
        mainPanel.Show()
    End Sub


    Private Sub selectTr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectTr.SelectedIndexChanged
        ' Check the selected item in the combobox
        If selectTr.SelectedItem IsNot Nothing Then
            Dim selectedTrimester As String = selectTr.SelectedItem.ToString()
            Dim pregnantId As Integer = GetPregnantIdByPatientName(patientsname.Text)
            Dim patientId As Integer = GetPatientIdByPatientName(pID.Text)

            If pregnantId <> -1 Then
                ' Patient found, proceed with showing trimester forms
                Select Case selectedTrimester
                    Case "First Trimester"
                        ' Hide pregnant progress form and show firstTrimester form
                        Dim firstTrimesterForm As New firstTrimester(pregnantId, patientId)
                        firstTrimesterForm.ParentForm = Me
                        childForm(firstTrimesterForm)

                        ' Load data into firstTrimester form based on the pregnantId
                        firstTrimesterForm.LoadDataByPregnantId(pregnantId)
                        firstTrimesterForm.LoadDataIntoDataGridView(patientId)

                    Case "Second Trimester"
                        ' Hide pregnant progress form and show secondTrimester form
                        Dim secondTrimesterForm As New secondTrimester(pregnantId, patientId)
                        secondTrimesterForm.ParentForm = Me
                        childForm(secondTrimesterForm)

                        ' Load data into secondTrimester form based on the pregnantId
                        secondTrimesterForm.LoadDataByPregnantId(pregnantId)
                        secondTrimesterForm.LoadDataIntoDataGridView(patientId)

                    Case "Third Trimester"
                        ' Hide pregnant progress form and show thirdTrimester form
                        Dim thirdTrimesterForm As New thirdTrimester(pregnantId, patientId)
                        thirdTrimesterForm.ParentForm = Me
                        childForm(thirdTrimesterForm)

                        ' Load data into thirdTrimester form based on the pregnantId
                        thirdTrimesterForm.LoadDataByPregnantId(pregnantId)
                        thirdTrimesterForm.LoadDataIntoDataGridView(patientId)
                    Case Else
                        ' If none of the specific trimesters are selected, show the default pregnant progress form
                        ShowPregnantProgressForm()

                        ' Perform necessary actions when switching back to the pregnant progress form
                        LoadPatientData()
                        PerformSearch()
                End Select
            Else
                ' Patient not found, display a message to the user
                MessageBox.Show("Patient not found. Please click on the 'Patient' in the table.")

            End If
        End If
    End Sub

    Private Function GetPatientIdByPatientName(patientID As String) As Integer
        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT f.patient_id FROM bzvhcims.first_trim f INNER JOIN bzvhcims.patient p ON f.patient_id = p.patient_id WHERE f.patient_id = @patient", conn)
            cmd.Parameters.AddWithValue("@patient", patientID)

            Try
                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToInt32(result)
                Else
                    ' Handle the case where no pregnant ID is found for the given patient name
                    Return -1 ' or another appropriate value or throw an exception
                End If
            Catch ex As Exception
                ' Handle the exception, log it, or throw it further as needed
                MessageBox.Show("Error retrieving patient ID: " & ex.Message)
                Return -1 ' or another appropriate value
            End Try
        End Using
    End Function

    Private Function GetPregnantIdByPatientName(patientName As String) As Integer
        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT pregnant_id FROM bzvhcims.pregnant p INNER JOIN bzvhcims.patient pa ON p.patient_id = pa.patient_id WHERE CONCAT(pa.fname, ' ', pa.mname, ' ', pa.lname) = @patientName", conn)
            cmd.Parameters.AddWithValue("@patientName", patientName)

            Try
                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToInt32(result)
                Else
                    ' Handle the case where no pregnant ID is found for the given patient name
                    Return -1 ' or another appropriate value or throw an exception
                End If
            Catch ex As Exception
                ' Handle the exception, log it, or throw it further as needed
                MessageBox.Show("Error retrieving pregnant ID: " & ex.Message)
                Return -1 ' or another appropriate value
            End Try
        End Using
    End Function



    Public ReadOnly Property SelectedPatientName As String
        Get
            Return selectTr.Text.Trim()
        End Get
    End Property

End Class