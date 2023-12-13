<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class secondTrimesterView
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
        secondDt = New Guna.UI2.WinForms.Guna2DateTimePicker()
        secondDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        second_id = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtPatient = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(secondDataGridView, ComponentModel.ISupportInitialize).BeginInit()
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
        Guna2ControlBox1.TabIndex = 94
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(548, 50)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(81, 19)
        Guna2HtmlLabel2.TabIndex = 93
        Guna2HtmlLabel2.Text = "Select Date:"' 
        ' secondDt
        ' 
        secondDt.BorderRadius = 5
        secondDt.Checked = True
        secondDt.CustomFormat = "MMMM yyyy"
        secondDt.CustomizableEdges = CustomizableEdges3
        secondDt.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        secondDt.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        secondDt.Format = DateTimePickerFormat.Custom
        secondDt.Location = New Point(635, 47)
        secondDt.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        secondDt.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        secondDt.Name = "secondDt"
        secondDt.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        secondDt.Size = New Size(153, 25)
        secondDt.TabIndex = 92
        secondDt.Value = New DateTime(2023, 12, 11, 0, 0, 0, 0)
        ' 
        ' secondDataGridView
        ' 
        secondDataGridView.AllowUserToAddRows = False
        secondDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        secondDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        secondDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        secondDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        secondDataGridView.ColumnHeadersHeight = 30
        secondDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        secondDataGridView.Columns.AddRange(New DataGridViewColumn() {Column1, second_id, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        secondDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        secondDataGridView.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        secondDataGridView.Location = New Point(12, 88)
        secondDataGridView.Name = "secondDataGridView"
        secondDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        secondDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        secondDataGridView.RowHeadersVisible = False
        secondDataGridView.RowTemplate.Height = 25
        secondDataGridView.Size = New Size(776, 403)
        secondDataGridView.TabIndex = 91
        secondDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        secondDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        secondDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        secondDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        secondDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        secondDataGridView.ThemeStyle.BackColor = Color.White
        secondDataGridView.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        secondDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        secondDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        secondDataGridView.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        secondDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White
        secondDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        secondDataGridView.ThemeStyle.HeaderStyle.Height = 30
        secondDataGridView.ThemeStyle.ReadOnly = True
        secondDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White
        secondDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        secondDataGridView.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        secondDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        secondDataGridView.ThemeStyle.RowsStyle.Height = 25
        secondDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        secondDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "patient_id"
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Visible = False
        ' 
        ' second_id
        ' 
        second_id.DataPropertyName = "second_id"
        second_id.HeaderText = "ID"
        second_id.Name = "second_id"
        second_id.ReadOnly = True
        second_id.Width = 42
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "date_of_vist"
        Column2.HeaderText = "Date of Visit"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 96
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "gestational_age"
        Column3.HeaderText = "Gestational Age at Second Visit"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 211
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
        Column5.DataPropertyName = "blood_pressure"
        Column5.HeaderText = "Blood Pressure"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 115
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "fetalH_rate"
        Column6.HeaderText = "Fetal Heart Rate"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 121
        ' 
        ' Column7
        ' 
        Column7.DataPropertyName = "ultra_result"
        Column7.HeaderText = "Ultrasound Result"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 127
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(12, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(247, 27)
        Guna2HtmlLabel1.TabIndex = 90
        Guna2HtmlLabel1.Text = "Second Trimester History"' 
        ' txtPatient
        ' 
        txtPatient.BackColor = Color.Transparent
        txtPatient.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        txtPatient.Location = New Point(109, 63)
        txtPatient.Name = "txtPatient"
        txtPatient.Size = New Size(94, 18)
        txtPatient.TabIndex = 96
        txtPatient.Text = "Patient Name:"' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(12, 63)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(97, 19)
        Guna2HtmlLabel3.TabIndex = 95
        Guna2HtmlLabel3.Text = "Patient Name:"' 
        ' secondTrimesterView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(248), CByte(255))
        ClientSize = New Size(800, 520)
        Controls.Add(txtPatient)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(secondDt)
        Controls.Add(secondDataGridView)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "secondTrimesterView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "secondTrimesterView"
        CType(secondDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents secondDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPatient As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents second_id As DataGridViewTextBoxColumn
    Friend WithEvents secondDt As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
