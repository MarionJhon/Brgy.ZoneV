Imports MySql.Data.MySqlClient

Public Class secondTrimester
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim pregnantId As Integer
    Dim patientId As Integer
    Dim errorProvider As New ErrorProvider()


    Public Sub New(pregnantId As Integer, patientId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.pregnantId = pregnantId
        Me.patientId = patientId

        ' Load referral data based on the ID
        LoadDataByPregnantId(pregnantId)
        LoadDataIntoDataGridView(patientId)
    End Sub

    Public Property ParentForm As pregnantProgress

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Label11.Click, PictureBox1.Click
        If ParentForm IsNot Nothing Then
            ParentForm.ShowPregnantProgressForm()
        End If
    End Sub

    Public Sub LoadDataIntoDataGridView(patientId As Integer)
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Add a WHERE clause to filter the results based on the search criteria
                Dim selectQuery As String = "SELECT s.second_trim_id, s.patient_id, s.date_of_visit, CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS Fullname , TIMESTAMPDIFF(YEAR, p.dob, CURDATE()) AS Age " &
                                        "FROM bzvhcims.second_trim s " &
                                        "INNER JOIN bzvhcims.patient p ON s.patient_id = p.patient_id " &
                                        "WHERE s.patient_id = @patient"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)

                    adapter.SelectCommand.Parameters.AddWithValue("@patient", patientId)

                    adapter.Fill(dataTable)
                    secondDatagrid.DataSource = dataTable
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub LoadDataByPregnantId(pregnantId As Integer)

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch referral data based on the ID
                Dim selectQuery As String = "SELECT n.pregnant_id, p.fname, p.mname, p.lname, p.dob" &
                                    " FROM bzvhcims.pregnant n " &
                                    " INNER JOIN bzvhcims.patient p ON n.patient_id = p.patient_id " &
                                    " WHERE n.pregnant_id = @pregnantId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@pregnantId", pregnantId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with referral data
                            patientsname.Text = reader("fname").ToString() & " " & reader("mname").ToString() & " " & reader("lname").ToString()
                            age.Text = CalculateAge(reader.GetDateTime("dob")).ToString()
                            dob.Value = Convert.ToDateTime(reader("dob"))
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading pregnant data: " & ex.Message)
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                If String.IsNullOrEmpty(gaSV.Text.Trim()) Then
                    errorProvider.SetError(gaSV, "Gestational Age at Second Visit is required.")
                Else
                    errorProvider.SetError(gaSV, "") ' Clear error if valid
                End If

                ' Validate blood pressure
                If String.IsNullOrEmpty(systolic.Text.Trim()) OrElse String.IsNullOrEmpty(diastolic.Text.Trim()) Then
                    ErrorProvider.SetError(diastolic, "Systolic and Diastolic are required.")
                Else
                    ErrorProvider.SetError(diastolic, "") ' Clear error if valid
                End If

                ' Validate weight
                If String.IsNullOrEmpty(weight.Text.Trim()) Then
                    ErrorProvider.SetError(weight, "Weight is required.")
                Else
                    ErrorProvider.SetError(weight, "") ' Clear error if valid
                End If

                ' Validate urine result
                If ultraResult.SelectedItem Is Nothing Then
                    errorProvider.SetError(ultraResult, "Ultra Sound is required.")
                Else
                    errorProvider.SetError(ultraResult, "") ' Clear error if valid
                End If

                ' Validate hemoglobin level
                If String.IsNullOrEmpty(fhRate.Text.Trim()) Then
                    errorProvider.SetError(fhRate, "Fetal Health is required.")
                Else
                    errorProvider.SetError(fhRate, "") ' Clear error if valid
                End If

                ' If any validation failed, exit the method
                If errorProvider.GetError(gaSV) <> "" OrElse
                    errorProvider.GetError(diastolic) <> "" OrElse
                    errorProvider.GetError(weight) <> "" OrElse
                    errorProvider.GetError(ultraResult) <> "" OrElse
                    errorProvider.GetError(fhRate) <> "" Then
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
                    Dim checkExistingQuery As String = "SELECT COUNT(*) FROM bzvhcims.second_trim WHERE patient_id = @patientId"
                    Dim checkExistingCmd As New MySqlCommand(checkExistingQuery, conn)
                    checkExistingCmd.Parameters.AddWithValue("@patientId", patientId)

                    Dim existingCount As Integer = CInt(checkExistingCmd.ExecuteScalar())

                    If existingCount = 0 Then
                        ' Insert data into the referral table with patient_id as a foreign key
                        Dim query As String = "INSERT INTO bzvhcims.second_trim (date_of_visit, gestational_age, weight, blood_pressure, fetal_heart_rate, ultrasound_result, patient_id) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7)"
                        Dim cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@value1", doSV.Value)
                        cmd.Parameters.AddWithValue("@value2", gaSV.Text)
                        cmd.Parameters.AddWithValue("@value3", weight.Text)
                        cmd.Parameters.AddWithValue("@value4", systolic.Text & " / " & diastolic.Text)
                        cmd.Parameters.AddWithValue("@value5", fhRate.Text)
                        cmd.Parameters.AddWithValue("@value6", ultraResult.SelectedItem)
                        cmd.Parameters.AddWithValue("@value7", patientId)

                        Dim rowAffected As Integer = cmd.ExecuteNonQuery()

                        If rowAffected > 0 Then
                            MessageBox.Show("Data inserted successfully into the second trimester table!")
                            LoadDataIntoDataGridView(patientId)
                        Else
                            MessageBox.Show("Failed to insert data into second trimester table.")
                        End If

                        Dim secondTrimesterSaveRecordQuery As String = "INSERT INTO bzvhcims.second_trim_saverecord (patient_id, date_of_vist, gestational_age, weight, blood_pressure, fetalH_rate, ultra_result) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7)"
                        Using secondTrimesteSaveRecordCmd As New MySqlCommand(secondTrimesterSaveRecordQuery, conn)
                            secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value1", patientId)
                            secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value2", doSV.Value)
                            secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value3", gaSV.Text)
                            secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value4", weight.Text)
                            secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value5", systolic.Text & " / " & diastolic.Text)
                            secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value6", fhRate.Text)
                            secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value7", ultraResult.SelectedItem)

                            Dim rowsAffectedSecondTrimesteSaveRecord As Integer = secondTrimesteSaveRecordCmd.ExecuteNonQuery()
                        End Using

                    Else
                        MessageBox.Show("Data already exists in second trimester table for the given patient.")
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

    Private Sub secondTrimester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        doSV.Value = DateTime.Today
        LoadDataByPregnantId(pregnantId)
        LoadDataIntoDataGridView(patientId)
    End Sub

    Private Sub secondDatagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles secondDatagrid.CellContentClick
        If e.ColumnIndex = secondDatagrid.Columns("information").Index AndAlso e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = secondDatagrid.Rows(e.RowIndex)
                'Dim referralId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("referral").Value)
                Dim patientId As Integer = Convert.ToInt32(secondDatagrid.Rows(e.RowIndex).Cells("patient_id").Value)
                Dim fullName As String = row.Cells("fullname").Value.ToString()
                Dim view As New secondTrimesterView(fullName, patientId)
                view.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - view.Width) / 2, 0)
                tranparentBG.ShowForm(view)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub secondDatagrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles secondDatagrid.CellContentDoubleClick
        ' Check if the clicked cell is not a header cell and a valid row is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the ID from the selected row
            Dim secondTrimId As Integer = Convert.ToInt32(secondDatagrid.Rows(e.RowIndex).Cells("ID").Value)
            ' Assuming "ID" is the name of the column containing the referral ID.

            ' Open the edit form with the selected ID
            Dim frm As New editSecondTrim(secondTrimId)
            frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
            tranparentBG.ShowForm(frm)
        End If

        LoadDataIntoDataGridView(patientId)
    End Sub

    Private Sub diastolic_TextChanged(sender As Object, e As EventArgs) Handles diastolic.TextChanged, systolic.TextChanged
        bloodPressureResult()
    End Sub

    Private Sub bloodPressureResult()
        ' Clear previous results
        bloodResult.Text = ""

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
            End If
        Else
            ' Clear the blood pressure result label if the values are empty
            bloodResult.Text = ""
        End If
    End Sub

    Private Sub weight_TextChanged(sender As Object, e As EventArgs) Handles weight.TextChanged
        weightResults()
    End Sub

    Private Sub weightResults()
        ' Clear previous results
        weightResult.Text = ""

        ' Check if the weight value is not empty
        If Not String.IsNullOrEmpty(weight.Text.Trim()) Then
            ' Parse the weight value
            If Double.TryParse(weight.Text.Trim(), Nothing) Then
                ' Get the numeric value of weight
                Dim weightValue As Double = Double.Parse(weight.Text.Trim())

                ' Check the weight range and provide a description
                If weightValue < 18.5 Then
                    weightResult.Text = " - Underweight"
                ElseIf weightValue >= 18.5 AndAlso weightValue < 24.9 Then
                    weightResult.Text = " - Normal Weight"
                ElseIf weightValue >= 25 AndAlso weightValue < 29.9 Then
                    weightResult.Text = " - Overweight"
                ElseIf weightValue >= 30 Then
                    weightResult.Text = " - Obesity"
                End If

                ' Show the weightResult label
                weightResult.Visible = True
            Else
                ' Display a user-friendly message if the weight value is not a valid number
                weightResult.Text = " - Invalid weight value"

                ' Show the weightResult label
                weightResult.Visible = True
            End If
        Else
            ' Hide the weightResult label if the value is empty
            weightResult.Visible = False
        End If
    End Sub


End Class
