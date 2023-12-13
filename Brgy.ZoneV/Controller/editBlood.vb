Imports MySql.Data.MySqlClient

Public Class editBlood
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim bloodId As Integer
    Dim patientId As Integer ' You need to declare patientId

    Public Sub New(bloodId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.bloodId = bloodId

        ' Load referral data based on the ID
        LoadReferralData()
    End Sub

    Private Sub LoadReferralData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch referral data based on the ID
                Dim selectQuery As String = "SELECT b.blood_id, b.blood_date, p.fname, p.mname, p.lname, b.blood_reading, p.gender, TIMESTAMPDIFF(YEAR, p.dob, CURDATE()) AS Age, p.dob, " &
                                            "b.pulse, b.patient_id " & ' Include patient_id in the SELECT statement
                                            "FROM bzvhcims.blood_pressure b " &
                                            "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                                            "WHERE b.blood_id = @bloodId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@bloodId", bloodId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with referral data
                            patientsname.Text = reader("fname").ToString() & " " & reader("mname").ToString() & " " & reader("lname").ToString()
                            gender.Text = reader("gender").ToString()
                            age.Text = reader("Age").ToString()
                            dob.Value = Convert.ToDateTime(reader("dob"))
                            dtTime.Value = Convert.ToDateTime(reader("blood_date")) ' Use Convert.ToDateTime to convert to DateTime
                            patientId = Convert.ToInt32(reader("patient_id")) ' Assign patient_id to the class-level variable
                            Dim bloodReading As String = reader("blood_reading").ToString()
                            If bloodReading.Contains("/") Then
                                Dim bloodPressureParts As String() = bloodReading.Split("/"c)
                                If bloodPressureParts.Length = 2 Then
                                    systolic.Text = bloodPressureParts(0).Trim()
                                    diastolic.Text = bloodPressureParts(1).Trim()
                                End If
                            End If
                            pulse.Text = reader("pulse").ToString()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading blood pressure data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Update referral data based on the ID
                Dim updateQuery As String = "UPDATE bzvhcims.blood_pressure SET " &
                                    "blood_date = @bloodDate, " &
                                    "blood_reading = @blood_reading, " &
                                    "pulse = @pulse " &
                                    "WHERE blood_id = @blood_id"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@bloodDate", dtTime.Value)
                    cmd.Parameters.AddWithValue("@blood_reading", systolic.Text & " / " & diastolic.Text)
                    cmd.Parameters.AddWithValue("@pulse", pulse.Text)
                    cmd.Parameters.AddWithValue("@blood_id", bloodId)

                    ' Execute the update query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Blood Pressure data updated successfully.")
                    Else
                        MessageBox.Show("No rows were updated. Please check the blood pressure ID.")
                    End If
                End Using

                ' Insert into the blood_pressuresaverecord table
                Dim bloodPressureSaveRecordQuery As String = "INSERT INTO bzvhcims.blood_pressuresaverecord (patient_id, blood_date, blood_reading, pulse) VALUES (@value1, @value2, @value3, @value4)"
                Dim bloodPressureSaveRecordCmd As New MySqlCommand(bloodPressureSaveRecordQuery, conn)
                bloodPressureSaveRecordCmd.Parameters.AddWithValue("@value1", patientId)
                bloodPressureSaveRecordCmd.Parameters.AddWithValue("@value2", dtTime.Value)
                bloodPressureSaveRecordCmd.Parameters.AddWithValue("@value3", systolic.Text & " / " & diastolic.Text)
                bloodPressureSaveRecordCmd.Parameters.AddWithValue("@value4", pulse.Text)

                ' Execute the bloodPressureSaveRecord query
                bloodPressureSaveRecordCmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error updating blood pressure data: " & ex.Message)
            End Try
        End Using
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
                    bloodResult.Text += " - Low Blood Pressure"
                ElseIf systolicValue >= 90 AndAlso systolicValue <= 120 AndAlso diastolicValue >= 60 AndAlso diastolicValue <= 80 Then
                    bloodResult.Text += " - Normal Blood Pressure"
                ElseIf systolicValue > 120 AndAlso systolicValue <= 130 AndAlso diastolicValue > 80 AndAlso diastolicValue <= 85 Then
                    bloodResult.Text += " - Elevated Blood Pressure (Prehypertension)"
                ElseIf systolicValue > 130 AndAlso systolicValue <= 140 AndAlso diastolicValue > 85 AndAlso diastolicValue <= 90 Then
                    bloodResult.Text += " - Stage 1 Hypertension"
                ElseIf systolicValue > 140 AndAlso diastolicValue > 90 Then
                    bloodResult.Text += " - Stage 2 Hypertension (Seek Medical Attention)"
                End If
            Else
                ' Display an error message if the blood pressure values are not valid numbers
                bloodResult.Text = "Invalid blood pressure values"
            End If
        Else
            ' Clear the blood pressure result label if the values are empty
            bloodResult.Text = ""
        End If
    End Sub

    Private Sub pulse_TextChanged_1(sender As Object, e As EventArgs) Handles pulse.TextChanged
        pulseResults()
    End Sub
    Private Sub pulseResults()
        ' Check if the pulse rate value is not empty
        If Not String.IsNullOrEmpty(pulse.Text.Trim()) Then
            ' Parse the pulse rate value
            If Integer.TryParse(pulse.Text.Trim(), Nothing) Then
                ' Get the numeric value of the pulse rate
                Dim pulseValue As Integer = Integer.Parse(pulse.Text.Trim())

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
            End If
        Else
            ' Clear the pulse rate result label if the value is empty
            pulseResult.Text = ""
        End If
    End Sub
End Class
