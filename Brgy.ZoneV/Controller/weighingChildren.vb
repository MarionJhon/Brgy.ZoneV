Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class weighingChildren

    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim errorProvider As New ErrorProvider()




    Private Sub weighingChildren_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wghtDate.Value = DateTime.Today
        LoadDataIntoDataGridView()
        LoadPatientData()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Use aliases for table names and specify the columns you want to select
                Dim selectQuery As String = "SELECT w.weighing_id, b.birthing_save_record_id,  CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS parents_name, b.babys_name, b.gender, w.weighing_date " &
                             "FROM bzvhcims.weighing w " &
                             "INNER JOIN bzvhcims.birthingsaverecord b ON w.birthing_id = b.birthing_save_record_id " &
                             "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                             "WHERE b.babys_name LIKE @searchKeyword " &
                             "ORDER BY w.weighing_id ASC"



                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    ' Add the parameter for the search keyword
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & txtSearch.Text.Trim() & "%")

                    adapter.Fill(dataTable)
                    weighDatagrid.DataSource = dataTable
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub PerformSearch()
        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT * FROM birthingsaverecord WHERE babys_name LIKE @searchText", conn)
            cmd.Parameters.AddWithValue("@searchText", "%" & search.Text.Trim() & "%")

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)

                Dim column1 As New AutoCompleteStringCollection
                For i As Integer = 0 To dt.Rows.Count - 1
                    column1.Add(dt.Rows(i)("babys_name").ToString())
                Next

                search.AutoCompleteSource = AutoCompleteSource.CustomSource
                search.AutoCompleteCustomSource = column1
                search.AutoCompleteMode = AutoCompleteMode.Suggest

            Catch ex As Exception
                MessageBox.Show("Error performing search: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub WeighingDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles WeighingDataGrid.CellContentClick, weighDatagrid.CellContentClick
        If e.ColumnIndex = weighDatagrid.Columns("inform").Index AndAlso e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = weighDatagrid.Rows(e.RowIndex)
                Dim birthingId As Integer = Convert.ToInt32(weighDatagrid.Rows(e.RowIndex).Cells("bID").Value)
                Dim babysName As String = row.Cells("babys_name").Value.ToString()
                Dim view As New weighingChildrenView(babysName, birthingId)
                view.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - view.Width) / 2, 0)
                tranparentBG.ShowForm(view)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub WeighingDataGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles WeighingDataGrid.CellContentDoubleClick, weighDatagrid.CellContentDoubleClick
        ' Check if the clicked cell is not a header cell and a valid row is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the ID from the selected row
            Dim weighingId As Integer = Convert.ToInt32(weighDatagrid.Rows(e.RowIndex).Cells("wID").Value)
            'Dim parentsName As String = Row.Cells("parentsName").Value.ToString()
            ' Assuming "ID" is the name of the column containing the referral ID.

            ' Open the edit form with the selected ID
            Dim frm As New editWeight(weighingId)
            frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
            tranparentBG.ShowForm(frm)
        End If

        LoadDataIntoDataGridView()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        PerformSearch()
        LoadPatientData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadPatientData()
        Dim selectedBabyName As String = search.Text.Trim()

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Dim birthingIdCmd As New MySqlCommand("SELECT b.birthing_save_record_id, CONCAT(p.fname,' ', mname, ' ', lname) AS parentname, b.babys_name, b.date_of_delivery, b.gender " &
                                      "FROM birthingsaverecord b " &
                                      "INNER JOIN patient p ON b.patient_id = p.patient_id " &
                                      "WHERE b.babys_name = @selectedBabyName", conn)

                birthingIdCmd.Parameters.AddWithValue("@selectedBabyName", selectedBabyName)

                Using da As New MySqlDataAdapter(birthingIdCmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        ' Display the first matching record in the textboxes
                        Dim row As DataRow = dt.Rows(0)
                        patientsname.Text = row("babys_name").ToString()
                        dob.Text = row("date_of_delivery").ToString()
                        gender.Text = row("gender").ToString()
                        prntName.Text = row("parentname").ToString()


                        ' Calculate age
                        Dim birthDate As DateTime = Convert.ToDateTime(row("date_of_delivery"))
                        Dim ageInYears As Integer = DateTime.Today.Year - birthDate.Year

                        ' Display age in the age textbox
                        age.Text = ageInYears.ToString()
                    Else
                        ' Clear textboxes if no matching record is found
                        patientsname.Text = ""
                        dob.Text = ""
                        gender.Text = ""
                        prntName.Text = ""
                        age.Text = ""
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error retrieving patient data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                If String.IsNullOrEmpty(patientsname.Text.Trim()) Then
                    MessageBox.Show("Please select a patient.")
                    Return
                End If

                If String.IsNullOrEmpty(wght.Text.Trim()) Then
                    errorProvider.SetError(wght, "Weight is required.")
                Else
                    errorProvider.SetError(wght, "") ' Clear error if valid
                End If

                If errorProvider.GetError(wght) <> "" Then
                    MessageBox.Show("Please fill in all required fields.")
                    Return
                End If

                ' Retrieve patient data
                LoadPatientData()

                ' Retrieve birthing_id based on the selected baby's name
                Dim selectedBabyName As String = search.Text.Trim()

                Dim birthingIdCmd As New MySqlCommand("SELECT b.birthing_save_record_id, b.patient_id, b.babys_name, b.date_of_delivery, b.attend_healthworker, p.gender " &
                "FROM birthingsaverecord b " &
                "INNER JOIN patient p ON b.patient_id = p.patient_id " &
                "WHERE b.babys_name = @selectedBabyName", conn)

                birthingIdCmd.Parameters.AddWithValue("@selectedBabyName", selectedBabyName)

                Dim birthingId As Object = birthingIdCmd.ExecuteScalar()

                If birthingId IsNot Nothing AndAlso birthingId IsNot DBNull.Value Then
                    ' Check if data already exists in the weighing table for the given birthing record
                    Dim checkExistingQuery As String = "SELECT COUNT(*) FROM bzvhcims.weighing WHERE birthing_id = @birthingId"
                    Dim checkExistingCmd As New MySqlCommand(checkExistingQuery, conn)
                    checkExistingCmd.Parameters.AddWithValue("@birthingId", birthingId)

                    Dim existingCount As Integer = CInt(checkExistingCmd.ExecuteScalar())


                    If existingCount = 0 Then
                        ' Insert data into the weighing table with birthing_id as a foreign key
                        Dim query As String = "INSERT INTO bzvhcims.weighing (weight, weighing_date, birthing_id) VALUES (@value1, @value2, @value3)"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@value1", wght.Text)
                            cmd.Parameters.AddWithValue("@value2", wghtDate.Value)
                            cmd.Parameters.AddWithValue("@value3", birthingId)

                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                ' Insert data into the weighingsaverecord table
                                Dim weighingSaveRecordQuery As String = "INSERT INTO bzvhcims.weighingsaverecord (birthing_id, weight_date, weight) VALUES (@value1, @value2, @value3)"
                                Using weighingSaveRecordCmd As New MySqlCommand(weighingSaveRecordQuery, conn)
                                    weighingSaveRecordCmd.Parameters.AddWithValue("@value1", birthingId)
                                    weighingSaveRecordCmd.Parameters.AddWithValue("@value2", wghtDate.Value)
                                    weighingSaveRecordCmd.Parameters.AddWithValue("@value3", wght.Text)

                                    Dim rowsAffectedWeighingSaveRecord As Integer = weighingSaveRecordCmd.ExecuteNonQuery()

                                    If rowsAffectedWeighingSaveRecord > 0 Then
                                        MessageBox.Show("Data inserted successfully!")
                                        LoadDataIntoDataGridView()
                                    Else
                                        MessageBox.Show("Data insertion into Weighing History failed.")
                                    End If
                                End Using
                            Else
                                MessageBox.Show("Data insertion into Weighing failed.")
                            End If
                        End Using
                    Else
                        MessageBox.Show("Weighing data already exists for the given birthing record.")
                    End If

                Else
                    MessageBox.Show("Patient not found.")
                End If
            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub wght_TextChanged(sender As Object, e As EventArgs) Handles wght.TextChanged
        WeightResults()
    End Sub

    Private Sub WeightResults()
        ' Clear previous results
        weightResultLabel.Text = ""

        ' Check if the weight value and age are not empty
        If Not String.IsNullOrEmpty(wght.Text.Trim()) AndAlso Not String.IsNullOrEmpty(age.Text.Trim()) Then
            ' Parse the weight and age values
            If Double.TryParse(wght.Text.Trim(), Nothing) AndAlso Integer.TryParse(age.Text.Trim(), Nothing) Then
                ' Get the numeric values of weight and age
                Dim weightValue As Double = Double.Parse(wght.Text.Trim())
                Dim ageValue As Integer = Integer.Parse(age.Text.Trim())

                ' Check the age range
                If ageValue >= 1 AndAlso ageValue <= 5 Then
                    ' Check the weight range and provide a description for age 1-5
                    If weightValue < 10 Then
                        weightResultLabel.Text = " - Underweight"
                    ElseIf weightValue >= 10 AndAlso weightValue < 15 Then
                        weightResultLabel.Text = " - Normal Weight"
                    ElseIf weightValue >= 15 AndAlso weightValue < 20 Then
                        weightResultLabel.Text = " - Overweight"
                    ElseIf weightValue >= 20 Then
                        weightResultLabel.Text = " - Obesity"
                    End If

                    ' Show the weightResult label
                    weightResultLabel.ForeColor = SystemColors.ControlText
                    weightResultLabel.Visible = True
                Else
                    ' Display a message if the age is outside the valid range
                    weightResultLabel.Text = " - Age should be between 1 and 5"
                    weightResultLabel.ForeColor = Color.Red

                    ' Show the weightResult label
                    weightResultLabel.Visible = True
                End If
            Else
                ' Display a user-friendly message if the weight or age value is not a valid number
                weightResultLabel.Text = " - Invalid weight or age value"
                weightResultLabel.ForeColor = Color.Red

                ' Show the weightResult label
                weightResultLabel.Visible = True
            End If
        Else
            ' Hide the weightResult label if the value is empty
            weightResultLabel.Visible = False
        End If
    End Sub


    Private Sub dob_ValueChanged(sender As Object, e As EventArgs) Handles dob.ValueChanged
        CalculateAndDisplayAge()
    End Sub

    Private Sub CalculateAndDisplayAge()
        ' Calculate age based on the selected date of birth
        Dim dobChild As DateTime = dob.Value.Date
        Dim ageChild As Integer = DateTime.Now.Year - dobChild.Year

        ' Adjust age if the birthday hasn't occurred yet this year
        If DateTime.Now < dobChild.AddYears(ageChild) Then
            ageChild -= 1
        End If

        ' Display the age in txtAge.Text
        age.Text = ageChild.ToString()
    End Sub
End Class