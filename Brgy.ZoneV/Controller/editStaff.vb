Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class EditStaff
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim staffId As Integer

    Public Sub New(staffId As Integer)
        InitializeComponent()
        Me.staffId = staffId
        LoadStaffData()
    End Sub

    Private Sub LoadStaffData()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim selectQuery As String = "SELECT s.*, g.gender_name, r.role_name, u.username " &
                                        "FROM bzvhcims.staff s " &
                                        "INNER JOIN bzvhcims.gender g ON s.gender_id = g.gender_id " &
                                        "INNER JOIN bzvhcims.role r ON s.role_id = r.role_id " &
                                        "INNER JOIN bzvhcims.users u ON s.user_id = u.user_id " &
                                        "WHERE s.staff_id = @staffId"
                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@staffId", staffId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            fname.Text = reader("fname").ToString()
                            mname.Text = reader("mname").ToString()
                            lname.Text = reader("lname").ToString()
                            dob.Value = Convert.ToDateTime(reader("dob"))
                            ' Load gender data into the dropdown
                            LoadGenderData()
                            ' Set the selected gender based on the retrieved value
                            gender.SelectedValue = Convert.ToInt32(reader("gender_id"))
                            ' Load role data into the dropdown
                            LoadRoleData()
                            ' Set the selected role based on the retrieved value
                            role.SelectedValue = Convert.ToInt32(reader("role_id"))
                            username.Text = reader("username").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading staff data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub LoadRoleData()
        ' Assuming you have a role dropdown named 'role'
        Dim roleQuery As String = "SELECT * FROM bzvhcims.role"
        Dim roleDataAdapter As New MySqlDataAdapter(roleQuery, connString)
        Dim roleDataTable As New DataTable()

        roleDataAdapter.Fill(roleDataTable)

        ' Bind the role data to the dropdown
        role.DataSource = roleDataTable
        role.DisplayMember = "role_name"
        role.ValueMember = "role_id"
    End Sub


    Private Sub LoadGenderData()
        ' Assuming you have a gender dropdown named 'gender'
        Dim genderQuery As String = "SELECT * FROM bzvhcims.gender"
        Dim genderDataAdapter As New MySqlDataAdapter(genderQuery, connString)
        Dim genderDataTable As New DataTable()

        genderDataAdapter.Fill(genderDataTable)

        ' Bind the gender data to the dropdown
        gender.DataSource = genderDataTable
        gender.DisplayMember = "gender_name"
        gender.ValueMember = "gender_id"
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Update staff information
                Dim updateStaffQuery As String = "UPDATE bzvhcims.staff SET fname = @fname, mname = @mname, lname = @lname, dob = @dob, gender_id = @genderId WHERE staff_id = @staffId"

                Using cmdUpdateStaff As New MySqlCommand(updateStaffQuery, conn)
                    cmdUpdateStaff.Parameters.AddWithValue("@fname", fname.Text)
                    cmdUpdateStaff.Parameters.AddWithValue("@mname", mname.Text)
                    cmdUpdateStaff.Parameters.AddWithValue("@lname", lname.Text)
                    cmdUpdateStaff.Parameters.AddWithValue("@dob", dob.Value)
                    cmdUpdateStaff.Parameters.AddWithValue("@genderId", Convert.ToInt32(gender.SelectedValue)) ' Assuming gender.SelectedValue contains the selected gender_id
                    cmdUpdateStaff.Parameters.AddWithValue("@staffId", staffId)
                    cmdUpdateStaff.ExecuteNonQuery()
                End Using

                ' Update username and password in the users table
                Dim updateUsersQuery As String = "UPDATE bzvhcims.users SET username = @username, password = @password WHERE user_id = (SELECT user_id FROM bzvhcims.staff WHERE staff_id = @staffId)"

                Using cmdUpdateUsers As New MySqlCommand(updateUsersQuery, conn)
                    cmdUpdateUsers.Parameters.AddWithValue("@username", username.Text)
                    cmdUpdateUsers.Parameters.AddWithValue("@password", password.Text)
                    cmdUpdateUsers.Parameters.AddWithValue("@staffId", staffId)
                    cmdUpdateUsers.ExecuteNonQuery()
                End Using

                MessageBox.Show("Staff data updated successfully.")
            End Using
        Catch sqlEx As MySqlException
            MessageBox.Show("MySQL Error updating staff data: " & sqlEx.Message)
        Catch ex As Exception
            MessageBox.Show("Error updating staff data: " & ex.Message)
        End Try
    End Sub


End Class
