Imports MySql.Data.MySqlClient

Public Class weighingChildrenView
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Private birthingId As Integer

    Public Sub New(babysName As String, birthingId As Integer)
        ' This is the constructor of the form, which will be called when creating a new instance.
        InitializeComponent()

        Me.birthingId = birthingId ' Use Me keyword to refer to the class-level variable
        txtPatient.Text = babysName

        ' Call the method to load data based on the weighingId
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT birthing_id, weight, weight_date,
            ROW_NUMBER() OVER (PARTITION BY birthing_id ORDER BY weighing_save_record_id) AS weighing_id
            FROM weighingsaverecord WHERE birthing_id = @weighingId 
            ORDER BY weighing_save_record_id ASC"

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@weighingId", Me.birthingId) ' Use Me keyword to refer to the class-level variable

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()

                    adapter.Fill(dataTable)

                    ' Set the DataSource to the DefaultView of the DataTable
                    weighingDataGridView.DataSource = dataTable.DefaultView
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading data: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub weighingDt_ValueChanged(sender As Object, e As EventArgs) Handles weighingDt.ValueChanged
        Dim selectedDate As DateTime = weighingDt.Value

        ' Extract month and year from the selected date
        Dim selectedMonth As Integer = selectedDate.Month
        Dim selectedYear As Integer = selectedDate.Year

        ' Construct the SQL query with parameters for month and year
        Dim query As String = "SELECT birthing_id, weight, weight_date, ROW_NUMBER() OVER (ORDER BY weighing_save_record_id) AS weighing_id " &
                             "FROM weighingsaverecord " &
                             "WHERE MONTH(weight_date) = @selectedMonth AND YEAR(weight_date) = @selectedYear AND birthing_id  = @birth"

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters for the selected month and year
                    cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth)
                    cmd.Parameters.AddWithValue("@selectedYear", selectedYear)
                    cmd.Parameters.AddWithValue("@birth", birthingId)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()

                    adapter.Fill(dataTable)

                    ' Set the DataSource to the DefaultView of the DataTable
                    weighingDataGridView.DataSource = dataTable.DefaultView
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading data: {ex.Message}")
            End Try
        End Using
    End Sub
End Class
