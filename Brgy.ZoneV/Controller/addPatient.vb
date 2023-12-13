Imports MySql.Data.MySqlClient

Public Class addPatient
    Dim conn As New MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=bzvhcims;")
    Dim errorProvider As New ErrorProvider()

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            conn.Open()

            If String.IsNullOrWhiteSpace(fname.Text) Then
                ErrorProvider.SetError(fname, "First name is required.")
            Else
                ErrorProvider.SetError(fname, "") ' Clear error if valid
            End If

            If String.IsNullOrWhiteSpace(lname.Text) Then
                ErrorProvider.SetError(lname, "Last name is required.")
            Else
                ErrorProvider.SetError(lname, "") ' Clear error if valid
            End If

            If String.IsNullOrWhiteSpace(gender.SelectedItem) Then
                ErrorProvider.SetError(gender, "Gender is required.")
            Else
                ErrorProvider.SetError(gender, "") ' Clear error if valid
            End If

            If String.IsNullOrWhiteSpace(contact.Text) Then
                ErrorProvider.SetError(contact, "Contact is required.")
            Else
                ErrorProvider.SetError(contact, "") ' Clear error if valid
            End If

            If String.IsNullOrWhiteSpace(address.Text) Then
                ErrorProvider.SetError(address, "Address is required.")
            Else
                ErrorProvider.SetError(address, "") ' Clear error if valid
            End If

            ' Check if any errors are set
            If ErrorProvider.GetError(fname) <> "" OrElse
               ErrorProvider.GetError(lname) <> "" OrElse
               ErrorProvider.GetError(bod) <> "" OrElse
               ErrorProvider.GetError(contact) <> "" OrElse
               ErrorProvider.GetError(address) <> "" Then
                MessageBox.Show("Please fill in all required fields.")
                Return
            End If

            ' Check if the patient already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM bzvhcims.patient WHERE fname = @value1 AND mname = @value2 AND lname = @value3"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@value1", fname.Text)
            checkCmd.Parameters.AddWithValue("@value2", mname.Text)
            checkCmd.Parameters.AddWithValue("@value3", lname.Text)

            Dim existingPatientsCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If existingPatientsCount > 0 Then
                MessageBox.Show("Patient with the same information already exists.")
                Return
            End If

            ' If the patient does not exist, proceed with the insertion
            Dim query As String = "INSERT INTO bzvhcims.patient (fname, mname, lname, dob, gender, address, contact, add_date) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@value1", fname.Text)
            cmd.Parameters.AddWithValue("@value2", mname.Text)
            cmd.Parameters.AddWithValue("@value3", lname.Text)
            cmd.Parameters.AddWithValue("@value4", bod.Value.Date)
            cmd.Parameters.AddWithValue("@value5", gender.SelectedItem)
            cmd.Parameters.AddWithValue("@value6", address.Text)
            cmd.Parameters.AddWithValue("@value7", contact.Text)
            cmd.Parameters.AddWithValue("@value8", addDt.Value.Date)

            Dim rowAffected As Integer = cmd.ExecuteNonQuery()

            If rowAffected > 0 Then
                MessageBox.Show("Data inserted successfully!")
                ResetAutoIncrement()
            Else
                MessageBox.Show("Data insertion failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ResetAutoIncrement()
        Try
            Dim resetQuery As String = "ALTER TABLE patient AUTO_INCREMENT = 1"
            Dim resetCmd As New MySqlCommand(resetQuery, conn)
            resetCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error resetting auto-increment: " & ex.Message)
        End Try
    End Sub

    Private Sub bod_ValueChanged(sender As Object, e As EventArgs) Handles bod.ValueChanged
        ' Calculate and display age when the date of birth value changes
        CalculateAndDisplayAge()
    End Sub

    Private Sub CalculateAndDisplayAge()
        ' Calculate age based on the selected date of birth
        Dim dob As DateTime = bod.Value.Date
        Dim age As Integer = DateTime.Now.Year - dob.Year

        ' Adjust age if the birthday hasn't occurred yet this year
        If DateTime.Now < dob.AddYears(age) Then
            age -= 1
        End If

        ' Display the age in txtAge.Text
        txtAge.Text = age.ToString()
    End Sub

    Private Sub addPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bod.Value = DateTime.Today
        addDt.Value = DateTime.Today
    End Sub
End Class
