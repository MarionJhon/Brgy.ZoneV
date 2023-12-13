<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bloodPressureView
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
        bloodDt = New Guna.UI2.WinForms.Guna2DateTimePicker()
        bloodDatagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        ID = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        blood_date = New DataGridViewTextBoxColumn()
        blood_reading = New DataGridViewTextBoxColumn()
        pulse = New DataGridViewTextBoxColumn()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        txtPatient = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(bloodDatagrid, ComponentModel.ISupportInitialize).BeginInit()
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
        ' bloodDt
        ' 
        bloodDt.BorderRadius = 5
        bloodDt.Checked = True
        bloodDt.CustomFormat = "MMMM yyyy"
        bloodDt.CustomizableEdges = CustomizableEdges1
        bloodDt.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        bloodDt.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bloodDt.Format = DateTimePickerFormat.Custom
        bloodDt.Location = New Point(635, 47)
        bloodDt.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        bloodDt.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        bloodDt.Name = "bloodDt"
        bloodDt.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        bloodDt.Size = New Size(153, 25)
        bloodDt.TabIndex = 82
        bloodDt.Value = New DateTime(2023, 12, 10, 16, 55, 24, 0)
        ' 
        ' bloodDatagrid
        ' 
        bloodDatagrid.AllowUserToAddRows = False
        bloodDatagrid.AllowUserToDeleteRows = False
        bloodDatagrid.AllowUserToResizeColumns = False
        bloodDatagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        bloodDatagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        bloodDatagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        bloodDatagrid.ColumnHeadersHeight = 30
        bloodDatagrid.Columns.AddRange(New DataGridViewColumn() {ID, DataGridViewTextBoxColumn1, blood_date, blood_reading, pulse})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        bloodDatagrid.DefaultCellStyle = DataGridViewCellStyle3
        bloodDatagrid.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        bloodDatagrid.Location = New Point(12, 88)
        bloodDatagrid.Name = "bloodDatagrid"
        bloodDatagrid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        bloodDatagrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        bloodDatagrid.RowHeadersVisible = False
        bloodDatagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        bloodDatagrid.RowTemplate.Height = 25
        bloodDatagrid.Size = New Size(776, 403)
        bloodDatagrid.TabIndex = 81
        bloodDatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        bloodDatagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        bloodDatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        bloodDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        bloodDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        bloodDatagrid.ThemeStyle.BackColor = Color.White
        bloodDatagrid.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        bloodDatagrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        bloodDatagrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        bloodDatagrid.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bloodDatagrid.ThemeStyle.HeaderStyle.ForeColor = Color.White
        bloodDatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        bloodDatagrid.ThemeStyle.HeaderStyle.Height = 30
        bloodDatagrid.ThemeStyle.ReadOnly = True
        bloodDatagrid.ThemeStyle.RowsStyle.BackColor = Color.White
        bloodDatagrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        bloodDatagrid.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bloodDatagrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        bloodDatagrid.ThemeStyle.RowsStyle.Height = 25
        bloodDatagrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        bloodDatagrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' ID
        ' 
        ID.DataPropertyName = "patient_id"
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Visible = False
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        DataGridViewTextBoxColumn1.HeaderText = "ID"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        ' 
        ' blood_date
        ' 
        blood_date.DataPropertyName = "blood_date"
        blood_date.HeaderText = "Blood Date"
        blood_date.Name = "blood_date"
        blood_date.ReadOnly = True
        ' 
        ' blood_reading
        ' 
        blood_reading.DataPropertyName = "blood_reading"
        blood_reading.HeaderText = "Blood Reading"
        blood_reading.Name = "blood_reading"
        blood_reading.ReadOnly = True
        ' 
        ' pulse
        ' 
        pulse.DataPropertyName = "pulse"
        pulse.HeaderText = "Pulse"
        pulse.Name = "pulse"
        pulse.ReadOnly = True
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(12, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(221, 27)
        Guna2HtmlLabel1.TabIndex = 80
        Guna2HtmlLabel1.Text = "Blood Pressure History"' 
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
        txtPatient.TabIndex = 89
        txtPatient.Text = "Patient Name:"' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(12, 63)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(97, 19)
        Guna2HtmlLabel3.TabIndex = 88
        Guna2HtmlLabel3.Text = "Patient Name:"' 
        ' bloodPressureView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(248), CByte(255))
        ClientSize = New Size(800, 520)
        Controls.Add(txtPatient)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(bloodDt)
        Controls.Add(bloodDatagrid)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "bloodPressureView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "bloodPressureView"
        CType(bloodDatagrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents bloodDatagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtPatient As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents blood_date As DataGridViewTextBoxColumn
    Friend WithEvents blood_reading As DataGridViewTextBoxColumn
    Friend WithEvents pulse As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents bloodDt As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
