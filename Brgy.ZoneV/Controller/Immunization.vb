Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports MySql.Data.MySqlClient

Public Class Immunization

    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim errorProvider As New ErrorProvider()


    Private Sub Immunization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Add a WHERE clause to filter the results based on the search criteria
                Dim selectQuery As String = "SELECT i.immunization_id, b.birthing_save_record_id,  CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS parents_name, b.babys_name, b.gender, TIMESTAMPDIFF(YEAR, b.date_of_delivery, CURDATE()) AS Age, i.date_of_vaccination " &
                         "FROM bzvhcims.immunization i " &
                         "INNER JOIN bzvhcims.birthingsaverecord b ON i.birthing_id = b.birthing_save_record_id " &
                         "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                         "WHERE b.babys_name LIKE @searchKeyword"

                Using adapter As New MySqlDataAdapter()
                    adapter.SelectCommand = New MySqlCommand(selectQuery, conn)
                    adapter.SelectCommand.CommandType = CommandType.Text

                    ' Add the parameter for the search keyword
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & txtSearch.Text.Trim() & "%")

                    adapter.Fill(dataTable)
                    immunizationDatagrid.DataSource = dataTable
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
                        dtVax.Value = DateTime.Today
                        prntName.Text = ""
                        age.Text = ""
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error retrieving patient data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub RefreshData()
        ' Call the method to reload data into the DataGridView
        dtVax.Value = DateTime.Today
        LoadDataIntoDataGridView()
    End Sub


    Private Sub immunizationDatagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles immunizationDatagrid.CellContentClick
        If e.ColumnIndex = immunizationDatagrid.Columns("information").Index AndAlso e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = immunizationDatagrid.Rows(e.RowIndex)
                'Dim referralId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("referral").Value)
                Dim birthingtId As Integer = Convert.ToInt32(immunizationDatagrid.Rows(e.RowIndex).Cells("birthing_save_record_id").Value)
                Dim babysName As String = row.Cells("babys_name").Value.ToString()

                Dim view As New immunizationView(babysName, birthingtId)
                view.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - view.Width) / 2, 0)
                tranparentBG.ShowForm(view)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub immunizationDatagrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles immunizationDatagrid.CellContentDoubleClick
        ' Check if the clicked cell is not a header cell and a valid row is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the ID from the selected row
            Dim immuneId As Integer = Convert.ToInt32(immunizationDatagrid.Rows(e.RowIndex).Cells("ID").Value)
            ' Assuming "ID" is the name of the column containing the referral ID.

            ' Open the edit form with the selected ID
            Dim frm As New editImmunization(immuneId)
            frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
            tranparentBG.ShowForm(frm)
        End If

        LoadDataIntoDataGridView()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                ' Check if patient name is not empty
                If String.IsNullOrEmpty(patientsname.Text.Trim()) Then
                    MessageBox.Show("Please select a patient.")
                    Return
                End If

                ' Validate pulse
                If String.IsNullOrEmpty(vaxTyp.Text.Trim()) Then
                    ErrorProvider.SetError(vaxTyp, "Pulse is required.")
                Else
                    ErrorProvider.SetError(vaxTyp, "") ' Clear error if valid
                End If

                ' If any validation failed, exit the method
                If ErrorProvider.GetError(vaxTyp) <> "" Then
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
                    ' Check if data already exists in the immunization table for the given birthing record
                    Dim checkExistingQuery As String = "SELECT COUNT(*) FROM bzvhcims.immunization WHERE birthing_id = @birthingId"
                    Dim checkExistingCmd As New MySqlCommand(checkExistingQuery, conn)
                    checkExistingCmd.Parameters.AddWithValue("@birthingId", birthingId)

                    Dim existingCount As Integer = CInt(checkExistingCmd.ExecuteScalar())

                    If existingCount = 0 Then
                        ' Insert data into the immunization table with birthing_id as a foreign key
                        Dim query As String = "INSERT INTO bzvhcims.immunization (date_of_vaccination, vaccine_type, birthing_id) VALUES (@value1, @value2, @value3)"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@value1", dtVax.Value)
                            cmd.Parameters.AddWithValue("@value2", vaxTyp.Text)
                            cmd.Parameters.AddWithValue("@value3", birthingId)

                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                ' Insert data into the immunizationsaverecord table
                                Dim immunizationSaveRecordQuery As String = "INSERT INTO bzvhcims.immunizationsaverecord (birthing_id, date_of_vaccination, vaccine_type) VALUES (@value1, @value2, @value3)"
                                Using immunizationSaveRecordCmd As New MySqlCommand(immunizationSaveRecordQuery, conn)
                                    immunizationSaveRecordCmd.Parameters.AddWithValue("@value1", birthingId)
                                    immunizationSaveRecordCmd.Parameters.AddWithValue("@value2", dtVax.Value)
                                    immunizationSaveRecordCmd.Parameters.AddWithValue("@value3", vaxTyp.Text)

                                    Dim rowsAffectedImmunizationSaveRecord As Integer = immunizationSaveRecordCmd.ExecuteNonQuery()

                                    If rowsAffectedImmunizationSaveRecord > 0 Then
                                        MessageBox.Show("Data inserted successfully!")
                                        LoadDataIntoDataGridView()
                                    Else
                                        MessageBox.Show("Data insertion into Immunization History failed.")
                                    End If
                                End Using
                            Else
                                MessageBox.Show("Data insertion into Immunization failed.")
                            End If
                        End Using
                    Else
                            MessageBox.Show("Immunization data already exists for the given birthing record.")
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

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        PerformSearch()
        LoadPatientData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDataIntoDataGridView()
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