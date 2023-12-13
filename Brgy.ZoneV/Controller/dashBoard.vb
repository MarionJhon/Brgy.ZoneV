Imports MySql.Data.MySqlClient
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Imports System.Globalization
Imports Guna.Charts.WinForms
Imports Mysqlx
Imports Guna.Charts.Interfaces

Public Class dashBoard
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"

    Private Sub dashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalPatients()
        totalStaff()
        totalChildren()
        LoadDataIntoDataGridView()
        Using connection As New MySqlConnection(connString)
            connection.Open()


            ' Specify services and corresponding date columns
            Dim serviceDateColumns As New Dictionary(Of String, String) From {
            {"immunization", "date_of_vaccination"},
            {"referral", "referral_date"},
            {"blood_pressure", "blood_date"},
            {"birthing", "date_of_delivery"},
            {"pregnant", "date_of_visit"},
            {"weighing", "weighing_date"}
        }

            ' Fetch data for each service
            Dim data As New Dictionary(Of String, Dictionary(Of Integer, Integer))
            For Each kvp As KeyValuePair(Of String, String) In serviceDateColumns
                Dim service As String = kvp.Key
                Dim dateColumn As String = kvp.Value

                Dim monthlyData As New Dictionary(Of Integer, Integer)

                ' Fetch total records by month for each service
                Dim query As String = $"SELECT MONTH({dateColumn}) AS Month, COUNT(*) AS Count FROM {service} GROUP BY MONTH({dateColumn})"
                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim month As Integer = reader.GetInt32("Month")
                            Dim count As Integer = reader.GetInt32("Count")
                            monthlyData.Add(month, count)
                        End While
                    End Using
                End Using

                data.Add(service, monthlyData)
            Next

            ' Populate the Cartesian chart
            ' PopulateChart(data)
        End Using
    End Sub


    Sub childForm(ByVal panel As Form)
        ' Clear any existing forms in the main panel
        mainPanel.Controls.Clear()

        ' Set the parent form before showing
        panel.TopLevel = False
        panel.Parent = mainPanel
        panel.Dock = DockStyle.Fill
        panel.BringToFront()
        panel.Show()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        ' Use Using statement for automatic resource disposal
        Using conn As New MySqlConnection(connString)
            ' Declare a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Fetch data from the database with full name concatenation and search condition
                Dim selectQuery As String = $"SELECT patient_id, CONCAT(fname, ' ', mname, ' ', lname) AS Fullname FROM bzvhcims.patient WHERE DATE(add_date) = CURDATE()"
                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    patient.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub totalPatients()
        Try
            Using connection As New MySqlConnection(connString)
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand to execute the SQL query
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM patient", connection)
                    ' Execute the query and get the result
                    Dim totalPatients As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Display the result in a TextBox named totalsPatient
                    totalPatient.Text = totalPatients.ToString()
                End Using

                ' Get the current month and year
                Dim currentMonth As Integer = DateTime.Now.Month
                Dim currentYear As Integer = DateTime.Now.Year

                ' Your SQL query with parameters for month and year
                Dim query As String = "SELECT COUNT(*) FROM patient WHERE MONTH(add_date) = @month AND YEAR(add_date) = @year"

                Using newcmd As New MySqlCommand(query, connection)
                    ' Add parameters for month and year
                    newcmd.Parameters.AddWithValue("@month", currentMonth)
                    newcmd.Parameters.AddWithValue("@year", currentYear)

                    ' Execute the query and get the result
                    Dim totalPatients As Integer = Convert.ToInt32(newcmd.ExecuteScalar())

                    ' Display the result in a TextBox named totalPatient
                    newPatient.Text = totalPatients.ToString() & " Total New Patient"
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during the database operation
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LoadDataIntoDataGridView()

    End Sub

    Private Sub totalChildren()
        Try
            Using connection As New MySqlConnection(connString)
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand to execute the SQL query
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM birthing", connection)
                    ' Execute the query and get the result
                    Dim totalPatients As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Display the result in a TextBox named totalsPatient
                    totalChild.Text = totalPatients.ToString()
                End Using

                ' Get the current month and year
                Dim currentMonth As Integer = DateTime.Now.Month
                Dim currentYear As Integer = DateTime.Now.Year

                ' Your SQL query with parameters for month and year
                Dim query As String = "SELECT COUNT(*) FROM birthing WHERE MONTH(date_of_delivery) = @month AND YEAR(date_of_delivery) = @year"

                Using newcmd As New MySqlCommand(query, connection)
                    ' Add parameters for month and year
                    newcmd.Parameters.AddWithValue("@month", currentMonth)
                    newcmd.Parameters.AddWithValue("@year", currentYear)

                    ' Execute the query and get the result
                    Dim totalPatients As Integer = Convert.ToInt32(newcmd.ExecuteScalar())

                    ' Display the result in a TextBox named totalPatient
                    newBorn.Text = totalPatients.ToString() & " Total New Born"
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during the database operation
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub totalStaff()
        Try
            Using connection As New MySqlConnection(connString)
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand to execute the SQL query
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM staff", connection)
                    ' Execute the query and get the result
                    Dim totalPatients As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Display the result in a TextBox named totalsPatient
                    totalStaf.Text = totalPatients.ToString()
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during the database operation
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowPatientForm(patientId As Integer)
        ' Create an instance of the Patient form
        Dim patientForm As New Patient()

        ' Set the patientId or perform any other initialization if needed
        patientForm.PatientId = patientId ' Assuming PatientId is a property in your Patient form

        ' Show the Patient form
        childForm(patientForm)
    End Sub

    Private Sub patient_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles patient.CellContentDoubleClick
        ' Check if a valid row is clicked
        If e.RowIndex >= 0 AndAlso e.RowIndex < patient.Rows.Count Then
            ' Get the patient information from the selected row
            Dim patientId As Integer = CInt(patient.Rows(e.RowIndex).Cells("patient_id").Value)

            ' Show the Patient form with the selected patientId
            ShowPatientForm(patientId)
        End If
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim frm As New addPatient
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
        tranparentBG.ShowForm(frm)
        LoadDataIntoDataGridView()
    End Sub

End Class