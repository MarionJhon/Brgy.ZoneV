Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class editPatient
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim patientId As Integer

    ' Constructor that accepts the patient ID
    Public Sub New(patientId As Integer)
        InitializeComponent()

        ' Assign the received patient ID to the class-level variable
        Me.patientId = patientId

        ' Load patient data based on the ID
        LoadPatientData(patientId)
    End Sub

    Private Sub LoadPatientData(patientId As Integer)
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Fetch patient data based on the ID
                Dim selectQuery As String = "SELECT * FROM bzvhcims.patient WHERE patient_id = @patientId"
                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@patientId", patientId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the form controls with patient data
                            fname.Text = reader("fname").ToString()
                            mname.Text = reader("mname").ToString()
                            lname.Text = reader("lname").ToString()

                            ' Corrected the assignment for the date of birth
                            bod.Value = reader.GetDateTime("dob")

                            ' Calculate age using the CalculateAge function
                            age.Text = CalculateAge(reader.GetDateTime("dob")).ToString()

                            gender.Text = reader("gender").ToString()
                            address.Text = reader("address").ToString()
                            contact.Text = reader("contact").ToString()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading patient data: " & ex.Message)
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


    Private Sub closeBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' Update patient data in the database
                Dim updateQuery As String = "UPDATE bzvhcims.patient SET fname = @fname, mname = @mname, lname = @lname, dob = @dob, gender = @gender, address = @address, contact = @contact WHERE patient_id = @patientId"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    ' Set parameters with the updated values
                    cmd.Parameters.AddWithValue("@fname", fname.Text)
                    cmd.Parameters.AddWithValue("@mname", mname.Text)
                    cmd.Parameters.AddWithValue("@lname", lname.Text)
                    cmd.Parameters.AddWithValue("@dob", bod.Value)
                    cmd.Parameters.AddWithValue("@gender", gender.Text)
                    cmd.Parameters.AddWithValue("@address", address.Text)
                    cmd.Parameters.AddWithValue("@contact", contact.Text)
                    cmd.Parameters.AddWithValue("@patientId", patientId)

                    ' Execute the update query
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Patient data updated successfully.")
                End Using

            Catch ex As Exception
                MessageBox.Show("Error updating patient data: " & ex.Message)
            End Try
        End Using
    End Sub

End Class
