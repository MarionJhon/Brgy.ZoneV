<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pregnantView
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pregnantDt = New Guna.UI2.WinForms.Guna2DateTimePicker()
        pregnantDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        pregnant_id = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        txtPatient = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(pregnantDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(548, 51)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(81, 19)
        Guna2HtmlLabel2.TabIndex = 83
        Guna2HtmlLabel2.Text = "Select Date:"' 
        ' pregnantDt
        ' 
        pregnantDt.BorderRadius = 5
        pregnantDt.Checked = True
        pregnantDt.CustomFormat = "MMMM yyyy"
        pregnantDt.CustomizableEdges = CustomizableEdges1
        pregnantDt.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        pregnantDt.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        pregnantDt.Format = DateTimePickerFormat.Custom
        pregnantDt.Location = New Point(635, 47)
        pregnantDt.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        pregnantDt.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        pregnantDt.Name = "pregnantDt"
        pregnantDt.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pregnantDt.Size = New Size(153, 25)
        pregnantDt.TabIndex = 82
        pregnantDt.Value = New DateTime(2023, 12, 11, 0, 0, 0, 0)
        ' 
        ' pregnantDataGridView
        ' 
        pregnantDataGridView.AllowUserToAddRows = False
        pregnantDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        pregnantDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        pregnantDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        pregnantDataGridView.ColumnHeadersHeight = 30
        pregnantDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        pregnantDataGridView.Columns.AddRange(New DataGridViewColumn() {Column1, pregnant_id, Column2, Column3, Column4})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        pregnantDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        pregnantDataGridView.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        pregnantDataGridView.Location = New Point(12, 88)
        pregnantDataGridView.Name = "pregnantDataGridView"
        pregnantDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        pregnantDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        pregnantDataGridView.RowHeadersVisible = False
        pregnantDataGridView.RowTemplate.Height = 25
        pregnantDataGridView.Size = New Size(776, 403)
        pregnantDataGridView.TabIndex = 81
        pregnantDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        pregnantDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        pregnantDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        pregnantDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        pregnantDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        pregnantDataGridView.ThemeStyle.BackColor = Color.White
        pregnantDataGridView.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        pregnantDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        pregnantDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        pregnantDataGridView.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        pregnantDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White
        pregnantDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        pregnantDataGridView.ThemeStyle.HeaderStyle.Height = 30
        pregnantDataGridView.ThemeStyle.ReadOnly = True
        pregnantDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White
        pregnantDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        pregnantDataGridView.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        pregnantDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        pregnantDataGridView.ThemeStyle.RowsStyle.Height = 25
        pregnantDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        pregnantDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "patient_id"
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Visible = False
        ' 
        ' pregnant_id
        ' 
        pregnant_id.DataPropertyName = "pregnant_id"
        pregnant_id.HeaderText = "ID"
        pregnant_id.Name = "pregnant_id"
        pregnant_id.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "date_of_visit"
        Column2.HeaderText = "Date of Visit"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "lmp"
        Column3.HeaderText = "Date of Last Menstrual Period (LMP)"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "edd"
        Column4.HeaderText = "Estimated Due Date (EDD)"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(12, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(257, 27)
        Guna2HtmlLabel1.TabIndex = 80
        Guna2HtmlLabel1.Text = "Pregnant Progress History"' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox1.FillColor = SystemColors.Control
        Guna2ControlBox1.HoverState.FillColor = Color.Red
        Guna2ControlBox1.HoverState.IconColor = Color.Black
        Guna2ControlBox1.IconColor = Color.Gray
        Guna2ControlBox1.Location = New Point(775, 0)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox1.Size = New Size(25, 22)
        Guna2ControlBox1.TabIndex = 84
        ' 
        ' txtPatient
        ' 
        txtPatient.BackColor = Color.Transparent
        txtPatient.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        txtPatient.Location = New Point(109, 63)
        txtPatient.Name = "txtPatient"
        txtPatient.Size = New Size(94, 18)
        txtPatient.TabIndex = 93
        txtPatient.Text = "Patient Name:"' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(12, 63)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(97, 19)
        Guna2HtmlLabel3.TabIndex = 92
        Guna2HtmlLabel3.Text = "Patient Name:"' 
        ' pregnantView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(248), CByte(255))
        ClientSize = New Size(800, 520)
        Controls.Add(txtPatient)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(pregnantDt)
        Controls.Add(pregnantDataGridView)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "pregnantView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "pregnantView"
        CType(pregnantDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents pregnantDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtPatient As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents pregnant_id As DataGridViewTextBoxColumn
    Friend WithEvents pregnantDt As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
