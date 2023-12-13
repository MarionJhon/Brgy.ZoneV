Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class report
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"


    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub selectServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectServices.SelectedIndexChanged
        ' Check if there is a selected item
        If selectServices.SelectedItem IsNot Nothing Then
            ' Get the selected service
            Dim selectedService As String = selectServices.SelectedItem.ToString()

            ' Get the search keyword from the search box
            Dim searchKeyword As String = searchReport.Text.Trim()

            ' Perform actions based on the selected service
            Select Case selectedService
                Case "Referral"
                    getReferral(searchKeyword)
                Case "Blood Pressure"
                    getBloodPressure(searchKeyword)
                Case "Pregnant Progress"
                    getPregnantProgress(searchKeyword)
                Case "Birthing"
                    getBirthing(searchKeyword)
                Case "Weighing Children"
                    getWeighingChildren(searchKeyword)
                Case "Immunization"
                    getImmunization(searchKeyword)
            End Select
        End If
    End Sub

    Private Sub getReferral(searchKeyword As String)
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Add a WHERE clause to filter the results based on the search criteria
                Dim selectQuery As String = "SELECT r.ID, CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS Fullname, " &
                                "p.gender AS Gender, " &
                                "TIMESTAMPDIFF(YEAR, p.dob, CURDATE()) AS Age, " &
                                "r.temperature AS Temperature, " &
                                "r.blood_pressure AS 'Blood Pressure', " &
                                "r.weight AS Weight, " &
                                "r.height AS Height, " &
                                "r.referral_date AS 'Referral Date', " &
                                "r.reason_of_referral AS 'Reason of Referral' " &
                                "FROM bzvhcims.referral r " &
                                "INNER JOIN bzvhcims.patient p ON r.patient_id = p.patient_id " &
                                "WHERE CONCAT(p.fname, ' ', p.mname, ' ', p.lname) LIKE @searchKeyword " &
                                "ORDER BY r.ID ASC"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    ' Use Parameters.AddWithValue to add parameters safely
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & searchReport.Text.Trim() & "%")

                    ' Fill the DataTable with data from the database
                    adapter.Fill(dataTable)

                    ' Assign the DataTable to the DataGridView
                    reportDatagrid.DataSource = dataTable

                    ' Set alignment and AutoSizeMode for each column
                    For Each column As DataGridViewColumn In reportDatagrid.Columns
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    Next
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub getBloodPressure(searchKeyword As String)
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Add a WHERE clause to filter the results based on the search criteria
                Dim selectQuery As String = "SELECT b.blood_id AS ID, CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS Fullname, " &
                                    "b.blood_date AS 'Blood Date', " &
                                    "b.blood_reading AS 'Blood Reading', " &
                                    "b.pulse AS Pulse " &
                                    "FROM bzvhcims.blood_pressure b " &
                                    "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                                    "WHERE CONCAT(p.fname, ' ', p.mname, ' ', p.lname) LIKE @searchKeyword " &
                                    "ORDER BY b.blood_id ASC"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & searchKeyword & "%")
                    adapter.Fill(dataTable)

                    ' Assign the DataTable to the DataGridView
                    reportDatagrid.DataSource = dataTable
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub getPregnantProgress(searchKeyword As String)
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Use parameterized query to prevent SQL injection
                Dim selectQuery As String = "SELECT pp.pregnant_id AS ID, CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS Fullname, " &
                                "pp.date_lmp AS 'Date of Last Menstrual Period (LMP)', " &
                                "pp.edd AS 'Estimated Due Date (EDD)', " &
                                "pp.date_of_visit AS 'Date of Visit' " &
                                "FROM bzvhcims.pregnant pp " &
                                "INNER JOIN bzvhcims.patient p ON pp.patient_id = p.patient_id " &
                                "WHERE CONCAT(p.fname, ' ', p.mname, ' ', p.lname) LIKE @searchKeyword " &
                                "ORDER BY pp.pregnant_id ASC"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    ' Use Parameters.AddWithValue to add parameters safely
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & searchKeyword & "%")

                    adapter.Fill(dataTable)

                    reportDatagrid.DataSource = dataTable

                    For Each column As DataGridViewColumn In reportDatagrid.Columns
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                        ' Set AutoSizeMode for specific columns based on their names
                        If column.Name = "Date of Last Menstrual Period (LMP)" OrElse column.Name = "Estimated Due Date (EDD)" Then
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                        Else
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                        End If
                    Next

                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub getBirthing(searchKeyword As String)
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Add a WHERE clause to filter the results based on the search criteria
                Dim selectQuery As String = "SELECT b.birthing_id AS ID, CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS 'Mother''s Name', " &
                            "b.babys_name AS 'Baby''s Name', " &
                            "b.gender AS Gender, " &
                            "b.birth_weight AS 'Birth Weight', " &
                            "b.type_of_delivery AS 'Type of Delivery', " &
                            "b.date_of_delivery AS 'Date of Delivery', " &
                            "b.time_of_delivery AS 'Time of Delivery', " &
                            "b.attending_healthworker_midwife AS 'Health Worker Midwife' " &
                            "FROM bzvhcims.birthing b " &
                            "INNER JOIN bzvhcims.patient p ON b.patient_id = p.patient_id " &
                            "WHERE CONCAT(p.fname, ' ', p.mname, ' ', p.lname) LIKE @searchKeyword " &
                            "ORDER BY b.birthing_id ASC"



                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & searchKeyword & "%")
                    adapter.Fill(dataTable)

                    ' Assign the DataTable to the DataGridView
                    reportDatagrid.DataSource = dataTable

                    For Each column As DataGridViewColumn In reportDatagrid.Columns
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    Next
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub getWeighingChildren(searchKeyword As String)
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Use aliases for table names to improve readability
                Dim selectQuery As String = "SELECT w.weighing_id AS ID, b.babys_name AS 'Child Name', b.gender AS Gender, w.weight AS Weight, w.weighing_date AS 'Weighing Date' FROM bzvhcims.weighing w " &
                            "INNER JOIN bzvhcims.birthingsaverecord b ON w.birthing_id = b.birthing_save_record_id " &
                            "WHERE b.babys_name LIKE @searchKeyword " &
                            "ORDER BY w.weighing_id ASC"


                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    ' Use the actual parameter name in the query
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & searchKeyword & "%")
                    adapter.Fill(dataTable)

                    ' Assign the DataTable to the DataGridView
                    reportDatagrid.DataSource = dataTable
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub getImmunization(searchKeyword As String)
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Use aliases for table names to improve readability
                Dim selectQuery As String = "SELECT i.immunization_id AS ID, b.babys_name AS 'Child Name', b.gender AS Gender, i.date_of_vaccination AS 'Date of Vaccination', i.vaccine_type AS 'Vaccine Type' FROM bzvhcims.immunization i " &
                "INNER JOIN bzvhcims.birthingsaverecord b ON i.birthing_id = b.birthing_save_record_id " &
                "WHERE b.babys_name LIKE @searchKeyword " &
                "ORDER BY i.immunization_id ASC"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    ' Use the actual parameter name in the query
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & searchKeyword & "%")
                    adapter.Fill(dataTable)

                    ' Assign the DataTable to the DataGridView
                    reportDatagrid.DataSource = dataTable
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub searchReport_TextChanged(sender As Object, e As EventArgs) Handles searchReport.TextChanged
        ' Check if there is a selected item
        If selectServices.SelectedItem IsNot Nothing Then
            ' Get the selected service
            Dim selectedService As String = selectServices.SelectedItem.ToString()

            ' Get the search keyword from the search box
            Dim searchKeyword As String = searchReport.Text.Trim()

            ' Perform actions based on the selected service
            Select Case selectedService
                Case "Referral"
                    getReferral(searchKeyword)
                Case "Blood Pressure"
                    getBloodPressure(searchKeyword)
                Case "Pregnant Progress"
                    getPregnantProgress(searchKeyword)
                Case "Birthing"
                    getBirthing(searchKeyword)
                Case "Weighing Children"
                    getWeighingChildren(searchKeyword)
                Case "Immunization"
                    getImmunization(searchKeyword)
            End Select
        End If
    End Sub

End Class
