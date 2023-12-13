<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(login))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        loginBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Panel1.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(66), CByte(133), CByte(91))
        Panel1.Controls.Add(IconPictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 451)
        Panel1.TabIndex = 0
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.FromArgb(CByte(66), CByte(133), CByte(91))
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HospitalWide
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 175
        IconPictureBox1.Location = New Point(113, 61)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(175, 175)
        IconPictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        IconPictureBox1.TabIndex = 3
        IconPictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(152, 338)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 28)
        Label3.TabIndex = 2
        Label3.Text = "SYSTEM"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(24, 293)
        Label2.Name = "Label2"
        Label2.Size = New Size(355, 28)
        Label2.TabIndex = 1
        Label2.Text = "INFORMATION MANAGEMENT"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(22, 246)
        Label1.Name = "Label1"
        Label1.Size = New Size(357, 28)
        Label1.TabIndex = 0
        Label1.Text = "BRGY. ZONE V HEALTH CENTER"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(517, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(169, 30)
        Label4.TabIndex = 1
        Label4.Text = "Administrator"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(439, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 17)
        Label5.TabIndex = 2
        Label5.Text = "Username:"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(439, 219)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 17)
        Label6.TabIndex = 3
        Label6.Text = "Password:"' 
        ' txtUsername
        ' 
        txtUsername.BorderRadius = 5
        txtUsername.CustomizableEdges = CustomizableEdges1
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.ForeColor = Color.Black
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.IconLeft = CType(resources.GetObject("txtUsername.IconLeft"), Image)
        txtUsername.Location = New Point(441, 170)
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = ChrW(0)
        txtUsername.PlaceholderText = "Username"
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtUsername.Size = New Size(320, 36)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderRadius = 5
        txtPassword.CustomizableEdges = CustomizableEdges3
        txtPassword.DefaultText = ""
        txtPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.ForeColor = Color.Black
        txtPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.IconLeft = CType(resources.GetObject("txtPassword.IconLeft"), Image)
        txtPassword.IconRight = My.Resources.Resources.icons8_hide_password_24
        txtPassword.Location = New Point(441, 239)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtPassword.Size = New Size(320, 36)
        txtPassword.TabIndex = 5
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges5
        Guna2ControlBox1.FillColor = Color.FromArgb(CByte(92), CByte(131), CByte(116))
        Guna2ControlBox1.HoverState.FillColor = Color.Red
        Guna2ControlBox1.IconColor = Color.Black
        Guna2ControlBox1.Location = New Point(771, 0)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2ControlBox1.Size = New Size(29, 27)
        Guna2ControlBox1.TabIndex = 7
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges7
        Guna2ControlBox2.FillColor = Color.FromArgb(CByte(92), CByte(131), CByte(116))
        Guna2ControlBox2.HoverState.FillColor = Color.Transparent
        Guna2ControlBox2.IconColor = Color.Black
        Guna2ControlBox2.Location = New Point(741, 0)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2ControlBox2.Size = New Size(29, 27)
        Guna2ControlBox2.TabIndex = 8
        ' 
        ' loginBtn
        ' 
        loginBtn.BorderRadius = 20
        loginBtn.CustomizableEdges = CustomizableEdges9
        loginBtn.DisabledState.BorderColor = Color.DarkGray
        loginBtn.DisabledState.CustomBorderColor = Color.DarkGray
        loginBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        loginBtn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        loginBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        loginBtn.FillColor = Color.FromArgb(CByte(206), CByte(222), CByte(189))
        loginBtn.FillColor2 = Color.FromArgb(CByte(158), CByte(179), CByte(132))
        loginBtn.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        loginBtn.ForeColor = Color.WhiteSmoke
        loginBtn.Location = New Point(517, 293)
        loginBtn.Name = "loginBtn"
        loginBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        loginBtn.Size = New Size(180, 45)
        loginBtn.TabIndex = 9
        loginBtn.Text = "LOGIN"' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(92), CByte(131), CByte(116))
        ClientSize = New Size(800, 450)
        Controls.Add(loginBtn)
        Controls.Add(Guna2ControlBox2)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents loginBtn As Guna.UI2.WinForms.Guna2GradientButton
End Class
