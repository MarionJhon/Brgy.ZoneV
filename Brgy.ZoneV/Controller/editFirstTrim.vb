Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports MySql.Data.MySqlClient

Public Class editFirstTrim

    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim firstTrimId As Integer
    Dim patientId As Integer

    Public Sub New(firstTrimId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.firstTrimId = firstTrimId

        ' Load referral data based on the ID
        LoadFirstTrimData()
    End Sub

    Private Sub LoadFirstTrimData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch referral data based on the ID
                Dim selectQuery As String = "SELECT f.first_trim_id, f.date_of_visit, p.fname, p.mname, p.lname, f.g_a_at_first_visit, f.blood_pressure, f.weight, f.uri_result, f.hemog_level, p.dob, f.patient_id " &
                                            "FROM bzvhcims.first_trim f " &
                                            "INNER JOIN bzvhcims.patient p ON f.patient_id = p.patient_id " &
                                            "WHERE f.first_trim_id = @firstTrimId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@firstTrimId", firstTrimId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with referral data
                            patientsname.Text = reader("fname").ToString() & " " & reader("mname").ToString() & " " & reader("lname").ToString()
                            doFV.Value = Convert.ToDateTime(reader("date_of_visit"))
                            age.Text = CalculateAge(reader.GetDateTime("dob")).ToString()
                            dob.Value = Convert.ToDateTime(reader("dob"))
                            gAFT.Text = reader("g_a_at_first_visit").ToString()
                            patientId = Convert.ToInt32(reader("patient_id"))
                            Dim bloodReading As String = reader("blood_pressure").ToString()
                            If bloodReading.Contains("/") Then
                                Dim bloodPressureParts As String() = bloodReading.Split("/"c)
                                If bloodPressureParts.Length = 2 Then
                                    systolic.Text = bloodPressureParts(0).Trim()
                                    diastolic.Text = bloodPressureParts(1).Trim()
                                End If
                            End If
                            weight.Text = reader("weight").ToString()
                            uriResult.SelectedItem = reader("uri_result").ToString()
                            hemogLvl.Text = reader("hemog_level").ToString()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading first trimester data: " & ex.Message)
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

                ' Update referral data based on the ID
                Dim updateQuery As String = "UPDATE bzvhcims.first_trim SET " &
                                            "date_of_visit = @dov, " &
                                            "g_a_at_first_visit = @gafv, " &
                                            "blood_pressure = @bp, " &
                                            "weight = @w, " &
                                            "uri_result = @ur, " &
                                            "hemog_level = @hl " &
                                            "WHERE first_trim_id  = @fti"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@dov", doFV.Value)
                    cmd.Parameters.AddWithValue("@gafv", gAFT.Text)
                    cmd.Parameters.AddWithValue("@bp", systolic.Text & " / " & diastolic.Text)
                    cmd.Parameters.AddWithValue("@w", weight.Text)
                    cmd.Parameters.AddWithValue("@ur", uriResult.SelectedItem)
                    cmd.Parameters.AddWithValue("@hl", hemogLvl.Text)
                    cmd.Parameters.AddWithValue("@fti", firstTrimId)

                    ' Execute the update query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("First Trimester data updated successfully.")
                    Else
                        MessageBox.Show("No rows were updated. Please check the First Trimester ID.")
                    End If
                End Using

                Dim firstTrimesterSaveRecordQuery As String = "INSERT INTO bzvhcims.first_trim_saverecord (patient_id, date_of_visit, gestational_age, blood_pressure, weight, uri_result, hemog_level) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7)"
                Using firstTrimesterSaveRecordCmd As New MySqlCommand(firstTrimesterSaveRecordQuery, conn)
                    firstTrimesterSaveRecordCmd.Parameters.AddWithValue("@value1", patientId)
                    firstTrimesterSaveRecordCmd.Parameters.AddWithValue("@value2", doFV.Value)
                    firstTrimesterSaveRecordCmd.Parameters.AddWithValue("@value3", gAFT.Text)
                    firstTrimesterSaveRecordCmd.Parameters.AddWithValue("@value4", systolic.Text & " / " & diastolic.Text)
                    firstTrimesterSaveRecordCmd.Parameters.AddWithValue("@value5", weight.Text)
                    firstTrimesterSaveRecordCmd.Parameters.AddWithValue("@value6", uriResult.SelectedItem)
                    firstTrimesterSaveRecordCmd.Parameters.AddWithValue("@value7", hemogLvl.Text)

                    Dim rowsAffectedFirstTrimesteSaveRecord As Integer = firstTrimesterSaveRecordCmd.ExecuteNonQuery()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error updating First Trimester data: " & ex.Message)
            End Try
        End Using
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

    Private Sub editFirstTrim_Load(sender As Object, e As EventArgs)
        bloodPressureResult()
        weightResults()
    End Sub

    Private Sub editFirstTrim_TextChanged(sender As Object, e As EventArgs) Handles diastolic.TextChanged, systolic.TextChanged
        bloodPressureResult()
    End Sub

    Private Sub weight_TextChanged(sender As Object, e As EventArgs) Handles weight.TextChanged
        weightResults()
    End Sub
End Class