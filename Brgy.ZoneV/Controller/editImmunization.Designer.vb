<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editImmunization
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        vaxTyp = New Guna.UI2.WinForms.Guna2ComboBox()
        dtVax = New Guna.UI2.WinForms.Guna2DateTimePicker()
        age = New Guna.UI2.WinForms.Guna2TextBox()
        childTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        gender = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        dob = New Guna.UI2.WinForms.Guna2DateTimePicker()
        prtTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' vaxTyp
        ' 
        vaxTyp.BackColor = Color.Transparent
        vaxTyp.BorderRadius = 5
        vaxTyp.CustomizableEdges = CustomizableEdges1
        vaxTyp.DrawMode = DrawMode.OwnerDrawFixed
        vaxTyp.DropDownStyle = ComboBoxStyle.DropDownList
        vaxTyp.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        vaxTyp.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        vaxTyp.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        vaxTyp.ForeColor = Color.Black
        vaxTyp.ItemHeight = 30
        vaxTyp.Items.AddRange(New Object() {"BCG (Bacillus Calmette-Guérin)", "Hepatitis B", "DTP (Diphtheria, Tetanus, Pertussis)", "OPV (Oral Polio Vaccine)", "IPV (Inactivated Polio Vaccine)", "MMR (Measles, Mumps, Rubella)", "Hib (Haemophilus influenzae type b)", "Varicella (Chickenpox)", "Hepatitis A", "Rotavirus", "Pneumococcal Conjugate (PCV)", "Meningococcal"})
        vaxTyp.Location = New Point(261, 225)
        vaxTyp.Name = "vaxTyp"
        vaxTyp.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        vaxTyp.Size = New Size(208, 36)
        vaxTyp.TabIndex = 94
        ' 
        ' dtVax
        ' 
        dtVax.BorderRadius = 5
        dtVax.Checked = True
        dtVax.CustomizableEdges = CustomizableEdges3
        dtVax.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        dtVax.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dtVax.Format = DateTimePickerFormat.Long
        dtVax.Location = New Point(261, 158)
        dtVax.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        dtVax.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        dtVax.Name = "dtVax"
        dtVax.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        dtVax.Size = New Size(208, 36)
        dtVax.TabIndex = 92
        dtVax.Value = New DateTime(2023, 11, 16, 22, 6, 11, 631)
        ' 
        ' age
        ' 
        age.BorderRadius = 5
        age.CustomizableEdges = CustomizableEdges5
        age.DefaultText = ""
        age.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        age.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        age.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        age.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        age.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        age.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        age.ForeColor = Color.Black
        age.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        age.Location = New Point(28, 292)
        age.Name = "age"
        age.PasswordChar = ChrW(0)
        age.PlaceholderText = ""
        age.ReadOnly = True
        age.SelectedText = ""
        age.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        age.Size = New Size(208, 36)
        age.TabIndex = 91
        ' 
        ' childTxt
        ' 
        childTxt.BorderRadius = 5
        childTxt.CustomizableEdges = CustomizableEdges7
        childTxt.DefaultText = ""
        childTxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        childTxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        childTxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        childTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        childTxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        childTxt.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        childTxt.ForeColor = Color.Black
        childTxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        childTxt.Location = New Point(28, 91)
        childTxt.Name = "childTxt"
        childTxt.PasswordChar = ChrW(0)
        childTxt.PlaceholderText = ""
        childTxt.ReadOnly = True
        childTxt.SelectedText = ""
        childTxt.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        childTxt.Size = New Size(208, 36)
        childTxt.TabIndex = 88
        ' 
        ' Guna2HtmlLabel10
        ' 
        Guna2HtmlLabel10.BackColor = Color.Transparent
        Guna2HtmlLabel10.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel10.Location = New Point(28, 200)
        Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Guna2HtmlLabel10.Size = New Size(55, 19)
        Guna2HtmlLabel10.TabIndex = 87
        Guna2HtmlLabel10.Text = "Gender:"' 
        ' Guna2HtmlLabel9
        ' 
        Guna2HtmlLabel9.BackColor = Color.Transparent
        Guna2HtmlLabel9.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel9.Location = New Point(28, 267)
        Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Guna2HtmlLabel9.Size = New Size(33, 19)
        Guna2HtmlLabel9.TabIndex = 86
        Guna2HtmlLabel9.Text = "Age:"' 
        ' Guna2HtmlLabel6
        ' 
        Guna2HtmlLabel6.BackColor = Color.Transparent
        Guna2HtmlLabel6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel6.Location = New Point(28, 133)
        Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Guna2HtmlLabel6.Size = New Size(87, 19)
        Guna2HtmlLabel6.TabIndex = 85
        Guna2HtmlLabel6.Text = "Date of Birth:"' 
        ' btnSave
        ' 
        btnSave.BorderRadius = 5
        btnSave.CustomizableEdges = CustomizableEdges9
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        btnSave.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(313, 426)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnSave.Size = New Size(180, 45)
        btnSave.TabIndex = 83
        btnSave.Text = "SAVE"' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel5.Location = New Point(261, 133)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(139, 19)
        Guna2HtmlLabel5.TabIndex = 82
        Guna2HtmlLabel5.Text = "Date of Vaccination:"' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel4.Location = New Point(28, 66)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(93, 19)
        Guna2HtmlLabel4.TabIndex = 81
        Guna2HtmlLabel4.Text = "Child's Name:"' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(261, 200)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(92, 19)
        Guna2HtmlLabel2.TabIndex = 79
        Guna2HtmlLabel2.Text = "Vaccine Type:"' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(12, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(242, 27)
        Guna2HtmlLabel1.TabIndex = 78
        Guna2HtmlLabel1.Text = "Edit Child Immunization"' 
        ' gender
        ' 
        gender.BorderRadius = 5
        gender.CustomizableEdges = CustomizableEdges11
        gender.DefaultText = ""
        gender.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        gender.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        gender.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        gender.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        gender.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        gender.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        gender.ForeColor = Color.Black
        gender.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        gender.Location = New Point(28, 225)
        gender.Name = "gender"
        gender.PasswordChar = ChrW(0)
        gender.PlaceholderText = ""
        gender.ReadOnly = True
        gender.SelectedText = ""
        gender.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        gender.Size = New Size(208, 36)
        gender.TabIndex = 97
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.BackColor = SystemColors.Control
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges13
        Guna2ControlBox1.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        Guna2ControlBox1.HoverState.FillColor = Color.Red
        Guna2ControlBox1.HoverState.IconColor = Color.Black
        Guna2ControlBox1.IconColor = Color.Black
        Guna2ControlBox1.Location = New Point(476, 0)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2ControlBox1.Size = New Size(29, 25)
        Guna2ControlBox1.TabIndex = 98
        ' 
        ' dob
        ' 
        dob.BorderRadius = 5
        dob.Checked = True
        dob.CustomizableEdges = CustomizableEdges15
        dob.FillColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        dob.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dob.Format = DateTimePickerFormat.Long
        dob.Location = New Point(28, 158)
        dob.MaxDate = New DateTime(9998, 12, 31, 0, 0, 0, 0)
        dob.MinDate = New DateTime(1753, 1, 1, 0, 0, 0, 0)
        dob.Name = "dob"
        dob.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        dob.Size = New Size(208, 36)
        dob.TabIndex = 99
        dob.Value = New DateTime(2023, 11, 16, 22, 6, 11, 631)
        ' 
        ' prtTxt
        ' 
        prtTxt.BorderRadius = 5
        prtTxt.CustomizableEdges = CustomizableEdges17
        prtTxt.DefaultText = ""
        prtTxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        prtTxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        prtTxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        prtTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        prtTxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        prtTxt.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        prtTxt.ForeColor = Color.Black
        prtTxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        prtTxt.Location = New Point(260, 91)
        prtTxt.Name = "prtTxt"
        prtTxt.PasswordChar = ChrW(0)
        prtTxt.PlaceholderText = ""
        prtTxt.ReadOnly = True
        prtTxt.SelectedText = ""
        prtTxt.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        prtTxt.Size = New Size(208, 36)
        prtTxt.TabIndex = 101
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(260, 66)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(98, 19)
        Guna2HtmlLabel3.TabIndex = 100
        Guna2HtmlLabel3.Text = "Parents Name:"' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(505, 50)
        Panel1.TabIndex = 102
        ' 
        ' editImmunization
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(248), CByte(255))
        ClientSize = New Size(505, 483)
        Controls.Add(prtTxt)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(dob)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(gender)
        Controls.Add(vaxTyp)
        Controls.Add(dtVax)
        Controls.Add(age)
        Controls.Add(childTxt)
        Controls.Add(Guna2HtmlLabel10)
        Controls.Add(Guna2HtmlLabel9)
        Controls.Add(Guna2HtmlLabel6)
        Controls.Add(btnSave)
        Controls.Add(Guna2HtmlLabel5)
        Controls.Add(Guna2HtmlLabel4)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "editImmunization"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "editImmunization"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2ComboBox3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents vaxTyp As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtVax As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents age As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents patientTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents gender As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents dob As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents prtTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents childTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
End Class
