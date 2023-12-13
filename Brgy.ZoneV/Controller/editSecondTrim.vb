Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports MySql.Data.MySqlClient

Public Class editSecondTrim
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim secondTrimId As Integer
    Dim patientId As Integer

    Public Sub New(secondTrimId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.secondTrimId = secondTrimId

        ' Load referral data based on the ID
        LoadSecondTrimData()
    End Sub

    Private Sub LoadSecondTrimData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch referral data based on the ID
                Dim selectQuery As String = "SELECT s.second_trim_id, s.date_of_visit, p.fname, p.mname, p.lname, s.gestational_age, s.blood_pressure, s.weight, s.fetal_heart_rate, s.ultrasound_result, p.dob, s.patient_id " &
                                            "FROM bzvhcims.second_trim s " &
                                            "INNER JOIN bzvhcims.patient p ON s.patient_id = p.patient_id " &
                                            "WHERE s.second_trim_id = @secondTrimId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@secondTrimId", secondTrimId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with referral data
                            patientsname.Text = reader("fname").ToString() & " " & reader("mname").ToString() & " " & reader("lname").ToString()
                            doSV.Value = Convert.ToDateTime(reader("date_of_visit"))
                            age.Text = CalculateAge(reader.GetDateTime("dob")).ToString()
                            dob.Value = Convert.ToDateTime(reader("dob"))
                            gASV.Text = reader("gestational_age").ToString()
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
                            ftRate.Text = reader("fetal_heart_rate").ToString()
                            ultraResult.SelectedItem = reader("ultrasound_result").ToString()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading second trimester data: " & ex.Message)
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


    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Update referral data based on the ID
                Dim updateQuery As String = "UPDATE bzvhcims.second_trim SET " &
                                            "date_of_visit = @dov, " &
                                            "gestational_age = @gafv, " &
                                            "weight = @w, " &
                                            "blood_pressure = @bp, " &
                                            "fetal_heart_rate = @fhr, " &
                                            "ultrasound_result = @ur " &
                                            "WHERE second_trim_id  = @sti"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@dov", doSV.Value)
                    cmd.Parameters.AddWithValue("@gafv", gASV.Text)
                    cmd.Parameters.AddWithValue("@w", weight.Text)
                    cmd.Parameters.AddWithValue("@bp", systolic.Text & " / " & diastolic.Text)
                    cmd.Parameters.AddWithValue("@fhr", ftRate.Text)
                    cmd.Parameters.AddWithValue("@ur", ultraResult.SelectedItem)
                    cmd.Parameters.AddWithValue("@sti", secondTrimId)

                    ' Execute the update query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Second Trimester data updated successfully.")
                    Else
                        MessageBox.Show("No rows were updated. Please check the Second Trimester ID.")
                    End If
                End Using

                Dim secondTrimesterSaveRecordQuery As String = "INSERT INTO bzvhcims.second_trim_saverecord (patient_id, date_of_vist, gestational_age, weight, blood_pressure, fetalH_rate, ultra_result) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7)"
                Using secondTrimesteSaveRecordCmd As New MySqlCommand(secondTrimesterSaveRecordQuery, conn)
                    secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value1", patientId)
                    secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value2", doSV.Value)
                    secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value3", gASV.Text)
                    secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value4", weight.Text)
                    secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value5", systolic.Text & " / " & diastolic.Text)
                    secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value6", ftRate.Text)
                    secondTrimesteSaveRecordCmd.Parameters.AddWithValue("@value7", ultraResult.SelectedItem)

                    Dim rowsAffectedSecondTrimesteSaveRecord As Integer = secondTrimesteSaveRecordCmd.ExecuteNonQuery()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error updating Second Trimester data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub diastolic_TextChanged(sender As Object, e As EventArgs)
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

    Private Sub weight_TextChanged(sender As Object, e As EventArgs)
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