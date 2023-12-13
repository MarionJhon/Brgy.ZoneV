<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class birthingServiceView
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
        birthDt = New Guna.UI2.WinForms.Guna2DateTimePicker()
        birthingDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        patient_id = New DataGridViewTextBoxColumn()
        id = New DataGridViewTextBoxColumn()
        date_of_delivery = New DataGridViewTextBoxColumn()
        babys_name = New DataGridViewTextBoxColumn()
        attend_healthworker = New DataGridViewTextBoxColumn()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        txtPatient = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(birthingDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(548, 50)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(81, 19)
        Guna2HtmlLabel2.TabIndex = 83
        Guna2HtmlLabel2.Text = "Select Date:"' 
        ' birthDt
        ' 
        birthDt.BorderRadius = 5
        birthDt.Checked = True
        birthDt.CustomFormat = "MMMM yyyy"
        birthDt.CustomizableEdges = CustomizableEdges1
        birthDt.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        birthDt.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        birthDt.Format = DateTimePickerFormat.Custom
        birthDt.Location = New Point(635, 47)
        birthDt.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        birthDt.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        birthDt.Name = "birthDt"
        birthDt.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        birthDt.Size = New Size(153, 25)
        birthDt.TabIndex = 82
        birthDt.Value = New DateTime(2023, 12, 10, 17, 15, 39, 0)
        ' 
        ' birthingDataGridView
        ' 
        birthingDataGridView.AllowUserToAddRows = False
        birthingDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        birthingDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        birthingDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        birthingDataGridView.ColumnHeadersHeight = 30
        birthingDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        birthingDataGridView.Columns.AddRange(New DataGridViewColumn() {patient_id, id, date_of_delivery, babys_name, attend_healthworker})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        birthingDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        birthingDataGridView.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        birthingDataGridView.Location = New Point(12, 88)
        birthingDataGridView.Name = "birthingDataGridView"
        birthingDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        birthingDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        birthingDataGridView.RowHeadersVisible = False
        birthingDataGridView.RowTemplate.Height = 25
        birthingDataGridView.Size = New Size(776, 403)
        birthingDataGridView.TabIndex = 81
        birthingDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        birthingDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        birthingDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        birthingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        birthingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        birthingDataGridView.ThemeStyle.BackColor = Color.White
        birthingDataGridView.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        birthingDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        birthingDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        birthingDataGridView.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        birthingDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White
        birthingDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        birthingDataGridView.ThemeStyle.HeaderStyle.Height = 30
        birthingDataGridView.ThemeStyle.ReadOnly = True
        birthingDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White
        birthingDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        birthingDataGridView.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        birthingDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        birthingDataGridView.ThemeStyle.RowsStyle.Height = 25
        birthingDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        birthingDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' patient_id
        ' 
        patient_id.DataPropertyName = "patient_id"
        patient_id.HeaderText = "ID"
        patient_id.Name = "patient_id"
        patient_id.ReadOnly = True
        patient_id.Visible = False
        ' 
        ' id
        ' 
        id.DataPropertyName = "birthing_id"
        id.HeaderText = "ID"
        id.Name = "id"
        id.ReadOnly = True
        ' 
        ' date_of_delivery
        ' 
        date_of_delivery.DataPropertyName = "date_of_delivery"
        date_of_delivery.HeaderText = "Date"
        date_of_delivery.Name = "date_of_delivery"
        date_of_delivery.ReadOnly = True
        ' 
        ' babys_name
        ' 
        babys_name.DataPropertyName = "babys_name"
        babys_name.HeaderText = "Baby's Name"
        babys_name.Name = "babys_name"
        babys_name.ReadOnly = True
        ' 
        ' attend_healthworker
        ' 
        attend_healthworker.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        attend_healthworker.DataPropertyName = "attend_healthworker"
        attend_healthworker.HeaderText = "Attending Health Worker / Midwife"
        attend_healthworker.Name = "attend_healthworker"
        attend_healthworker.ReadOnly = True
        attend_healthworker.Width = 229
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(12, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(239, 27)
        Guna2HtmlLabel1.TabIndex = 80
        Guna2HtmlLabel1.Text = "Birthing Services History"' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox1.FillColor = SystemColors.Control
        Guna2ControlBox1.HoverState.FillColor = Color.Red
        Guna2ControlBox1.HoverState.IconColor = Color.Black
        Guna2ControlBox1.IconColor = Color.Gray
        Guna2ControlBox1.Location = New Point(774, 1)
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
        txtPatient.TabIndex = 91
        txtPatient.Text = "Patient Name:"' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(12, 63)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(97, 19)
        Guna2HtmlLabel3.TabIndex = 90
        Guna2HtmlLabel3.Text = "Patient Name:"' 
        ' birthingServiceView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(248), CByte(255))
        ClientSize = New Size(800, 520)
        Controls.Add(txtPatient)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(birthDt)
        Controls.Add(birthingDataGridView)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "birthingServiceView"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "birthingServiceView"
        CType(birthingDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents birthingDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtPatient As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents patient_id As DataGridViewTextBoxColumn
    Friend WithEvents date_of_delivery As DataGridViewTextBoxColumn
    Friend WithEvents babys_name As DataGridViewTextBoxColumn
    Friend WithEvents attend_healthworker As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents birthDt As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
