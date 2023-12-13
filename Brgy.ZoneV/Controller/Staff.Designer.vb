<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        StaffDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        id = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        CType(StaffDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(19, 15)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(142, 30)
        Guna2HtmlLabel1.TabIndex = 15
        Guna2HtmlLabel1.Text = "Staff Record"' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.BorderRadius = 5
        btnAdd.CustomizableEdges = CustomizableEdges1
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.Black
        btnAdd.Location = New Point(684, 60)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnAdd.Size = New Size(81, 30)
        btnAdd.TabIndex = 19
        btnAdd.Text = "Add"' 
        ' StaffDataGridView
        ' 
        StaffDataGridView.AllowUserToAddRows = False
        StaffDataGridView.AllowUserToDeleteRows = False
        StaffDataGridView.AllowUserToResizeColumns = False
        StaffDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        StaffDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        StaffDataGridView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        StaffDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        StaffDataGridView.ColumnHeadersHeight = 30
        StaffDataGridView.Columns.AddRange(New DataGridViewColumn() {id, Column1, Column2, Column3, Column4, Column5})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        StaffDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        StaffDataGridView.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        StaffDataGridView.Location = New Point(19, 94)
        StaffDataGridView.Name = "StaffDataGridView"
        StaffDataGridView.ReadOnly = True
        StaffDataGridView.RowHeadersVisible = False
        StaffDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        StaffDataGridView.RowTemplate.Height = 25
        StaffDataGridView.Size = New Size(746, 481)
        StaffDataGridView.TabIndex = 20
        StaffDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        StaffDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        StaffDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        StaffDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        StaffDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        StaffDataGridView.ThemeStyle.BackColor = Color.White
        StaffDataGridView.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        StaffDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        StaffDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        StaffDataGridView.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        StaffDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White
        StaffDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        StaffDataGridView.ThemeStyle.HeaderStyle.Height = 30
        StaffDataGridView.ThemeStyle.ReadOnly = True
        StaffDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White
        StaffDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        StaffDataGridView.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        StaffDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        StaffDataGridView.ThemeStyle.RowsStyle.Height = 25
        StaffDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        StaffDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' id
        ' 
        id.DataPropertyName = "staff_id"
        id.HeaderText = "ID"
        id.Name = "id"
        id.ReadOnly = True
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
        Column2.HeaderText = "DOB"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "gender_name"
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
        ' Column5
        ' 
        Column5.DataPropertyName = "role_name"
        Column5.HeaderText = "Role"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(481, 14)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(58, 22)
        Guna2HtmlLabel2.TabIndex = 22
        Guna2HtmlLabel2.Text = "Search:"' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.BorderRadius = 5
        txtSearch.CustomizableEdges = CustomizableEdges3
        txtSearch.DefaultText = ""
        txtSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearch.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.ForeColor = Color.Black
        txtSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearch.Location = New Point(545, 14)
        txtSearch.Name = "txtSearch"
        txtSearch.PasswordChar = ChrW(0)
        txtSearch.PlaceholderText = ""
        txtSearch.SelectedText = ""
        txtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtSearch.Size = New Size(220, 34)
        txtSearch.TabIndex = 21
        ' 
        ' Staff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(785, 605)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(txtSearch)
        Controls.Add(StaffDataGridView)
        Controls.Add(btnAdd)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Staff"
        CType(StaffDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents StaffDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
