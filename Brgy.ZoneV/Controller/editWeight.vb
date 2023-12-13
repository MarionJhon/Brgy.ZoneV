Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports MySql.Data.MySqlClient

Public Class editWeight
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim weighingId As Integer

    Public Sub New(weighingId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.weighingId = weighingId



        ' Load referral data based on the ID
        LoadReferralData()
    End Sub

    Private Sub LoadReferralData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch weighing data based on the ID
                Dim selectQuery As String = "SELECT b.babys_name, b.gender, w.weight, w.weighing_date, b.date_of_delivery, CONCAT(p.fname,' ', p.mname,' ', lname ) AS parents_name " &
                                        "FROM bzvhcims.weighing w " &
                                        "INNER JOIN bzvhcims.birthingsaverecord b ON w.birthing_id = b.birthing_save_record_id " &
                                        "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                                        "WHERE w.weighing_id = @weighingId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@weighingId", weighingId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with weighing, birthingsaverecord, and patient data
                            childNm.Text = reader("babys_name").ToString()
                            gender.Text = reader("gender").ToString()

                            ' Calculate age
                            Dim birthDate As DateTime = Convert.ToDateTime(reader("date_of_delivery"))
                            Dim ageInYears As Integer = DateTime.Today.Year - birthDate.Year

                            ' Display age in the age textbox
                            age.Text = ageInYears.ToString()

                            dob.Value = Convert.ToDateTime(reader("date_of_delivery"))
                            prntNm.Text = reader("parents_name").ToString() ' Assuming 'parents_name' is a column in the 'patient' table
                            wght.Text = reader("weight").ToString()
                            wghtDate.Value = Convert.ToDateTime(reader("weighing_date"))
                        Else
                            MessageBox.Show("No weighing data found for the provided ID.")
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading weighing data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Update weighing data based on the ID
                Dim updateQuery As String = "UPDATE bzvhcims.weighing SET " &
                                    "weight = @wght, " &
                                    "weighing_date = @wghtDate " &
                                    "WHERE weighing_id = @weighingId"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@wght", wght.Text)
                    cmd.Parameters.AddWithValue("@wghtDate", wghtDate.Value)
                    cmd.Parameters.AddWithValue("@weighingId", weighingId)

                    ' Execute the update query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Weighing data updated successfully.")
                    Else
                        MessageBox.Show("No rows were updated. Please check the Weighing ID.")
                    End If
                End Using

                ' Fetch birthing_id from the weighing table
                Dim selectBirthingIdQuery As String = "SELECT birthing_id FROM bzvhcims.weighing WHERE weighing_id = @weighingId"

                Using cmdSelectBirthingId As New MySqlCommand(selectBirthingIdQuery, conn)
                    cmdSelectBirthingId.Parameters.AddWithValue("@weighingId", weighingId)

                    Dim birthingId As Integer = Convert.ToInt32(cmdSelectBirthingId.ExecuteScalar())

                    ' Insert into weighingsaverecord
                    Dim weighingSaveRecordQuery As String = "INSERT INTO bzvhcims.weighingsaverecord (birthing_id, weight_date, weight) VALUES (@birthingId, @value2, @value3)"
                    Dim weighingSaveRecordCmd As New MySqlCommand(weighingSaveRecordQuery, conn)
                    weighingSaveRecordCmd.Parameters.AddWithValue("@birthingId", birthingId)
                    weighingSaveRecordCmd.Parameters.AddWithValue("@value2", wghtDate.Value)
                    weighingSaveRecordCmd.Parameters.AddWithValue("@value3", wght.Text)

                    ' Execute the weighingsaverecord insertion query
                    weighingSaveRecordCmd.ExecuteNonQuery()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error updating Weighing data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub wght_TextChanged(sender As Object, e As EventArgs) Handles wght.TextChanged
        weightResults()
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
End Class