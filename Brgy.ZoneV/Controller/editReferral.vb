Imports MySql.Data.MySqlClient

Public Class editReferral
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim referralId As Integer
    Dim patientId As Integer

    Public Sub New(referralId As Integer, patientId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.referralId = referralId
        Me.patientId = patientId


        ' Load referral data based on the ID
        LoadReferralData()
    End Sub

    Private Sub LoadReferralData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch referral data based on the ID
                Dim selectQuery As String = "SELECT r.referralID, p.fname, p.mname, p.lname, p.gender, p.dob, r.referral_date, r.reason_of_referral, r.refer_place, r.temperature, r.blood_pressure, r.weight, r.height " &
                            "FROM bzvhcims.referral r " &
                            "INNER JOIN bzvhcims.patient p ON r.patient_id = p.patient_id " &
                             "WHERE r.ID = @referralId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@referralId", referralId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with referral data
                            patientsname.Text = $"{reader("fname")} {reader("mname")} {reader("lname")}"
                            gender.Text = reader("gender").ToString()
                            age.Text = CalculateAge(reader.GetDateTime("dob")).ToString()
                            dob.Value = reader.GetDateTime("dob")
                            referral_id.Text = reader("referralID").ToString()
                            referral_date.Value = reader.GetDateTime("referral_date")
                            refer_place.Text = reader("refer_place").ToString()
                            temp.Text = reader("temperature").ToString()

                            ' Split and handle blood pressure
                            Dim bloodReading As String = reader("blood_pressure").ToString()
                            If bloodReading.Contains("/") Then
                                Dim bloodPressureParts As String() = bloodReading.Split("/"c)
                                If bloodPressureParts.Length = 2 Then
                                    systolic.Text = bloodPressureParts(0).Trim()
                                    diastolic.Text = bloodPressureParts(1).Trim()
                                End If
                            End If

                            weight.Text = reader("weight").ToString()
                            height.Text = reader("height").ToString()
                            reason.Text = reader("reason_of_referral").ToString()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show($"Error loading referral data: {ex.Message}")
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
                Dim updateQuery As String = "UPDATE bzvhcims.referral " &
                                           "SET referral_date = @referral_date, " &
                                               "refer_place = @refer_place, " &
                                               "reason_of_referral = @reason_of_referral, " &
                                               "temperature = @temperature, " &
                                               "blood_pressure = @blood_pressure, " &
                                               "weight = @weight, " &
                                               "height = @height " &
                                           "WHERE ID = @referralId"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    ' Set parameters for the update query
                    cmd.Parameters.AddWithValue("@referral_date", referral_date.Value)
                    cmd.Parameters.AddWithValue("@refer_place", refer_place.Text)
                    cmd.Parameters.AddWithValue("@reason_of_referral", reason.Text)
                    cmd.Parameters.AddWithValue("@temperature", temp.Text)

                    ' Combine systolic and diastolic values for blood pressure
                    Dim bloodPressure As String = $"{systolic.Text.Trim()}/{diastolic.Text.Trim()}"
                    cmd.Parameters.AddWithValue("@blood_pressure", bloodPressure)

                    cmd.Parameters.AddWithValue("@weight", weight.Text)
                    cmd.Parameters.AddWithValue("@height", height.Text)
                    cmd.Parameters.AddWithValue("@referralId", referralId)

                    ' Execute the update query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the update was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Referral data updated successfully.")
                    Else
                        MessageBox.Show("No records were updated.")
                    End If
                End Using

                Dim insertQuery As String = "INSERT INTO bzvhcims.referralsaverecord " &
                             "(patient_id, referral_date, refer_place, reason_of_referral) " &
                             "VALUES ( @patient_id, @referral_date, @refer_place, @reason_of_referral)"

                Using cmd As New MySqlCommand(insertQuery, conn)
                    ' Set parameters for the insert query
                    cmd.Parameters.AddWithValue("@referral_date", referral_date.Value)
                    cmd.Parameters.AddWithValue("@refer_place", refer_place.Text)
                    cmd.Parameters.AddWithValue("@reason_of_referral", reason.Text)
                    cmd.Parameters.AddWithValue("@patient_id", patientId) ' Assuming you have a patientId variable

                    ' Execute the insert query
                    cmd.ExecuteNonQuery()
                End Using



            Catch ex As Exception
                MessageBox.Show($"Error updating referral data: {ex.Message}")
            End Try
        End Using
    End Sub

End Class
