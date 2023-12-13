Imports MySql.Data.MySqlClient

Public Class Patient
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"

    ' Private field to store the patient ID
    Private _patientId As Integer

    ' Public property to get or set the patient ID
    Public Property PatientId As Integer
        Get
            Return _patientId
        End Get
        Set(value As Integer)
            _patientId = value
        End Set
    End Property

    Private Sub LoadDataIntoDataGridView(searchText As String)
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation and search condition
                Dim selectQuery As String = $"SELECT patient_id, CONCAT(fname, ' ', mname, ' ', lname) AS Fullname, dob, gender, TIMESTAMPDIFF(YEAR, patient.dob, CURDATE()) AS Age, contact FROM bzvhcims.patient
                                          WHERE CONCAT(patient_id, ' ',fname, ' ', mname, ' ', lname, ' ', dob, ' ', gender,' ', contact) LIKE @searchText"
                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchText", $"%{searchText}%")
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    PatientDataGridView1.DataSource = dataTable

                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New addPatient
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        tranparentBG.ShowForm(frm)

        ' Refresh the DataGridView after adding a new record
        LoadDataIntoDataGridView(txtSearch.Text)
    End Sub

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView(txtSearch.Text)
    End Sub

    Private Sub PatientDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDataGridView1.CellContentClick
        ' Check if the clicked cell is not a header cell and a valid row is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the patient_id from the selected row
            Dim patientId As Integer = Convert.ToInt32(PatientDataGridView1.Rows(e.RowIndex).Cells("ID").Value)
            ' Assuming patient_id is the first column in the DataGridView, change the index accordingly if it's in a different position.

            ' Open the edit form with the selected patient_id
            Dim frm As New editPatient(patientId) ' Assuming editPatient form takes patient_id as a parameter
            frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
            tranparentBG.ShowForm(frm)

            LoadDataIntoDataGridView(txtSearch.Text)
        End If
    End Sub


    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Update the DataGridView based on the search text
        LoadDataIntoDataGridView(txtSearch.Text)
    End Sub
End Class
