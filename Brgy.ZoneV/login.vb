Imports System.Windows.Controls
Imports MySql.Data.MySqlClient

Public Class login
    Dim conn As New MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=bzvhcims;")

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM users WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim username As String = reader("username").ToString()
                MessageBox.Show("Login Successful!")

                Dim home As New home(username)
                home.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username and password.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtPassword_IconRightClick(sender As Object, e As EventArgs) Handles txtPassword.IconRightClick
        ' Toggle the PasswordChar property to show/hide the password
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            ' Change the icon to the hide icon
            txtPassword.IconRight = My.Resources.icons8_view_24 ' Replace with the hide icon
        Else
            txtPassword.PasswordChar = "*"
            ' Change the icon to the show icon
            txtPassword.IconRight = My.Resources.icons8_hide_password_24 ' Replace with the show icon
        End If
    End Sub
End Class
