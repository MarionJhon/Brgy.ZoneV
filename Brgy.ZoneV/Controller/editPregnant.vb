Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports MySql.Data.MySqlClient

Public Class editPregnant
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim pregnantId As Integer
    Dim patientId As Integer

    Public Sub New(pregnantId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.pregnantId = pregnantId

        ' Load referral data based on the ID
        LoadReferralData()
    End Sub

    Private Sub LoadReferralData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch referral data based on the ID
                Dim selectQuery As String = "SELECT n.pregnant_id, n.date_lmp, p.fname, p.mname, p.lname, n.edd, n.date_of_visit, p.dob, n.patient_id" &
                                    " FROM bzvhcims.pregnant n " &
                                    " INNER JOIN bzvhcims.patient p ON n.patient_id = p.patient_id " &
                                    " WHERE n.pregnant_id = @pregnantId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@pregnantId", pregnantId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with referral data
                            patient.Text = reader("fname").ToString() & " " & reader("mname").ToString() & " " & reader("lname").ToString()
                            age.Text = CalculateAge(reader.GetDateTime("dob")).ToString()
                            dob.Value = Convert.ToDateTime(reader("dob"))
                            LMP.Value = Convert.ToDateTime(reader("date_lmp")) ' Assuming LMP is a DateTimePicker
                            EDD.Value = Convert.ToDateTime(reader("edd"))
                            dtVisit.Value = Convert.ToDateTime(reader("date_of_visit"))
                            patientId = Convert.ToInt32(reader("patient_id"))
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

                ' Update referral data based on the ID
                Dim updateQuery As String = "UPDATE bzvhcims.pregnant SET " &
                                            "date_lmp = @lmp, " &
                                            "edd = @edd, " &
                                            "date_of_visit = @dov " &
                                            "WHERE pregnant_id = @pregnantId"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@lmp", LMP.Value)
                    cmd.Parameters.AddWithValue("@edd", EDD.Value)
                    cmd.Parameters.AddWithValue("@dov", dtVisit.Value)
                    cmd.Parameters.AddWithValue("@pregnantId", pregnantId)

                    ' Execute the update query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Pregnant data updated successfully.")
                    Else
                        MessageBox.Show("No rows were updated. Please check the pregnant ID.")
                    End If
                End Using

                Dim pregnantSaveRecordQuery As String = "INSERT INTO bzvhcims.pregnantsaverecord (patient_id, date_of_visit, lmp, edd) VALUES (@value1, @value2, @value3, @value4)"
                Dim pregnanSaveRecordCmd As New MySqlCommand(pregnantSaveRecordQuery, conn)
                pregnanSaveRecordCmd.Parameters.AddWithValue("@value1", patientId)
                pregnanSaveRecordCmd.Parameters.AddWithValue("@value2", dtVisit.Value)
                pregnanSaveRecordCmd.Parameters.AddWithValue("@value3", LMP.Value)
                pregnanSaveRecordCmd.Parameters.AddWithValue("@value4", EDD.Value)

                ' Execute the bloodPressureSaveRecord query
                pregnanSaveRecordCmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error updating pregnant data: " & ex.Message)
            End Try
        End Using
    End Sub
End Class