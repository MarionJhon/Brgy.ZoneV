Imports MySql.Data.MySqlClient

Public Class addStaff
    Dim conn As New MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=bzvhcims;")

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            conn.Open()

            ' Check if items are selected in both the gender and role ComboBoxes
            If gender.SelectedItem IsNot Nothing AndAlso role.SelectedItem IsNot Nothing Then
                ' Retrieve gender_id based on selected gender
                Dim selectedGender As String = gender.SelectedItem.ToString()
                Dim genderId As Integer = GetGenderId(selectedGender, conn)

                ' Retrieve role_id based on selected role
                Dim selectedRole As String = role.SelectedItem.ToString()
                Dim roleId As Integer = GetRoleId(selectedRole, conn)

                ' If either genderId or roleId is -1, there was an issue retrieving the respective id
                If genderId = -1 OrElse roleId = -1 Then
                    MessageBox.Show("Error retrieving gender or role information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Insert a new user
                Dim newUserId As Integer = InsertNewUser(username.Text, password.Text, conn)

                If newUserId <> -1 Then
                    ' Insert data into 'staff' table
                    Dim staffQuery As String = "INSERT INTO bzvhcims.staff (fname, mname, lname, dob, gender_id, role_id, user_id) " &
                               "VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @newUserId)"
                    Dim staffCmd As New MySqlCommand(staffQuery, conn)
                    staffCmd.Parameters.AddWithValue("@value1", fname.Text)
                    staffCmd.Parameters.AddWithValue("@value2", mname.Text)
                    staffCmd.Parameters.AddWithValue("@value3", lname.Text)
                    staffCmd.Parameters.AddWithValue("@value4", dob.Value)
                    staffCmd.Parameters.AddWithValue("@value5", genderId)
                    staffCmd.Parameters.AddWithValue("@value6", roleId)
                    staffCmd.Parameters.AddWithValue("@newUserId", newUserId)

                    Dim staffRowAffected As Integer = staffCmd.ExecuteNonQuery()

                    If staffRowAffected > 0 Then
                        MessageBox.Show("Data inserted successfully!")
                    Else
                        MessageBox.Show("Data insertion failed.")
                    End If
                Else
                    MessageBox.Show("Error inserting new user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please select both gender and role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function InsertNewUser(username As String, password As String, conn As MySqlConnection) As Integer
        Try
            ' Insert data into 'users' table
            Dim userQuery As String = "INSERT INTO bzvhcims.users (username, password) VALUES (@username, @password)"
            Dim userCmd As New MySqlCommand(userQuery, conn)
            userCmd.Parameters.AddWithValue("@username", username)
            userCmd.Parameters.AddWithValue("@password", password)

            ' Execute the query
            userCmd.ExecuteNonQuery()

            ' Retrieve the generated user_id
            Dim getUserIdQuery As String = "SELECT LAST_INSERT_ID()" 'retrieve the automatically generated ID For the last insert
            Dim getUserIdCmd As New MySqlCommand(getUserIdQuery, conn)
            Dim result As Object = getUserIdCmd.ExecuteScalar()

            If result IsNot Nothing Then
                Return Convert.ToInt32(result)
            Else
                Return -1
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting new user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function



    ' Method to get gender_id based on gender_name
    Private Function GetGenderId(genderName As String, connection As MySqlConnection) As Integer
        Try
            ' Query the gender_id based on gender_name
            Dim query As String = "SELECT gender_id FROM bzvhcims.gender WHERE gender_name = @genderName"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@genderName", genderName)

                Dim result As Object = cmd.ExecuteScalar()

                ' Check if the result is not DBNull and convert it to an Integer
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                Else
                    ' Handle the case where genderid is not found
                    MessageBox.Show("Gender not found for the specified name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            ' Handle any other exceptions
            MessageBox.Show("Error retrieving gender_id: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Return a default value if the retrieval fails
        Return -1
    End Function

    Private Function GetRoleId(roleName As String, connection As MySqlConnection) As Integer
        Try
            ' Query the role_id based on role_name
            Dim query As String = "SELECT role_id FROM bzvhcims.role WHERE role_name = @roleName"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@roleName", roleName)

                Dim result As Object = cmd.ExecuteScalar()

                ' Check if the result is not DBNull and convert it to an Integer
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                Else
                    ' Handle the case where role_id is not found
                    MessageBox.Show("Role not found for the specified name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            ' Handle any other exceptions
            MessageBox.Show("Error retrieving role_id: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Return a default value if the retrieval fails
        Return -1
    End Function


    ' Method to load gender names into ComboBox
    Private Sub LoadGenderComboBox()
        Try
            ' Open the connection only when needed
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Query to retrieve gender names from the 'gender' table
            Dim query As String = "SELECT gender_name FROM bzvhcims.gender"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Clear existing items in the ComboBox
                    gender.Items.Clear()

                    ' Load gender names into the ComboBox
                    While reader.Read()
                        gender.Items.Add(reader("gender_name").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading gender names: " & ex.Message)
        Finally
            ' Close the connection if it was opened
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub LoadRoleComboBox()
        Try
            ' Open the connection only when needed
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Query to retrieve role names from the 'role' table
            Dim query As String = "SELECT role_name FROM bzvhcims.role"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Clear existing items in the ComboBox
                    role.Items.Clear()

                    ' Load role names into the ComboBox
                    While reader.Read()
                        role.Items.Add(reader("role_name").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading role names: " & ex.Message)
        Finally
            ' Close the connection if it was opened
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Call the method to load gender names when the form loads
    Private Sub addStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGenderComboBox()
        LoadRoleComboBox()
        dob.Value = DateTime.Today
    End Sub
End Class
