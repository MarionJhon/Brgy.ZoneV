Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports MySql.Data.MySqlClient

Public Class editImmunization
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim immuneId As Integer
    Dim patientId As Integer

    Public Sub New(immuneId As Integer)
        InitializeComponent()

        ' Assign the received referral ID to the class-level variable
        Me.immuneId = immuneId

        ' Load referral data based on the ID
        LoadReferralData()
    End Sub

    Private Sub LoadReferralData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch immunization data based on the ID
                Dim selectQuery As String = "SELECT b.babys_name, b.gender, i.date_of_vaccination, i.vaccine_type, b.date_of_delivery, CONCAT(p.fname,' ', p.mname,' ', p.lname ) AS parents_name " &
                                        "FROM bzvhcims.immunization i " &
                                        "INNER JOIN bzvhcims.birthingsaverecord b ON i.birthing_id = b.birthing_save_record_id " &
                                        "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                                        "WHERE i.immunization_id = @immunizationId"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@immunizationId", immuneId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with immunization, birthingsaverecord, and patient data
                            childTxt.Text = reader("babys_name").ToString()
                            gender.Text = reader("gender").ToString()

                            ' Calculate age
                            Dim birthDate As DateTime = Convert.ToDateTime(reader("date_of_delivery"))
                            Dim ageInYears As Integer = DateTime.Today.Year - birthDate.Year

                            ' Display age in the age textbox
                            age.Text = ageInYears.ToString()

                            dob.Value = Convert.ToDateTime(reader("date_of_delivery"))
                            prtTxt.Text = reader("parents_name").ToString()

                            vaxTyp.SelectedItem = reader("vaccine_type").ToString()
                            dtVax.Value = Convert.ToDateTime(reader("date_of_vaccination"))
                        Else
                            MessageBox.Show("No immunization data found for the provided ID.")
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading immunization data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Update referral data based on the ID
                Dim updateQuery As String = "UPDATE bzvhcims.immunization SET " &
                                            "date_of_vaccination = @dov, " &
                                            "vaccine_type = @vt " &
                                            "WHERE 	immunization_id  = @immuneId"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@dov", dtVax.Value)
                    cmd.Parameters.AddWithValue("@vt", vaxTyp.SelectedItem)
                    cmd.Parameters.AddWithValue("@immuneId", immuneId)

                    ' Execute the update query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Immunization data updated successfully.")
                    Else
                        MessageBox.Show("No rows were updated. Please check the immunization ID.")
                    End If
                End Using

                Dim selectBirthingIdQuery As String = "SELECT birthing_id FROM bzvhcims.immunization WHERE immunization_id = @immuneId"

                Using cmdSelectBirthingId As New MySqlCommand(selectBirthingIdQuery, conn)
                    cmdSelectBirthingId.Parameters.AddWithValue("@immuneId", immuneId)

                    Dim birthingId As Integer = Convert.ToInt32(cmdSelectBirthingId.ExecuteScalar())

                    ' Insert into immunizationsaverecord
                    Dim immunizationSaveRecordQuery As String = "INSERT INTO bzvhcims.immunizationsaverecord (birthing_id, date_of_vaccination, vaccine_type) VALUES (@birthingId, @value2, @value3)"
                    Dim immunizationSaveRecordCmd As New MySqlCommand(immunizationSaveRecordQuery, conn)
                    immunizationSaveRecordCmd.Parameters.AddWithValue("@birthingId", birthingId)
                    immunizationSaveRecordCmd.Parameters.AddWithValue("@value2", dtVax.Value)
                    immunizationSaveRecordCmd.Parameters.AddWithValue("@value3", vaxTyp.Text)

                    ' Execute the immunizationsaverecord insertion query
                    immunizationSaveRecordCmd.ExecuteNonQuery()
                End Using


            Catch ex As Exception
                MessageBox.Show("Error updating immunization data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dob_ValueChanged(sender As Object, e As EventArgs) Handles dob.ValueChanged

    End Sub
End Class