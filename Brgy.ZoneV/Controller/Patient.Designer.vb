<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
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
        PatientDataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        ID = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        contact = New DataGridViewTextBoxColumn()
        CType(PatientDataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PatientDataGridView1
        ' 
        PatientDataGridView1.AllowUserToAddRows = False
        PatientDataGridView1.AllowUserToDeleteRows = False
        PatientDataGridView1.AllowUserToResizeColumns = False
        PatientDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        PatientDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        PatientDataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        PatientDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        PatientDataGridView1.ColumnHeadersHeight = 30
        PatientDataGridView1.Columns.AddRange(New DataGridViewColumn() {ID, Column1, Column2, Column3, Column4, contact})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        PatientDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        PatientDataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        PatientDataGridView1.Location = New Point(19, 96)
        PatientDataGridView1.Name = "PatientDataGridView1"
        PatientDataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        PatientDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        PatientDataGridView1.RowHeadersVisible = False
        PatientDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        PatientDataGridView1.RowTemplate.Height = 25
        PatientDataGridView1.Size = New Size(746, 487)
        PatientDataGridView1.TabIndex = 10
        PatientDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        PatientDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        PatientDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        PatientDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        PatientDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        PatientDataGridView1.ThemeStyle.BackColor = Color.White
        PatientDataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        PatientDataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        PatientDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        PatientDataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PatientDataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        PatientDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        PatientDataGridView1.ThemeStyle.HeaderStyle.Height = 30
        PatientDataGridView1.ThemeStyle.ReadOnly = True
        PatientDataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        PatientDataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        PatientDataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PatientDataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        PatientDataGridView1.ThemeStyle.RowsStyle.Height = 25
        PatientDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        PatientDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.BorderRadius = 5
        txtSearch.CustomizableEdges = CustomizableEdges1
        txtSearch.DefaultText = ""
        txtSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearch.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.ForeColor = Color.Black
        txtSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearch.Location = New Point(545, 15)
        txtSearch.Name = "txtSearch"
        txtSearch.PasswordChar = ChrW(0)
        txtSearch.PlaceholderText = ""
        txtSearch.SelectedText = ""
        txtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtSearch.Size = New Size(220, 30)
        txtSearch.TabIndex = 9
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(19, 15)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(171, 30)
        Guna2HtmlLabel2.TabIndex = 16
        Guna2HtmlLabel2.Text = "Patient Record"' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.BorderRadius = 5
        btnAdd.CustomizableEdges = CustomizableEdges3
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.Black
        btnAdd.Location = New Point(684, 60)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnAdd.Size = New Size(81, 30)
        btnAdd.TabIndex = 17
        btnAdd.Text = "Add"' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(481, 17)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(58, 22)
        Guna2HtmlLabel1.TabIndex = 18
        Guna2HtmlLabel1.Text = "Search:"' 
        ' ID
        ' 
        ID.DataPropertyName = "patient_id"
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "Fullname"
        Column1.HeaderText = "Fullname"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "dob"
        Column2.HeaderText = "Date of Birth"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "gender"
        Column3.HeaderText = "Gender"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "Age"
        Column4.HeaderText = "Age"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' contact
        ' 
        contact.DataPropertyName = "contact"
        contact.HeaderText = "Contact Number"
        contact.Name = "contact"
        contact.ReadOnly = True
        ' 
        ' Patient
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(785, 605)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(btnAdd)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(PatientDataGridView1)
        Controls.Add(txtSearch)
        FormBorderStyle = FormBorderStyle.None
        Name = "Patient"
        Text = "Patient"
        CType(PatientDataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PatientDataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
End Class
