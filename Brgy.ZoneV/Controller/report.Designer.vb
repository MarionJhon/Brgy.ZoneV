<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        searchReport = New Guna.UI2.WinForms.Guna2TextBox()
        reportDatagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        selectServices = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        tetx = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(reportDatagrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' searchReport
        ' 
        searchReport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        searchReport.BorderRadius = 5
        searchReport.CustomizableEdges = CustomizableEdges1
        searchReport.DefaultText = ""
        searchReport.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        searchReport.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        searchReport.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        searchReport.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        searchReport.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        searchReport.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        searchReport.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        searchReport.Location = New Point(545, 15)
        searchReport.Name = "searchReport"
        searchReport.PasswordChar = ChrW(0)
        searchReport.PlaceholderText = ""
        searchReport.SelectedText = ""
        searchReport.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        searchReport.Size = New Size(220, 30)
        searchReport.TabIndex = 20
        ' 
        ' reportDatagrid
        ' 
        reportDatagrid.AllowUserToAddRows = False
        reportDatagrid.AllowUserToDeleteRows = False
        reportDatagrid.AllowUserToResizeColumns = False
        reportDatagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        reportDatagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        reportDatagrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        reportDatagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        reportDatagrid.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        reportDatagrid.DefaultCellStyle = DataGridViewCellStyle3
        reportDatagrid.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        reportDatagrid.Location = New Point(19, 94)
        reportDatagrid.Name = "reportDatagrid"
        reportDatagrid.ReadOnly = True
        reportDatagrid.RowHeadersVisible = False
        reportDatagrid.RowTemplate.Height = 25
        reportDatagrid.Size = New Size(746, 481)
        reportDatagrid.TabIndex = 19
        reportDatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        reportDatagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        reportDatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        reportDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        reportDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        reportDatagrid.ThemeStyle.BackColor = Color.White
        reportDatagrid.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        reportDatagrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        reportDatagrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        reportDatagrid.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        reportDatagrid.ThemeStyle.HeaderStyle.ForeColor = Color.White
        reportDatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        reportDatagrid.ThemeStyle.HeaderStyle.Height = 30
        reportDatagrid.ThemeStyle.ReadOnly = True
        reportDatagrid.ThemeStyle.RowsStyle.BackColor = Color.White
        reportDatagrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        reportDatagrid.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        reportDatagrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        reportDatagrid.ThemeStyle.RowsStyle.Height = 25
        reportDatagrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        reportDatagrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(19, 15)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(89, 30)
        Guna2HtmlLabel1.TabIndex = 18
        Guna2HtmlLabel1.Text = "Reports"' 
        ' Guna2Button2
        ' 
        Guna2Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2Button2.BorderRadius = 5
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        Guna2Button2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button2.ForeColor = Color.Black
        Guna2Button2.Location = New Point(713, 54)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(52, 30)
        Guna2Button2.TabIndex = 25
        Guna2Button2.Text = "Print"' 
        ' selectServices
        ' 
        selectServices.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        selectServices.BackColor = Color.Transparent
        selectServices.BorderColor = Color.FromArgb(CByte(213), CByte(218), CByte(223))
        selectServices.BorderRadius = 5
        selectServices.CustomizableEdges = CustomizableEdges5
        selectServices.DrawMode = DrawMode.OwnerDrawFixed
        selectServices.DropDownStyle = ComboBoxStyle.DropDownList
        selectServices.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        selectServices.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        selectServices.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        selectServices.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        selectServices.ItemHeight = 24
        selectServices.Items.AddRange(New Object() {"Referral", "Blood Pressure", "Pregnant Progress", "Birthing", "Weighing Children", "Immunization"})
        selectServices.Location = New Point(522, 54)
        selectServices.Name = "selectServices"
        selectServices.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        selectServices.Size = New Size(185, 30)
        selectServices.TabIndex = 26
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.BorderRadius = 5
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges7
        Guna2DateTimePicker1.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        Guna2DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Short
        Guna2DateTimePicker1.Location = New Point(106, 58)
        Guna2DateTimePicker1.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2DateTimePicker1.Size = New Size(120, 25)
        Guna2DateTimePicker1.TabIndex = 27
        Guna2DateTimePicker1.Value = New DateTime(2023, 11, 19, 20, 24, 4, 752)
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(417, 59)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(99, 19)
        Guna2HtmlLabel2.TabIndex = 81
        Guna2HtmlLabel2.Text = "Select Services:"' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(19, 60)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(81, 19)
        Guna2HtmlLabel3.TabIndex = 82
        Guna2HtmlLabel3.Text = "Select Date:"' 
        ' tetx
        ' 
        tetx.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        tetx.BackColor = Color.Transparent
        tetx.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tetx.Location = New Point(489, 20)
        tetx.Name = "tetx"
        tetx.Size = New Size(50, 19)
        tetx.TabIndex = 83
        tetx.Text = "Search:"' 
        ' report
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(785, 605)
        Controls.Add(tetx)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2DateTimePicker1)
        Controls.Add(selectServices)
        Controls.Add(Guna2Button2)
        Controls.Add(searchReport)
        Controls.Add(reportDatagrid)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "report"
        Text = "report"
        CType(reportDatagrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents selectServices As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents reportDatagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents searchReport As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tetx As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
