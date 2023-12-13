Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports MySql.Data.MySqlClient

Public Class editBirthing
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim birthId As Integer
    Dim patientId As Integer

    Public Sub New(birthId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.birthId = birthId

        ' Load referral data based on the ID
        LoadReferralData()
    End Sub

    Private Sub LoadReferralData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch referral data based on the ID
                Dim selectQuery As String = "SELECT b.birthing_id, p.fname, p.mname, p.lname, b.type_of_delivery, b.date_of_delivery, b.time_of_delivery, b.attending_healthworker_midwife, p.dob , b.patient_id " &
                                "FROM bzvhcims.birthing b " &
                                "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                                "WHERE b.birthing_id = @birthId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@birthId", birthId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with referral data
                            patient.Text = reader("fname").ToString() & " " & reader("mname").ToString() & " " & reader("lname").ToString()
                            age.Text = CalculateAge(reader.GetDateTime("dob")).ToString()
                            dtBirth.Value = Convert.ToDateTime(reader("dob"))
                            typDelivery.SelectedItem = reader("type_of_delivery").ToString()
                            dtDelivery.Text = Convert.ToDateTime(reader("date_of_delivery"))
                            tof.Text = DateTime.Now.ToString("HH:mm")
                            nmAttend.Text = reader("attending_healthworker_midwife").ToString()
                            patientId = Convert.ToInt32(reader("patient_id"))
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading referral data: " & ex.Message)
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
                Dim birthWeight As Double

                ' Check if the birth weight is a valid number
                If Double.TryParse(brtWeight.Text, birthWeight) Then
                    ' Check if the birth weight is not over 12.5
                    If birthWeight <= 12.5 Then
                        ' Continue with the update query
                        Dim updateQuery As String = "UPDATE bzvhcims.birthing SET " &
                                    "type_of_delivery = @tyod, " &
                                    "date_of_delivery = @dod, " &
                                    "time_of_delivery = @tod, " &
                                    "attending_healthworker_midwife = @attending " &
                                    "WHERE birthing_id = @birthlId"

                        Using cmd As New MySqlCommand(updateQuery, conn)
                            cmd.Parameters.AddWithValue("@tyod", typDelivery.SelectedItem)
                            cmd.Parameters.AddWithValue("@dod", dtDelivery.Value)
                            cmd.Parameters.AddWithValue("@tod", tof.Text)
                            cmd.Parameters.AddWithValue("@attending", nmAttend.Text)
                            cmd.Parameters.AddWithValue("@birthlId", birthId)

                            ' Execute the update query
                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Birthing data updated successfully.")
                            Else
                                MessageBox.Show("No rows were updated. Please check the Birthing ID.")
                            End If
                        End Using
                    Else
                        MessageBox.Show("Birth weight cannot be over 12.5. Please enter a valid weight.")
                    End If
                Else
                    MessageBox.Show("Invalid birth weight. Please enter a valid numeric value.")
                End If


                ' Insert into the blood_pressuresaverecord table
                Dim birthingSaveRecordQuery As String = "INSERT INTO bzvhcims.birthingsaverecord (patient_id, babys_name, gender, date_of_delivery, attend_healthworker) VALUES (@value1, @value2, @value3, @value4, @value5)"
                Dim birthingSaveRecordCmd As New MySqlCommand(birthingSaveRecordQuery, conn)
                birthingSaveRecordCmd.Parameters.AddWithValue("@value1", patientId)
                birthingSaveRecordCmd.Parameters.AddWithValue("@value2", bbyNm.Text)
                birthingSaveRecordCmd.Parameters.AddWithValue("@value3", genderCbx.SelectedItem)
                birthingSaveRecordCmd.Parameters.AddWithValue("@value4", dtDelivery.Value)
                birthingSaveRecordCmd.Parameters.AddWithValue("@value5", nmAttend.Text)

                ' Execute the bloodPressureSaveRecord query
                birthingSaveRecordCmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error updating birthing data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub brtWeight_TextChanged(sender As Object, e As EventArgs) Handles brtWeight.TextChanged
        weightResults()
    End Sub

    Private Sub weightResults()
        ' Clear previous results
        weightResultLabel.Text = ""

        ' Check if the weight value is not empty
        If Not String.IsNullOrEmpty(brtWeight.Text.Trim()) Then
            ' Parse the weight value
            If Double.TryParse(brtWeight.Text.Trim(), Nothing) Then
                ' Get the numeric value of weight
                Dim weightValue As Double = Double.Parse(brtWeight.Text.Trim())

                ' Check the weight range and provide a description
                If weightValue < 5.5 Then
                    weightResultLabel.Text = " - Low Birth Weight"
                ElseIf weightValue >= 5.5 AndAlso weightValue < 8.8 Then
                    weightResultLabel.Text = " - Normal Birth Weight"
                ElseIf weightValue >= 8.8 AndAlso weightValue < 12.5 Then
                    weightResultLabel.Text = " - High Birth Weight"
                Else
                    weightResultLabel.Text = " - Invalid weight value"
                End If

                ' Show the weightResult label
                weightResultLabel.Visible = True
            Else
                ' Display a user-friendly message if the weight value is not a valid number
                weightResultLabel.Text = " - Invalid weight value"

                ' Show the weightResult label
                weightResultLabel.Visible = True
            End If
        Else
            ' Hide the weightResult label if the value is empty
            weightResultLabel.Visible = False
        End If
    End Sub
End Class