<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class weighingChildrenView
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
        weighingDt = New Guna.UI2.WinForms.Guna2DateTimePicker()
        weighingDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        ID = New DataGridViewTextBoxColumn()
        weighing_id = New DataGridViewTextBoxColumn()
        weight = New DataGridViewTextBoxColumn()
        weight_date = New DataGridViewTextBoxColumn()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        txtPatient = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(weighingDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(548, 50)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(81, 19)
        Guna2HtmlLabel2.TabIndex = 73
        Guna2HtmlLabel2.Text = "Select Date:"' 
        ' weighingDt
        ' 
        weighingDt.BorderRadius = 5
        weighingDt.Checked = True
        weighingDt.CustomFormat = "MMMM yyyy"
        weighingDt.CustomizableEdges = CustomizableEdges1
        weighingDt.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        weighingDt.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        weighingDt.Format = DateTimePickerFormat.Custom
        weighingDt.Location = New Point(635, 47)
        weighingDt.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        weighingDt.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        weighingDt.Name = "weighingDt"
        weighingDt.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        weighingDt.Size = New Size(153, 25)
        weighingDt.TabIndex = 72
        weighingDt.Value = New DateTime(2023, 12, 11, 0, 0, 0, 0)
        ' 
        ' weighingDataGridView
        ' 
        weighingDataGridView.AllowUserToAddRows = False
        weighingDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        weighingDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        weighingDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        weighingDataGridView.ColumnHeadersHeight = 30
        weighingDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        weighingDataGridView.Columns.AddRange(New DataGridViewColumn() {ID, weighing_id, weight, weight_date})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        weighingDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        weighingDataGridView.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        weighingDataGridView.Location = New Point(12, 88)
        weighingDataGridView.Name = "weighingDataGridView"
        weighingDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        weighingDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        weighingDataGridView.RowHeadersVisible = False
        weighingDataGridView.RowTemplate.Height = 25
        weighingDataGridView.Size = New Size(776, 403)
        weighingDataGridView.TabIndex = 71
        weighingDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        weighingDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        weighingDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        weighingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        weighingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        weighingDataGridView.ThemeStyle.BackColor = Color.White
        weighingDataGridView.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        weighingDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        weighingDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        weighingDataGridView.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        weighingDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White
        weighingDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        weighingDataGridView.ThemeStyle.HeaderStyle.Height = 30
        weighingDataGridView.ThemeStyle.ReadOnly = True
        weighingDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White
        weighingDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        weighingDataGridView.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        weighingDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        weighingDataGridView.ThemeStyle.RowsStyle.Height = 25
        weighingDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        weighingDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' ID
        ' 
        ID.DataPropertyName = "birthing_id"
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Visible = False
        ' 
        ' weighing_id
        ' 
        weighing_id.DataPropertyName = "weighing_id"
        weighing_id.HeaderText = "ID"
        weighing_id.Name = "weighing_id"
        weighing_id.ReadOnly = True
        ' 
        ' weight
        ' 
        weight.DataPropertyName = "weight"
        weight.HeaderText = "Weight"
        weight.Name = "weight"
        weight.ReadOnly = True
        ' 
        ' weight_date
        ' 
        weight_date.DataPropertyName = "weight_date"
        weight_date.HeaderText = "Weighing Date"
        weight_date.Name = "weight_date"
        weight_date.ReadOnly = True
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(12, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(263, 27)
        Guna2HtmlLabel1.TabIndex = 70
        Guna2HtmlLabel1.Text = "Weighing Children History"' 
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
        Guna2ControlBox1.TabIndex = 74
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
        Guna2HtmlLabel3.Size = New Size(93, 19)
        Guna2HtmlLabel3.TabIndex = 90
        Guna2HtmlLabel3.Text = "Child's Name:"' 
        ' weighingChildrenView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(248), CByte(255))
        ClientSize = New Size(800, 520)
        Controls.Add(weighingDataGridView)
        Controls.Add(txtPatient)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(weighingDt)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(605, 55)
        Name = "weighingChildrenView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "weighingChildrenView"
        CType(weighingDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents weighingDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtPatient As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents weighing_id As DataGridViewTextBoxColumn
    Friend WithEvents birthing_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents weight As DataGridViewTextBoxColumn
    Friend WithEvents weight_date As DataGridViewTextBoxColumn
    Friend WithEvents weighingDt As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
