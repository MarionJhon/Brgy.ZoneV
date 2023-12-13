Imports MySql.Data.MySqlClient

Public Class Staff
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"

    Private Sub LoadDataIntoDataGridView(searchText As String)
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation and search condition for staff
                Dim selectQuery As String = "SELECT staff.staff_id, CONCAT(staff.fname, ' ', staff.mname, ' ', staff.lname) AS Fullname, staff.dob, gender.gender_name, TIMESTAMPDIFF(YEAR, staff.dob, CURDATE()) AS Age, role.role_name
                            FROM bzvhcims.staff
                            INNER JOIN bzvhcims.gender ON staff.gender_id = gender.gender_id
                            INNER JOIN bzvhcims.role ON staff.role_id = role.role_id
                            WHERE CONCAT(staff.staff_id, ' ', staff.fname, ' ', staff.mname, ' ', staff.lname, staff.dob, gender.gender_name, role.role_name) LIKE @searchText"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    StaffDataGridView.DataSource = dataTable
                End Using

            Catch ex As Exception
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New addStaff
        frm.StartPosition = FormStartPosition.CenterScreen
        tranparentBG.ShowForm(frm)

        ' Refresh the DataGridView after adding a new record
        LoadDataIntoDataGridView(txtSearch.Text)
    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView(txtSearch.Text)
    End Sub

    Private Sub StaffDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffDataGridView.CellContentClick
        ' Check if the clicked cell is not a header cell and a valid row is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the staff_id from the selected row
            Dim staffId As Integer = Convert.ToInt32(StaffDataGridView.Rows(e.RowIndex).Cells("id").Value)

            ' Open the edit form with the selected staff_id
            Dim frm As New editStaff(staffId) ' Assuming EditStaff form takes staff_id as a parameter
            frm.StartPosition = FormStartPosition.CenterScreen
            tranparentBG.ShowForm(frm)

            LoadDataIntoDataGridView(txtSearch.Text)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Update the DataGridView based on the search text
        LoadDataIntoDataGridView(txtSearch.Text)
    End Sub
End Class
