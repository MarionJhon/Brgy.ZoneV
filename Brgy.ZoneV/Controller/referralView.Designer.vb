<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class referralView
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        referralViews = New Guna.UI2.WinForms.Guna2DataGridView()
        id = New DataGridViewTextBoxColumn()
        row_num = New DataGridViewTextBoxColumn()
        referral_date = New DataGridViewTextBoxColumn()
        reason = New DataGridViewTextBoxColumn()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        referralDt = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtPatient = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(referralViews, ComponentModel.ISupportInitialize).BeginInit()
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
        ' referralViews
        ' 
        referralViews.AllowUserToAddRows = False
        referralViews.AllowUserToDeleteRows = False
        referralViews.AllowUserToResizeColumns = False
        referralViews.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        referralViews.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        referralViews.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        referralViews.ColumnHeadersHeight = 30
        referralViews.Columns.AddRange(New DataGridViewColumn() {id, row_num, referral_date, reason})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        referralViews.DefaultCellStyle = DataGridViewCellStyle3
        referralViews.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        referralViews.Location = New Point(12, 88)
        referralViews.Name = "referralViews"
        referralViews.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        referralViews.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        referralViews.RowHeadersVisible = False
        referralViews.RowTemplate.Height = 25
        referralViews.Size = New Size(776, 403)
        referralViews.TabIndex = 81
        referralViews.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        referralViews.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        referralViews.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        referralViews.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        referralViews.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        referralViews.ThemeStyle.BackColor = Color.White
        referralViews.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        referralViews.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        referralViews.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        referralViews.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        referralViews.ThemeStyle.HeaderStyle.ForeColor = Color.White
        referralViews.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        referralViews.ThemeStyle.HeaderStyle.Height = 30
        referralViews.ThemeStyle.ReadOnly = True
        referralViews.ThemeStyle.RowsStyle.BackColor = Color.White
        referralViews.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        referralViews.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        referralViews.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        referralViews.ThemeStyle.RowsStyle.Height = 25
        referralViews.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        referralViews.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' id
        ' 
        id.DataPropertyName = "patient_id"
        id.HeaderText = "ID"
        id.Name = "id"
        id.ReadOnly = True
        id.Visible = False
        ' 
        ' row_num
        ' 
        row_num.DataPropertyName = "ID"
        row_num.HeaderText = "ID"
        row_num.Name = "row_num"
        row_num.ReadOnly = True
        ' 
        ' referral_date
        ' 
        referral_date.DataPropertyName = "referral_date"
        referral_date.HeaderText = "Referral Date"
        referral_date.Name = "referral_date"
        referral_date.ReadOnly = True
        ' 
        ' reason
        ' 
        reason.DataPropertyName = "reason_of_referral"
        reason.HeaderText = "Reason of Referral"
        reason.Name = "reason"
        reason.ReadOnly = True
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(12, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(152, 27)
        Guna2HtmlLabel1.TabIndex = 80
        Guna2HtmlLabel1.Text = "Referral History"' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox1.FillColor = SystemColors.Control
        Guna2ControlBox1.HoverState.FillColor = Color.Red
        Guna2ControlBox1.HoverState.IconColor = Color.Black
        Guna2ControlBox1.IconColor = Color.Gray
        Guna2ControlBox1.Location = New Point(774, 1)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox1.Size = New Size(25, 22)
        Guna2ControlBox1.TabIndex = 84
        ' 
        ' referralDt
        ' 
        referralDt.BorderRadius = 5
        referralDt.Checked = True
        referralDt.CustomFormat = " MMMM yyyy"
        referralDt.CustomizableEdges = CustomizableEdges3
        referralDt.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        referralDt.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        referralDt.Format = DateTimePickerFormat.Custom
        referralDt.Location = New Point(635, 47)
        referralDt.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        referralDt.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        referralDt.Name = "referralDt"
        referralDt.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        referralDt.Size = New Size(153, 25)
        referralDt.TabIndex = 85
        referralDt.Value = New DateTime(2023, 12, 3, 23, 51, 29, 307)
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(12, 63)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(97, 19)
        Guna2HtmlLabel3.TabIndex = 86
        Guna2HtmlLabel3.Text = "Patient Name:"' 
        ' txtPatient
        ' 
        txtPatient.BackColor = Color.Transparent
        txtPatient.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        txtPatient.Location = New Point(109, 63)
        txtPatient.Name = "txtPatient"
        txtPatient.Size = New Size(94, 18)
        txtPatient.TabIndex = 87
        txtPatient.Text = "Patient Name:"' 
        ' ReferralView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(248), CByte(255))
        ClientSize = New Size(800, 520)
        Controls.Add(txtPatient)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(referralDt)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(referralViews)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ReferralView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "referralView"
        CType(referralViews, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents selectDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents referralViews As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPatient As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents referral_id As DataGridViewTextBoxColumn
    Friend WithEvents patient_id As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents referral_date As DataGridViewTextBoxColumn
    Friend WithEvents reason As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents blood_id As DataGridViewTextBoxColumn
    Friend WithEvents row_num As DataGridViewTextBoxColumn
    Friend WithEvents referralDt As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
