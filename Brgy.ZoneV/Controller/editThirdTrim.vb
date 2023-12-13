Imports MySql.Data.MySqlClient

Public Class editThirdTrim
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim thirdTrimId As Integer
    Dim patientId As Integer

    Public Sub New(thirdTrimId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.thirdTrimId = thirdTrimId

        ' Load referral data based on the ID
        LoadThirdTrimData()
    End Sub

    Private Sub LoadThirdTrimData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch referral data based on the ID
                Dim selectQuery As String = "SELECT t.third_trim_id, t.date_of_visit, p.fname, p.mname, p.lname, t.gestational_age, t.blood_pressure, t.weight, t.fetal_pos, t.fundal_height, t.edema, p.dob, t.patient_id " &
                                            "FROM bzvhcims.third_trim t " &
                                            "INNER JOIN bzvhcims.patient p ON t.patient_id = p.patient_id " &
                                            "WHERE t.third_trim_id = @thirdTrimId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@thirdTrimId", thirdTrimId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with referral data
                            patientsname.Text = $"{reader("fname")} {reader("mname")} {reader("lname")}"
                            doTV.Value = If(DateTime.TryParse(reader("date_of_visit").ToString(), Nothing), Convert.ToDateTime(reader("date_of_visit")), DateTime.MinValue)
                            age.Text = CalculateAge(reader.GetDateTime("dob")).ToString()
                            dob.Value = If(DateTime.TryParse(reader("dob").ToString(), Nothing), Convert.ToDateTime(reader("dob")), DateTime.MinValue)
                            gaTV.Text = reader("gestational_age").ToString()
                            patientId = Convert.ToInt32(reader("patient_id"))

                            ' Handle blood pressure reading
                            Dim bloodReading As String = reader("blood_pressure").ToString()
                            If bloodReading.Contains("/") Then
                                Dim bloodPressureParts As String() = bloodReading.Split("/"c)
                                If bloodPressureParts.Length = 2 Then
                                    systolic.Text = bloodPressureParts(0).Trim()
                                    diastolic.Text = bloodPressureParts(1).Trim()
                                End If
                            End If

                            weight.Text = reader("weight").ToString()
                            fetalPos.Text = reader("fetal_pos").ToString()
                            fundalHeight.Text = reader("fundal_height").ToString()

                            ' Handle edema
                            Dim edemaValue As String = reader("edema").ToString()
                            If edema.Items.Contains(edemaValue) Then
                                edema.SelectedItem = edemaValue
                            End If
                        Else
                            MessageBox.Show("No data found for the specified third trimester ID.")
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading third trimester data: " & ex.Message)
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
                Dim updateQuery As String = "UPDATE bzvhcims.third_trim SET " &
                                            "date_of_visit = @dov, " &
                                            "gestational_age = @ga, " &
                                            "blood_pressure = @bp, " &
                                            "weight = @w, " &
                                            "fetal_pos = @fp, " &
                                            "fundal_height = @fh, " &
                                            "edema = @e " &
                                            "WHERE third_trim_id  = @tti"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@dov", doTV.Value)
                    cmd.Parameters.AddWithValue("@ga", gaTV.Text)
                    cmd.Parameters.AddWithValue("@bp", systolic.Text & " / " & diastolic.Text)
                    cmd.Parameters.AddWithValue("@w", weight.Text)
                    cmd.Parameters.AddWithValue("@fp", fetalPos.Text)
                    cmd.Parameters.AddWithValue("@fh", fundalHeight.Text)
                    cmd.Parameters.AddWithValue("@e", edema.SelectedItem)
                    cmd.Parameters.AddWithValue("@tti", thirdTrimId)

                    ' Execute the update query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Third Trimester data updated successfully.")
                    Else
                        MessageBox.Show("No rows were updated. Please check the Third Trimester ID.")
                    End If
                End Using

                Dim thirdTrimesteSaveRecordQuery As String = "INSERT INTO bzvhcims.third_trim_saverecord (patient_id, date_of_visit, gestational_age, blood_pressure, weight, fetal_pos, fundal_height, edema) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8)"
                Using thirdTrimesteSaveRecordCmd As New MySqlCommand(thirdTrimesteSaveRecordQuery, conn)
                    thirdTrimesteSaveRecordCmd.Parameters.AddWithValue("@value1", patientId)
                    thirdTrimesteSaveRecordCmd.Parameters.AddWithValue("@value2", doTV.Value)
                    thirdTrimesteSaveRecordCmd.Parameters.AddWithValue("@value3", gaTV.Text)
                    thirdTrimesteSaveRecordCmd.Parameters.AddWithValue("@value4", systolic.Text & " / " & diastolic.Text)
                    thirdTrimesteSaveRecordCmd.Parameters.AddWithValue("@value5", weight.Text)
                    thirdTrimesteSaveRecordCmd.Parameters.AddWithValue("@value6", fetalPos.Text)
                    thirdTrimesteSaveRecordCmd.Parameters.AddWithValue("@value7", fundalHeight.Text)
                    thirdTrimesteSaveRecordCmd.Parameters.AddWithValue("@value8", edema.SelectedItem)


                    Dim rowsAffectedThirdTrimesteSaveRecord As Integer = thirdTrimesteSaveRecordCmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating Third Trimester data: " & ex.Message)
            End Try
        End Using
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