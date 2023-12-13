Imports System.Windows.Media.Media3D
Imports MySql.Data.MySqlClient

Public Class bloodPressureRecord
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim errorProvider As New ErrorProvider()

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

            Catch ex As Exception
                MessageBox.Show("Error performing search: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadPatientData()
        Dim selectedPatientName As String = search.Text.Trim()

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT fname, mname, lname, dob, gender FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) = @selectedPatientName", conn)
            cmd.Parameters.AddWithValue("@selectedPatientName", selectedPatientName)

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    ' Display the first matching record in the textboxes
                    Dim row As DataRow = dt.Rows(0)
                    patientTxt.Text = row("fname").ToString() & " " & row("mname").ToString() & " " & row("lname").ToString()
                    dob.Text = row("dob").ToString()
                    gender.Text = row("gender").ToString()
                    age.Text = CalculateAge(row.Field(Of DateTime)("dob")).ToString()
                Else
                    ' Clear textboxes if no matching record is found
                    patientTxt.Text = ""
                    gender.Text = ""
                    dob.Value = DateTime.Today
                    age.Text = ""
                    systolic.Text = ""
                    diastolic.Text = ""
                    dtTime.Value = DateTime.Today
                    pulseTxt.Text = ""
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

    Private Sub LoadDataIntoDataGridView()
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Add a WHERE clause to filter the results based on the search criteria
                Dim selectQuery As String = "SELECT b.blood_id, p.patient_id, CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS Fullname ,p.gender, TIMESTAMPDIFF(YEAR, p.dob, CURDATE()) AS Age, b.blood_date " &
                                        "FROM bzvhcims.blood_pressure b " &
                                        "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                                        "WHERE CONCAT(p.fname, ' ', p.mname, ' ', p.lname) LIKE @searchKeyword"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    ' Add the parameter for the search keyword
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & txtSearch.Text.Trim() & "%")

                    adapter.Fill(dataTable)
                    bloodDatagrid.DataSource = dataTable
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub bloodPressureRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
        LoadPatientData()
        bloodPressureResult()
        pulseResults()
    End Sub

    Private Sub bloodDatagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bloodDatagrid.CellContentClick
        If e.ColumnIndex = bloodDatagrid.Columns("information").Index AndAlso e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = bloodDatagrid.Rows(e.RowIndex)
                'Dim referralId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("referral").Value)
                Dim patientId As Integer = Convert.ToInt32(bloodDatagrid.Rows(e.RowIndex).Cells("patient_id").Value)
                Dim fullName As String = row.Cells("fullname").Value.ToString()
                Dim view As New bloodPressureView(fullName, patientId)
                view.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - view.Width) / 2, 0)
                tranparentBG.ShowForm(view)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub bloodDatagrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles bloodDatagrid.CellContentDoubleClick
        ' Check if the clicked cell is not a header cell and a valid row is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the ID from the selected row
            Dim bloodId As Integer = Convert.ToInt32(bloodDatagrid.Rows(e.RowIndex).Cells("blood_id").Value)
            ' Assuming "ID" is the name of the column containing the referral ID.

            ' Open the edit form with the selected ID
            Dim frm As New editBlood(bloodId)
            frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
            tranparentBG.ShowForm(frm)
        End If

        LoadDataIntoDataGridView()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        PerformSearch()
        LoadPatientData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Check if patient name is not empty
                If String.IsNullOrEmpty(patientTxt.Text.Trim()) Then
                    MessageBox.Show("Please select a patient.")
                    Return
                End If

                ' Validate pulse
                If String.IsNullOrEmpty(pulseTxt.Text.Trim()) Then
                    errorProvider.SetError(pulseTxt, "Pulse is required.")
                Else
                    errorProvider.SetError(pulseTxt, "") ' Clear error if valid
                End If

                ' Validate blood pressure
                If String.IsNullOrEmpty(systolic.Text.Trim()) OrElse String.IsNullOrEmpty(diastolic.Text.Trim()) Then
                    errorProvider.SetError(diastolic, "Systolic and Diastolic are required.")
                Else
                    errorProvider.SetError(diastolic, "") ' Clear error if valid
                End If

                ' If any validation failed, exit the method
                If errorProvider.GetError(pulseTxt) <> "" OrElse errorProvider.GetError(diastolic) <> "" Then
                    MessageBox.Show("Please fill in all required fields.")
                    Return
                End If

                ' Retrieve patient_id based on the selected patient's name
                Dim patientIdQuery As String = "SELECT patient_id FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) = @selectedPatientName"
                Dim patientIdCmd As New MySqlCommand(patientIdQuery, conn)
                patientIdCmd.Parameters.AddWithValue("@selectedPatientName", patientTxt.Text.Trim())

                Dim patientId As Object = patientIdCmd.ExecuteScalar()

                If patientId IsNot Nothing Then
                    ' Check if data already exists in referral table for the given patient
                    Dim checkExistingQuery As String = "SELECT COUNT(*) FROM bzvhcims.blood_pressure WHERE patient_id = @patientId"
                    Dim checkExistingCmd As New MySqlCommand(checkExistingQuery, conn)
                    checkExistingCmd.Parameters.AddWithValue("@patientId", patientId)

                    Dim existingCount As Integer = CInt(checkExistingCmd.ExecuteScalar())

                    If existingCount = 0 Then
                        ' Insert data into the referral table with patient_id as a foreign key
                        Dim bloodPressureQuery As String = "INSERT INTO bzvhcims.blood_pressure (blood_date, blood_reading, pulse, patient_id) VALUES (@value1, @value2, @value3, @value4)"
                        Dim bloodPressureCmd As New MySqlCommand(bloodPressureQuery, conn)
                        bloodPressureCmd.Parameters.AddWithValue("@value1", dtTime.Value)
                        bloodPressureCmd.Parameters.AddWithValue("@value2", systolic.Text & " / " & diastolic.Text)
                        bloodPressureCmd.Parameters.AddWithValue("@value3", pulseTxt.Text)
                        bloodPressureCmd.Parameters.AddWithValue("@value4", patientId)

                        Dim rowsAffectedBloodPressure As Integer = bloodPressureCmd.ExecuteNonQuery()

                        If rowsAffectedBloodPressure > 0 Then
                            MessageBox.Show("Data inserted successfully into the referral table!")
                            LoadDataIntoDataGridView()
                        Else
                            MessageBox.Show("Failed to insert data into referral table.")
                        End If

                        ' Insert data into blood_pressuresaverecord table
                        Dim bloodPressureSaveRecordQuery As String = "INSERT INTO bzvhcims.blood_pressuresaverecord (patient_id, blood_date, blood_reading, pulse) VALUES (@value1, @value2, @value3, @value4)"

                        Using bloodPressureSaveRecordCmd As New MySqlCommand(bloodPressureSaveRecordQuery, conn)
                            ' Set parameters for the insert query
                            bloodPressureSaveRecordCmd.Parameters.AddWithValue("@value1", patientId)
                            bloodPressureSaveRecordCmd.Parameters.AddWithValue("@value2", dtTime.Value)
                            bloodPressureSaveRecordCmd.Parameters.AddWithValue("@value3", systolic.Text & " / " & diastolic.Text)
                            bloodPressureSaveRecordCmd.Parameters.AddWithValue("@value4", pulseTxt.Text)

                            Dim rowsAffectedBloodPressureSaveRecord As Integer = bloodPressureSaveRecordCmd.ExecuteNonQuery()
                        End Using
                    Else
                        MessageBox.Show("Data already exists in blood pressure table for the given patient.")
                    End If
                Else
                    MessageBox.Show("Patient not found.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                ' Log the error for further investigation
                ' You may also consider logging errors to a file or database
            Finally
                conn.Close()
            End Try
        End Using
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDataIntoDataGridView()
    End Sub

    Private Sub diastolic_TextChanged(sender As Object, e As EventArgs) Handles diastolic.TextChanged, systolic.TextChanged
        bloodPressureResult()
    End Sub

    Private Sub bloodPressureResult()

        ' Check if the blood pressure values are not empty
        If Not String.IsNullOrEmpty(systolic.Text.Trim()) AndAlso Not String.IsNullOrEmpty(diastolic.Text.Trim()) Then
            ' Parse the blood pressure values
            If Integer.TryParse(systolic.Text.Trim(), Nothing) AndAlso Integer.TryParse(diastolic.Text.Trim(), Nothing) Then
                ' Get the numeric values of systolic and diastolic pressure
                Dim systolicValue As Integer = Integer.Parse(systolic.Text.Trim())
                Dim diastolicValue As Integer = Integer.Parse(diastolic.Text.Trim())

                ' Check the blood pressure range and provide a description
                If systolicValue < 90 AndAlso diastolicValue < 60 Then
                    bloodResult.Text = " - Low Blood Pressure"
                ElseIf systolicValue >= 90 AndAlso systolicValue <= 120 AndAlso diastolicValue >= 60 AndAlso diastolicValue <= 80 Then
                    bloodResult.Text = " - Normal Blood Pressure"
                ElseIf systolicValue > 120 AndAlso systolicValue <= 130 AndAlso diastolicValue > 80 AndAlso diastolicValue <= 85 Then
                    bloodResult.Text = " - Elevated Blood Pressure (Prehypertension)"
                ElseIf systolicValue > 130 AndAlso systolicValue <= 140 AndAlso diastolicValue > 85 AndAlso diastolicValue <= 90 Then
                    bloodResult.Text = " - Stage 1 Hypertension"
                ElseIf systolicValue > 140 AndAlso diastolicValue > 90 Then
                    bloodResult.Text = " - Stage 2 Hypertension (Seek Medical Attention)"
                End If
            Else
                ' Display a user-friendly message if the blood pressure values are not valid numbers
                bloodResult.Text = " - Invalid blood pressure values"
                bloodResult.Visible = True

            End If
        Else
            ' Clear the blood pressure result label if the values are empty
            bloodResult.Text = ""

        End If
    End Sub

    Private Sub pulseTxt_TextChanged(sender As Object, e As EventArgs) Handles pulseTxt.TextChanged
        pulseResults()
    End Sub

    Private Sub pulseResults()
        ' Check if the pulse rate value is not empty
        If Not String.IsNullOrEmpty(pulseTxt.Text.Trim()) Then
            ' Parse the pulse rate value
            If Integer.TryParse(pulseTxt.Text.Trim(), Nothing) Then
                ' Get the numeric value of the pulse rate
                Dim pulseValue As Integer = Integer.Parse(pulseTxt.Text.Trim())

                ' Check the pulse rate range and provide a description
                If pulseValue < 60 Then
                    pulseResult.Text = " - Low Pulse Rate"
                ElseIf pulseValue >= 60 AndAlso pulseValue <= 100 Then
                    pulseResult.Text = " - Normal Pulse Rate"
                ElseIf pulseValue > 100 Then
                    pulseResult.Text = " - High Pulse Rate (Seek Medical Attention)"
                End If
            Else
                ' Display an error message if the pulse rate value is not a valid number
                pulseResult.Text = " - Invalid pulse rate value"

                pulseResult.Visible = True
            End If
        Else
            ' Clear the pulse rate result label if the value is empty
            pulseResult.Text = ""
        End If
    End Sub

End Class