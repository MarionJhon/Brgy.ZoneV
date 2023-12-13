<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thirdTrimesterView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        thirdDt = New Guna.UI2.WinForms.Guna2DateTimePicker()
        thirdDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtPatient = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(thirdDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox1.FillColor = SystemColors.Control
        Guna2ControlBox1.HoverState.FillColor = Color.Red
        Guna2ControlBox1.HoverState.IconColor = Color.Black
        Guna2ControlBox1.IconColor = Color.Gray
        Guna2ControlBox1.Location = New Point(773, 2)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox1.Size = New Size(25, 22)
        Guna2ControlBox1.TabIndex = 99
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(548, 50)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(81, 19)
        Guna2HtmlLabel2.TabIndex = 98
        Guna2HtmlLabel2.Text = "Select Date:"' 
        ' thirdDt
        ' 
        thirdDt.BorderRadius = 5
        thirdDt.Checked = True
        thirdDt.CustomFormat = "MMMM yyyy"
        thirdDt.CustomizableEdges = CustomizableEdges3
        thirdDt.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        thirdDt.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        thirdDt.Format = DateTimePickerFormat.Custom
        thirdDt.Location = New Point(635, 47)
        thirdDt.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        thirdDt.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        thirdDt.Name = "thirdDt"
        thirdDt.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        thirdDt.Size = New Size(153, 25)
        thirdDt.TabIndex = 97
        thirdDt.Value = New DateTime(2023, 12, 10, 17, 17, 29, 0)
        ' 
        ' thirdDataGridView
        ' 
        thirdDataGridView.AllowUserToAddRows = False
        thirdDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        thirdDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        thirdDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        thirdDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        thirdDataGridView.ColumnHeadersHeight = 30
        thirdDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        thirdDataGridView.Columns.AddRange(New DataGridViewColumn() {Column1, Column8, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        thirdDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        thirdDataGridView.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        thirdDataGridView.Location = New Point(12, 88)
        thirdDataGridView.Name = "thirdDataGridView"
        thirdDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        thirdDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        thirdDataGridView.RowHeadersVisible = False
        thirdDataGridView.RowTemplate.Height = 25
        thirdDataGridView.Size = New Size(776, 403)
        thirdDataGridView.TabIndex = 96
        thirdDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        thirdDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        thirdDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        thirdDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        thirdDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        thirdDataGridView.ThemeStyle.BackColor = Color.White
        thirdDataGridView.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        thirdDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        thirdDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        thirdDataGridView.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        thirdDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White
        thirdDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        thirdDataGridView.ThemeStyle.HeaderStyle.Height = 30
        thirdDataGridView.ThemeStyle.ReadOnly = True
        thirdDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White
        thirdDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        thirdDataGridView.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        thirdDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        thirdDataGridView.ThemeStyle.RowsStyle.Height = 25
        thirdDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        thirdDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Column1.DataPropertyName = "date_of_visit"
        Column1.HeaderText = "Date of Visit"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 96
        ' 
        ' Column8
        ' 
        Column8.DataPropertyName = "patient_id"
        Column8.HeaderText = "ID"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Visible = False
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Column2.DataPropertyName = "gestational_age"
        Column2.HeaderText = "Gestational at Age of Third Visit"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 208
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Column3.DataPropertyName = "blood_pressure"
        Column3.HeaderText = "Blood Pressure"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 115
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "weight"
        Column4.HeaderText = "Weight"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 70
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Column5.DataPropertyName = "fetal_pos"
        Column5.HeaderText = "Fetal Position"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 105
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Column6.DataPropertyName = "fundal_height"
        Column6.HeaderText = "Fundal Height"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 109
        ' 
        ' Column7
        ' 
        Column7.DataPropertyName = "edema"
        Column7.HeaderText = "Edema"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 71
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(12, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(218, 27)
        Guna2HtmlLabel1.TabIndex = 95
        Guna2HtmlLabel1.Text = "Third Trimester History"' 
        ' txtPatient
        ' 
        txtPatient.BackColor = Color.Transparent
        txtPatient.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        txtPatient.Location = New Point(108, 63)
        txtPatient.Name = "txtPatient"
        txtPatient.Size = New Size(94, 18)
        txtPatient.TabIndex = 101
        txtPatient.Text = "Patient Name:"' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(11, 63)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(97, 19)
        Guna2HtmlLabel3.TabIndex = 100
        Guna2HtmlLabel3.Text = "Patient Name:"' 
        ' thirdTrimesterView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(248), CByte(255))
        ClientSize = New Size(800, 520)
        Controls.Add(txtPatient)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(thirdDt)
        Controls.Add(thirdDataGridView)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "thirdTrimesterView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "thirdTrimesterView"
        CType(thirdDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents thirdDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPatient As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents thirdDt As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
