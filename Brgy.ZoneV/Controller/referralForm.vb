Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Drawing.Printing
Imports System.Diagnostics.Eventing

Public Class referralForm
    Dim connString As String = "datasource=localhost;port=3306;username=root;password=;database=bzvhcims;"
    Dim errorProvider As New ErrorProvider()
    Private Sub LoadDataIntoDataGridView()
        Using conn As New MySqlConnection(connString)
            Dim dataTable As New DataTable()

            Try
                conn.Open()

                ' Add a WHERE clause to filter the results based on the search criteria
                Dim selectQuery As String = "SELECT r.ID, p.patient_id, CONCAT(p.fname, ' ', p.mname, ' ', p.lname) AS Fullname, p.gender, TIMESTAMPDIFF(YEAR, p.dob, CURDATE()) AS Age, r.referral_date, r.reason_of_referral " &
                        "FROM bzvhcims.referral r " &
                        "INNER JOIN bzvhcims.patient p ON r.patient_id = p.patient_id " &
                        "WHERE CONCAT(p.fname, ' ', p.mname, ' ', p.lname) LIKE @searchKeyword"

                Using adapter As New MySqlDataAdapter(selectQuery, conn)
                    ' Add the parameter for the search keyword
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" & txtSearch.Text.Trim() & "%")

                    adapter.Fill(dataTable)
                    referralDatagrid.DataSource = dataTable
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub





    Private Sub PerformSearch()
        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT fname, mname, lname, dob, gender FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) LIKE @searchText", conn)
            cmd.Parameters.AddWithValue("@searchText", "%" & search.Text.Trim() & "%")

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)

                Dim column1 As New AutoCompleteStringCollection
                For i As Integer = 0 To dt.Rows.Count - 1
                    column1.Add(dt.Rows(i)("fname").ToString() & " " & dt.Rows(i)("mname").ToString() & " " & dt.Rows(i)("lname").ToString())
                Next

                search.AutoCompleteSource = AutoCompleteSource.CustomSource
                search.AutoCompleteCustomSource = column1
                search.AutoCompleteMode = AutoCompleteMode.Suggest

            Catch ex As Exception
                MessageBox.Show("Error performing search: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub referralForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
        LoadPatientData()
        WeightResults()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                If String.IsNullOrEmpty(patientsname.Text.Trim()) Then
                    MessageBox.Show("Please select a patient.")
                    Return
                End If

                ' Validate temperature
                If String.IsNullOrEmpty(temperature.Text.Trim()) Then
                    errorProvider.SetError(temperature, "Temperature is required.")
                Else
                    errorProvider.SetError(temperature, "") ' Clear error if valid
                End If

                ' Validate blood pressure
                If String.IsNullOrEmpty(systolic.Text.Trim()) OrElse String.IsNullOrEmpty(diastolic.Text.Trim()) Then
                    errorProvider.SetError(diastolic, "Systolic and Diastolic are required.")
                Else
                    errorProvider.SetError(diastolic, "") ' Clear error if valid
                End If

                ' Validate weight
                If String.IsNullOrEmpty(weight.Text.Trim()) Then
                    errorProvider.SetError(weight, "Weight is required.")
                Else
                    errorProvider.SetError(weight, "") ' Clear error if valid
                End If

                ' Validate height
                If String.IsNullOrEmpty(height.Text.Trim()) Then
                    errorProvider.SetError(height, "Height is required.")
                Else
                    errorProvider.SetError(height, "") ' Clear error if valid
                End If

                ' Validate refer place
                If String.IsNullOrEmpty(referplace.Text.Trim()) Then
                    errorProvider.SetError(referplace, "Refer place is required.")
                Else
                    errorProvider.SetError(referplace, "") ' Clear error if valid
                End If

                ' Validate reason of referral
                If String.IsNullOrEmpty(reason_of_referral.Text.Trim()) Then
                    errorProvider.SetError(reason_of_referral, "Reason of referral is required.")
                Else
                    errorProvider.SetError(reason_of_referral, "") ' Clear error if valid
                End If

                ' If any validation failed, exit the method
                If errorProvider.GetError(temperature) <> "" OrElse
                    errorProvider.GetError(diastolic) <> "" OrElse
                    errorProvider.GetError(weight) <> "" OrElse
                    errorProvider.GetError(height) <> "" OrElse
                    errorProvider.GetError(referplace) <> "" OrElse
                    errorProvider.GetError(reason_of_referral) <> "" Then
                    MessageBox.Show("Please fill in all required fields.")
                    Return
                End If


                ' Retrieve patient_id based on the selected patient's name
                Dim patientIdQuery As String = "SELECT patient_id FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) = @selectedPatientName"
                Dim patientIdCmd As New MySqlCommand(patientIdQuery, conn)
                patientIdCmd.Parameters.AddWithValue("@selectedPatientName", patientsname.Text.Trim())

                Dim patientId As Object = patientIdCmd.ExecuteScalar()

                If patientId IsNot Nothing Then
                    ' Check if data already exists in referral table for the given patient
                    Dim checkExistingQuery As String = "SELECT COUNT(*) FROM bzvhcims.referral WHERE patient_id = @patientId"
                    Dim checkExistingCmd As New MySqlCommand(checkExistingQuery, conn)
                    checkExistingCmd.Parameters.AddWithValue("@patientId", patientId)

                    Dim existingCount As Integer = CInt(checkExistingCmd.ExecuteScalar())

                    If existingCount = 0 Then
                        ' Insert data into the referral table with patient_id as a foreign key
                        Dim referralQuery As String = "INSERT INTO bzvhcims.referral (patient_id, referralID, referral_date, refer_place, reason_of_referral, temperature, blood_pressure, weight, height) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9)"
                        Dim referralCmd As New MySqlCommand(referralQuery, conn)
                        referralCmd.Parameters.AddWithValue("@value1", patientId)
                        referralCmd.Parameters.AddWithValue("@value2", referral_id.Text)
                        referralCmd.Parameters.AddWithValue("@value3", referral_date.Value)
                        referralCmd.Parameters.AddWithValue("@value4", referplace.Text) ' Added refer_place parameter
                        referralCmd.Parameters.AddWithValue("@value5", reason_of_referral.Text)
                        referralCmd.Parameters.AddWithValue("@value6", temperature.Text)
                        referralCmd.Parameters.AddWithValue("@value7", systolic.Text & " / " & diastolic.Text)
                        referralCmd.Parameters.AddWithValue("@value8", weight.Text)
                        referralCmd.Parameters.AddWithValue("@value9", height.Text)

                        Dim rowsAffected As Integer = referralCmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Data inserted successfully into the referral table!")
                            LoadDataIntoDataGridView()
                        Else
                            MessageBox.Show("Failed to insert data into referral table.")
                        End If

                        Dim insertQuery As String = "INSERT INTO bzvhcims.referralsaverecord " &
                           "(patient_id, referral_date, refer_place, reason_of_referral) " &
                           "VALUES ( @patient_id, @referral_date, @refer_place, @reason_of_referral)"

                        Using cmd As New MySqlCommand(insertQuery, conn)
                            ' Set parameters for the insert query
                            cmd.Parameters.AddWithValue("@referral_date", referral_date.Value)
                            cmd.Parameters.AddWithValue("@refer_place", referplace.Text)
                            cmd.Parameters.AddWithValue("@reason_of_referral", reason_of_referral.Text)
                            cmd.Parameters.AddWithValue("@patient_id", patientId) ' Assuming you have a patientId variable

                            ' Execute the insert query
                            cmd.ExecuteNonQuery()
                        End Using

                    Else
                        MessageBox.Show("Data already exists in referral table for the given patient.")
                    End If
                Else
                    MessageBox.Show("Patient not found.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub



    Private Sub LoadPatientData()
        Dim selectedPatientName As String = search.Text.Trim()

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("SELECT patient_id, fname, mname, lname, dob, gender FROM bzvhcims.patient WHERE CONCAT(fname, ' ', mname, ' ', lname) = @selectedPatientName", conn)
            cmd.Parameters.AddWithValue("@selectedPatientName", selectedPatientName)

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    ' Display the first matching record in the textboxes
                    Dim row As DataRow = dt.Rows(0)
                    patientsname.Text = row("fname").ToString() & " " & row("mname").ToString() & " " & row("lname").ToString()
                    dob.Text = row("dob").ToString()
                    gender.Text = row("gender").ToString()
                    age.Text = CalculateAge(row.Field(Of DateTime)("dob")).ToString()

                    ' Generate a unique ID based on patient information
                    Dim uniqueID As String = GenerateUniqueID(row)
                    referral_id.Text = uniqueID
                Else
                    ' Clear textboxes if no matching record is found
                    patientsname.Text = ""
                    gender.Text = ""
                    dob.Value = DateTime.Today
                    age.Text = ""
                    referral_id.Text = ""
                    temperature.Text = ""
                    systolic.Text = ""
                    diastolic.Text = ""
                    referral_date.Value = DateTime.Today
                    weight.Text = ""
                    height.Text = ""
                    referplace.Text = ""
                    reason_of_referral.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving patient data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function GenerateUniqueID(row As DataRow) As String
        ' Concatenate patient information and patient ID for generating a unique ID
        Dim patientInfo As String = row("fname").ToString() & row("mname").ToString() & row("lname").ToString() & row("dob").ToString()
        Dim patientID As String = row("patient_id").ToString()

        ' Remove non-numeric characters
        Dim numericID As String = New String((patientInfo & patientID).Where(Function(c) Char.IsDigit(c)).ToArray())

        Return numericID
    End Function


    Private Sub referralDatagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles referralDatagrid.CellClick
        If e.ColumnIndex = referralDatagrid.Columns("info").Index AndAlso e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = referralDatagrid.Rows(e.RowIndex)
                'Dim referralId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("referral").Value)
                Dim patientId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("patient_id").Value)
                Dim fullName As String = row.Cells("fullname").Value.ToString()
                Dim view As New ReferralView(fullName, patientId)
                view.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - view.Width) / 2, 0)
                tranparentBG.ShowForm(view)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If

    End Sub


    Private Sub referralDatagrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles referralDatagrid.CellContentDoubleClick
        ' Check if the clicked cell is not a header cell and a valid row is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the ID from the selected row
            Dim referralId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("referral").Value)
            Dim patientId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("patient_id").Value)
            ' Assuming "ID" is the name of the column containing the referral ID.

            ' Open the edit form with the selected ID
            Dim frm As New editReferral(referralId, patientId)
            frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0)
            tranparentBG.ShowForm(frm)
        End If

        LoadDataIntoDataGridView()

    End Sub
    Private Sub search_TextChanged_1(sender As Object, e As EventArgs) Handles search.TextChanged
        PerformSearch()
        LoadPatientData()
    End Sub

    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDataIntoDataGridView()
    End Sub

    Private Sub referralDatagrid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles referralDatagrid.CellEnter
        If e.ColumnIndex = referralDatagrid.Columns("action").Index AndAlso e.RowIndex >= 0 Then
            ' Add your print logic here
            ' For example, you can get the referral information from the selected row
            Dim referralId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("referral").Value)
            Dim patientId As Integer = Convert.ToInt32(referralDatagrid.Rows(e.RowIndex).Cells("patient_id").Value)

            ' Call a method to print the referral using the referralId and patientId
            PrintReferral(referralId, patientId)
        End If
    End Sub

    Private Sub PrintReferral(referralId As Integer, patientId As Integer)
        ' Gather necessary information from the database based on referralId and patientId
        Dim referralInfo As String = GetReferralInfoFromDatabase(referralId)
        Dim patientInfo As String = GetPatientInfoFromDatabase(patientId)

        ' Create a StringBuilder to build the printable content
        Dim printableContent As New StringBuilder()

        ' Append the patient information
        printableContent.AppendLine("Patient Information:")
        printableContent.AppendLine(patientInfo)

        ' Append a separator
        printableContent.AppendLine("------------------------------")

        ' Append the referral information
        printableContent.AppendLine("Referral Information:")
        printableContent.AppendLine(referralInfo)

        ' Create a PrintDocument object for printing
        Dim pd As New PrintDocument()

        ' Set up the PrintPage event handler to define the content to be printed
        AddHandler pd.PrintPage, Sub(sender As Object, e As PrintPageEventArgs)
                                     ' Use a Graphics object to draw the content on the page
                                     Dim g As Graphics = e.Graphics

                                     ' Use a Font for printing
                                     Using font As New Font("Arial", 12)
                                         ' Define the rectangle for printing
                                         Dim rect As New Rectangle(10, 10, pd.DefaultPageSettings.PrintableArea.Width - 20, pd.DefaultPageSettings.PrintableArea.Height - 20)

                                         ' Draw the printable content on the page
                                         g.DrawString(printableContent.ToString(), font, Brushes.Black, rect, New StringFormat())
                                     End Using
                                 End Sub

        ' Display the PrintDialog to allow the user to choose a printer and print settings
        Using printDialog As New PrintDialog()
            printDialog.Document = pd

            If printDialog.ShowDialog() = DialogResult.OK Then
                ' Print the document
                pd.Print()
            End If
        End Using
    End Sub

    Private Function GetReferralInfoFromDatabase(referralId As Integer) As String
        Dim referralInfo As New StringBuilder()

        Using conn As New MySqlConnection(connString)
            conn.Open()

            Dim selectQuery As String = "SELECT referral_date, refer_place, reason_of_referral, temperature, blood_pressure, weight, height FROM bzvhcims.referral WHERE ID = @referralId"

            Using cmd As New MySqlCommand(selectQuery, conn)
                cmd.Parameters.AddWithValue("@referralId", referralId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Assuming the data types are DateTime, String, and String
                        referralInfo.AppendLine($"Referral Date: {reader.GetDateTime("referral_date").ToString("yyyy-MM-dd")}")
                        referralInfo.AppendLine($"Referral Place: {reader.GetString("refer_place")}")
                        referralInfo.AppendLine($"Reason of Referral: {reader.GetString("reason_of_referral")}")
                        referralInfo.AppendLine($"Temperature: {reader.GetString("temperature")}")
                        referralInfo.AppendLine($"BP: {reader.GetString("blood_pressure")}")
                        referralInfo.AppendLine($"Wt: {reader.GetString("weight")}")
                        referralInfo.AppendLine($"Ht: {reader.GetString("height")}")
                    End If
                End Using
            End Using
        End Using

        Return referralInfo.ToString()
    End Function

    Private Function GetPatientInfoFromDatabase(patientId As Integer) As String
        Dim patientInfo As New StringBuilder()

        Using conn As New MySqlConnection(connString)
            conn.Open()

            Dim selectQuery As String = "SELECT fname, mname, lname, dob, gender, address FROM bzvhcims.patient WHERE patient_id = @patientId"

            Using cmd As New MySqlCommand(selectQuery, conn)
                cmd.Parameters.AddWithValue("@patientId", patientId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Assuming the data types are String, String, String, DateTime, String, and String
                        patientInfo.AppendLine($"Name: {reader.GetString("fname")} {reader.GetString("mname")} {reader.GetString("lname")}")
                        patientInfo.AppendLine($"Age: {CalculateAge(reader.GetDateTime("dob"))}")
                        patientInfo.AppendLine($"Birthday: {reader.GetDateTime("dob").ToString("yyyy-MM-dd")}")
                        patientInfo.AppendLine($"Sex: {reader.GetString("gender")}")
                        patientInfo.AppendLine($"Address: {reader.GetString("address")}")
                    End If
                End Using
            End Using
        End Using

        Return patientInfo.ToString()
    End Function

    Private Function CalculateAge(birthdate As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthdate.Year

        If birthdate > today.AddYears(-age) Then
            age -= 1
        End If

        Return age
    End Function
    Private Sub temperature_TextChanged(sender As Object, e As EventArgs) Handles temperature.TextChanged
        ' Call your temperatureResult method or include the logic directly in this event handler
        temperatureResult()
    End Sub

    Private Sub temperatureResult()
        ' Check if the temperature is not empty
        If Not String.IsNullOrEmpty(temperature.Text.Trim()) Then
            ' Parse the temperature value
            If Double.TryParse(temperature.Text.Trim(), Nothing) Then
                ' Get the numeric value of the temperature
                Dim tempValue As Double = Double.Parse(temperature.Text.Trim())

                ' Display the temperature with the unit (Celsius)
                tempResult.Text = $"°C"

                ' Check the temperature range and provide a description
                If tempValue < 35.5 Then
                    tempResult.Text += " - Hypothermia (Below Normal)"
                ElseIf tempValue >= 35.5 AndAlso tempValue < 37.0 Then
                    tempResult.Text += " - Normal Body Temperature"
                ElseIf tempValue >= 37.0 AndAlso tempValue < 38.0 Then
                    tempResult.Text += " - Slightly Elevated Temperature"
                ElseIf tempValue >= 38.0 AndAlso tempValue < 39.0 Then
                    tempResult.Text += " - Fever"
                ElseIf tempValue >= 39.0 Then
                    tempResult.Text += " - High Fever (Seek Medical Attention)"
                End If
            Else
                ' Display an error message if the temperature is not a valid number
                tempResult.Text = " - Invalid temperature"
            End If
        Else
            ' Clear the temperature result label if the temperature is empty
            tempResult.Text = ""
        End If
    End Sub

    Private Sub diastolic_TextChanged(sender As Object, e As EventArgs) Handles diastolic.TextChanged, systolic.TextChanged
        bloodPressureResult()
    End Sub
    Private Sub bloodPressureResult()
        bloodResult.Text = ""

        ' Check if the blood pressure values are not empty
        If Not String.IsNullOrEmpty(systolic.Text.Trim()) AndAlso Not String.IsNullOrEmpty(diastolic.Text.Trim()) Then
            ' Parse the blood pressure values
            If Integer.TryParse(systolic.Text.Trim(), Nothing) AndAlso Integer.TryParse(diastolic.Text.Trim(), Nothing) Then
                ' Get the numeric values of systolic and diastolic pressure
                Dim systolicValue As Integer = Integer.Parse(systolic.Text.Trim())
                Dim diastolicValue As Integer = Integer.Parse(diastolic.Text.Trim())

                ' Check the blood pressure range and provide a description
                If systolicValue < 90 AndAlso diastolicValue < 60 Then
                    bloodResult.Text = " - Low Blood Pressure"
                ElseIf systolicValue >= 90 AndAlso systolicValue <= 120 AndAlso diastolicValue >= 60 AndAlso diastolicValue <= 80 Then
                    bloodResult.Text = " - Normal Blood Pressure"
                ElseIf systolicValue > 120 AndAlso systolicValue <= 130 AndAlso diastolicValue > 80 AndAlso diastolicValue <= 85 Then
                    bloodResult.Text = " - Elevated Blood Pressure (Prehypertension)"
                ElseIf systolicValue > 130 AndAlso systolicValue <= 140 AndAlso diastolicValue > 85 AndAlso diastolicValue <= 90 Then
                    bloodResult.Text = " - Stage 1 Hypertension"
                ElseIf systolicValue > 140 AndAlso diastolicValue > 90 Then
                    bloodResult.Text = " - Stage 2 Hypertension (Seek Medical Attention)"
                End If
            Else
                ' Display a user-friendly message if the blood pressure values are not valid numbers
                bloodResult.Text = " - Invalid blood pressure values"
            End If
        Else
            ' Clear the blood pressure result label if the values are empty
            bloodResult.Text = ""
        End If
    End Sub
    Private Sub height_TextChanged(sender As Object, e As EventArgs) Handles height.TextChanged
        heightResult()
    End Sub

    Private Sub weight_TextChanged(sender As Object, e As EventArgs) Handles weight.TextChanged
        ' Call the weightResult method or include the logic directly in this event handler
        WeightResults()
    End Sub

    Private Sub WeightResults()
        ' Clear previous results
        weightResultLabel.Text = ""

        ' Check if the weight value and age are not empty
        If Not String.IsNullOrEmpty(weight.Text.Trim()) AndAlso Not String.IsNullOrEmpty(age.Text.Trim()) Then
            ' Parse the weight and age values
            If Double.TryParse(weight.Text.Trim(), Nothing) AndAlso Integer.TryParse(age.Text.Trim(), Nothing) Then
                ' Get the numeric values of weight and age
                Dim weightValue As Double = Double.Parse(weight.Text.Trim())
                Dim ageValue As Integer = Integer.Parse(age.Text.Trim())

                ' Check the age range
                If ageValue >= 0 AndAlso ageValue <= 5 Then
                    ' Infant
                    If weightValue >= 5.5 AndAlso weightValue < 10.5 Then
                        weightResultLabel.Text = " - Low Birth Weight"
                    ElseIf weightValue >= 10.5 AndAlso weightValue < 15.5 Then
                        weightResultLabel.Text = " - Normal Birth Weight"
                    ElseIf weightValue >= 15.5 AndAlso weightValue < 20.9 Then
                        weightResultLabel.Text = " - High Birth Weight"
                    Else
                        weightResultLabel.ForeColor = SystemColors.ControlText
                    End If
                ElseIf ageValue > 5 AndAlso ageValue <= 12 Then
                    If weightValue < 18.0 Then
                        weightResultLabel.Text = " - Underweight"
                    ElseIf weightValue >= 18.0 AndAlso weightValue < 32.0 Then
                        weightResultLabel.Text = " - Normal Weight"
                    ElseIf weightValue >= 32.0 AndAlso weightValue < 40.0 Then
                        weightResultLabel.Text = " - Overweight"
                    ElseIf weightValue >= 40.0 Then
                        weightResultLabel.Text = " - Obesity"
                    Else
                        weightResultLabel.ForeColor = SystemColors.ControlText
                    End If
                ElseIf ageValue > 12 AndAlso ageValue <= 18 Then
                    ' Adolescent
                    If weightValue < 45.0 Then
                        weightResultLabel.Text = " - Underweight"
                    ElseIf weightValue >= 45.0 AndAlso weightValue < 70.0 Then
                        weightResultLabel.Text = " - Normal Weight"
                    ElseIf weightValue >= 70.0 AndAlso weightValue < 90.0 Then
                        weightResultLabel.Text = " - Overweight"
                    ElseIf weightValue >= 90.0 Then
                        weightResultLabel.Text = " - Obesity"
                    Else
                        weightResultLabel.ForeColor = SystemColors.ControlText

                    End If
                ElseIf ageValue > 18 AndAlso ageValue <= 35 Then
                    ' Adult (18-35 years old)
                    If weightValue < 50.0 Then
                        weightResultLabel.Text = " - Underweight"
                    ElseIf weightValue >= 50.0 AndAlso weightValue < 75.0 Then
                        weightResultLabel.Text = " - Normal Weight"
                    ElseIf weightValue >= 75.0 AndAlso weightValue < 100.0 Then
                        weightResultLabel.Text = " - Overweight"
                    ElseIf weightValue >= 100.0 Then
                        weightResultLabel.Text = " - Obesity"
                    Else
                        weightResultLabel.ForeColor = SystemColors.ControlText

                    End If
                ElseIf ageValue > 35 AndAlso ageValue <= 65 Then
                    ' Middle-aged adult (35-65 years old)
                    If weightValue < 55.0 Then
                        weightResultLabel.Text = " - Underweight"
                    ElseIf weightValue >= 55.0 AndAlso weightValue < 80.0 Then
                        weightResultLabel.Text = " - Normal Weight"
                    ElseIf weightValue >= 80.0 AndAlso weightValue < 105.0 Then
                        weightResultLabel.Text = " - Overweight"
                    ElseIf weightValue >= 105.0 Then
                        weightResultLabel.Text = " - Obesity"
                    Else
                        weightResultLabel.ForeColor = SystemColors.ControlText

                    End If
                ElseIf ageValue > 65 AndAlso ageValue <= 95 Then
                    ' Senior (65-95 years old)
                    If weightValue < 50.0 Then
                        weightResultLabel.Text = " - Underweight"
                    ElseIf weightValue >= 50.0 AndAlso weightValue < 75.0 Then
                        weightResultLabel.Text = " - Normal Weight"
                    ElseIf weightValue >= 75.0 AndAlso weightValue < 100.0 Then
                        weightResultLabel.Text = " - Overweight"
                    ElseIf weightValue >= 100.0 Then
                        weightResultLabel.Text = " - Obesity"
                    Else
                        weightResultLabel.ForeColor = SystemColors.ControlText
                    End If
                Else
                    ' Display a message if the age is outside the valid range
                    weightResultLabel.Text = " - Age should be between 0 and 95"
                    weightResultLabel.ForeColor = Color.Red
                End If

                ' Show the weightResult label
                weightResultLabel.Visible = True
            Else
                ' Display a user-friendly message if the weight or age value is not a valid number
                weightResultLabel.Text = " - Invalid weight or age value"
                weightResultLabel.ForeColor = Color.Red

                ' Show the weightResult label
                weightResultLabel.Visible = True
            End If
        Else
            ' Hide the weightResult label if the value is empty
            weightResultLabel.Visible = False
        End If
    End Sub




    Private Sub heightResult()
        ' Check if the height value is not empty
        If Not String.IsNullOrEmpty(height.Text.Trim()) Then
            ' Parse the height value
            If Double.TryParse(height.Text.Trim(), Nothing) Then
                ' Get the numeric value of height
                Dim heightValue As Double = Double.Parse(height.Text.Trim())

                ' Check the height range and provide a description
                If heightValue < 150 Then
                    heightResults.Text = " - Short stature"
                ElseIf heightValue >= 150 AndAlso heightValue < 180 Then
                    heightResults.Text = " - Average height"
                ElseIf heightValue >= 180 Then
                    heightResults.Text = " - Tall stature"
                End If
            Else
                ' Display an error message if the height value is not a valid number
                heightResults.Text = "Invalid height value"
            End If
        Else
            ' Clear the height result label if the value is empty
            heightResults.Text = ""
        End If
    End Sub


End Class

