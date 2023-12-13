Imports MySql.Data.MySqlClient

Public Class bloodPressureView

    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"

    Private _patientId As Integer


    Public Sub New(fullName As String, patientId As Integer)
        ' This is the constructor of the form, which will be called when creating a new instance.
        InitializeComponent()

        _patientId = patientId
        txtPatient.Text = fullName

        ' Call the method to load data based on the referralId
        LoadData()
    End Sub

    ' Create a method to load data into the DataGridView
    Private Sub LoadData()
        Dim query As String = "SELECT patient_id, blood_date, blood_reading, pulse,
                              ROW_NUMBER() OVER (PARTITION BY patient_id ORDER BY blood_id) AS ID
                       FROM blood_pressuresaverecord 
                       WHERE patient_id = @patientId 
                       ORDER BY blood_id ASC"



        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@patientId", _patientId)


                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()

                    adapter.Fill(dataTable)

                    ' Set the DataSource to the DefaultView of the DataTable
                    bloodDatagrid.DataSource = dataTable.DefaultView
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading data: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub bloodDt_ValueChanged(sender As Object, e As EventArgs) Handles bloodDt.ValueChanged
        Dim selectedDate As DateTime = bloodDt.Value

        ' Extract month and year from the selected date
        Dim selectedMonth As Integer = selectedDate.Month
        Dim selectedYear As Integer = selectedDate.Year

        ' Construct the SQL query with parameters for month and year
        Dim query As String = "SELECT patient_id, blood_date, blood_reading, pulse, ROW_NUMBER() OVER (ORDER BY blood_id) AS ID " &
                             "FROM blood_pressuresaverecord " &
                             "WHERE MONTH(blood_date) = @selectedMonth AND YEAR(blood_date) = @selectedYear AND patient_id = @patient"

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters for the selected month and year
                    cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth)
                    cmd.Parameters.AddWithValue("@selectedYear", selectedYear)
                    cmd.Parameters.AddWithValue("@patient", _patientId)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()

                    adapter.Fill(dataTable)

                    ' Set the DataSource to the DefaultView of the DataTable
                    bloodDatagrid.DataSource = dataTable.DefaultView
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error loading data: {ex.Message}")
            End Try
        End Using
    End Sub
End Class
