<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(home))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        logOutBn = New FontAwesome.Sharp.IconButton()
        staffBtn = New FontAwesome.Sharp.IconButton()
        Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        immunizationBtn = New FontAwesome.Sharp.IconButton()
        weighingChildrenBtn = New FontAwesome.Sharp.IconButton()
        birthingServicesBtn = New FontAwesome.Sharp.IconButton()
        pregnantProgressBtn = New FontAwesome.Sharp.IconButton()
        bloodPressureRecordsBtn = New FontAwesome.Sharp.IconButton()
        referralFormBtn = New FontAwesome.Sharp.IconButton()
        ServicesBtn = New FontAwesome.Sharp.IconButton()
        addPatient = New FontAwesome.Sharp.IconButton()
        dashBoardBtn = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        lblTxt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        mainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        GunaBubbleDataset1 = New Guna.Charts.WinForms.GunaBubbleDataset()
        IconDropDownButton1 = New FontAwesome.Sharp.IconDropDownButton()
        IconDropDownButton2 = New FontAwesome.Sharp.IconDropDownButton()
        IconMenuItem1 = New FontAwesome.Sharp.IconMenuItem()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(66), CByte(133), CByte(91))
        Panel1.Controls.Add(IconButton1)
        Panel1.Controls.Add(logOutBn)
        Panel1.Controls.Add(staffBtn)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(ServicesBtn)
        Panel1.Controls.Add(addPatient)
        Panel1.Controls.Add(dashBoardBtn)
        Panel1.Controls.Add(PanelLogo)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(235, 662)
        Panel1.TabIndex = 0
        ' 
        ' IconButton1
        ' 
        IconButton1.Dock = DockStyle.Top
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton1.ForeColor = Color.Black
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.FileText
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 32
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(0, 568)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New Padding(10, 0, 20, 0)
        IconButton1.Size = New Size(235, 45)
        IconButton1.TabIndex = 23
        IconButton1.Text = "Report"
        IconButton1.TextAlign = ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' logOutBn
        ' 
        logOutBn.Dock = DockStyle.Bottom
        logOutBn.FlatAppearance.BorderSize = 0
        logOutBn.FlatStyle = FlatStyle.Flat
        logOutBn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        logOutBn.ForeColor = Color.Black
        logOutBn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        logOutBn.IconColor = Color.Black
        logOutBn.IconFont = FontAwesome.Sharp.IconFont.Auto
        logOutBn.IconSize = 32
        logOutBn.ImageAlign = ContentAlignment.MiddleLeft
        logOutBn.Location = New Point(0, 617)
        logOutBn.Name = "logOutBn"
        logOutBn.Padding = New Padding(60, 0, 0, 0)
        logOutBn.Size = New Size(235, 45)
        logOutBn.TabIndex = 22
        logOutBn.Text = "Log-out"
        logOutBn.TextAlign = ContentAlignment.MiddleLeft
        logOutBn.TextImageRelation = TextImageRelation.ImageBeforeText
        logOutBn.UseVisualStyleBackColor = True
        ' 
        ' staffBtn
        ' 
        staffBtn.Dock = DockStyle.Top
        staffBtn.FlatAppearance.BorderSize = 0
        staffBtn.FlatStyle = FlatStyle.Flat
        staffBtn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        staffBtn.ForeColor = Color.Black
        staffBtn.IconChar = FontAwesome.Sharp.IconChar.UserNurse
        staffBtn.IconColor = Color.Black
        staffBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        staffBtn.IconSize = 32
        staffBtn.ImageAlign = ContentAlignment.MiddleLeft
        staffBtn.Location = New Point(0, 523)
        staffBtn.Name = "staffBtn"
        staffBtn.Padding = New Padding(10, 0, 20, 0)
        staffBtn.Size = New Size(235, 45)
        staffBtn.TabIndex = 21
        staffBtn.Text = "Add Staff"
        staffBtn.TextAlign = ContentAlignment.MiddleLeft
        staffBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        staffBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        Panel3.Controls.Add(immunizationBtn)
        Panel3.Controls.Add(weighingChildrenBtn)
        Panel3.Controls.Add(birthingServicesBtn)
        Panel3.Controls.Add(pregnantProgressBtn)
        Panel3.Controls.Add(bloodPressureRecordsBtn)
        Panel3.Controls.Add(referralFormBtn)
        Panel3.CustomizableEdges = CustomizableEdges1
        Panel3.Dock = DockStyle.Top
        Panel3.FillColor = Color.SeaGreen
        Panel3.Location = New Point(0, 251)
        Panel3.Name = "Panel3"
        Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Panel3.Size = New Size(235, 272)
        Panel3.TabIndex = 20
        Panel3.Visible = False
        ' 
        ' immunizationBtn
        ' 
        immunizationBtn.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        immunizationBtn.Dock = DockStyle.Top
        immunizationBtn.FlatAppearance.BorderSize = 0
        immunizationBtn.FlatStyle = FlatStyle.Flat
        immunizationBtn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        immunizationBtn.ForeColor = Color.Black
        immunizationBtn.IconChar = FontAwesome.Sharp.IconChar.Syringe
        immunizationBtn.IconColor = Color.Black
        immunizationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        immunizationBtn.IconSize = 32
        immunizationBtn.ImageAlign = ContentAlignment.MiddleLeft
        immunizationBtn.Location = New Point(0, 225)
        immunizationBtn.Name = "immunizationBtn"
        immunizationBtn.Padding = New Padding(20, 0, 20, 0)
        immunizationBtn.Size = New Size(235, 45)
        immunizationBtn.TabIndex = 5
        immunizationBtn.Text = "Immunization"
        immunizationBtn.TextAlign = ContentAlignment.MiddleLeft
        immunizationBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        immunizationBtn.UseVisualStyleBackColor = False
        ' 
        ' weighingChildrenBtn
        ' 
        weighingChildrenBtn.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        weighingChildrenBtn.Dock = DockStyle.Top
        weighingChildrenBtn.FlatAppearance.BorderSize = 0
        weighingChildrenBtn.FlatStyle = FlatStyle.Flat
        weighingChildrenBtn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        weighingChildrenBtn.ForeColor = Color.Black
        weighingChildrenBtn.IconChar = FontAwesome.Sharp.IconChar.Weight
        weighingChildrenBtn.IconColor = Color.Black
        weighingChildrenBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        weighingChildrenBtn.IconSize = 32
        weighingChildrenBtn.ImageAlign = ContentAlignment.MiddleLeft
        weighingChildrenBtn.Location = New Point(0, 180)
        weighingChildrenBtn.Name = "weighingChildrenBtn"
        weighingChildrenBtn.Padding = New Padding(20, 0, 20, 0)
        weighingChildrenBtn.Size = New Size(235, 45)
        weighingChildrenBtn.TabIndex = 4
        weighingChildrenBtn.Text = "Weighing Children"
        weighingChildrenBtn.TextAlign = ContentAlignment.MiddleLeft
        weighingChildrenBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        weighingChildrenBtn.UseVisualStyleBackColor = False
        ' 
        ' birthingServicesBtn
        ' 
        birthingServicesBtn.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        birthingServicesBtn.Dock = DockStyle.Top
        birthingServicesBtn.FlatAppearance.BorderSize = 0
        birthingServicesBtn.FlatStyle = FlatStyle.Flat
        birthingServicesBtn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        birthingServicesBtn.ForeColor = Color.Black
        birthingServicesBtn.IconChar = FontAwesome.Sharp.IconChar.Bed
        birthingServicesBtn.IconColor = Color.Black
        birthingServicesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        birthingServicesBtn.IconSize = 32
        birthingServicesBtn.ImageAlign = ContentAlignment.MiddleLeft
        birthingServicesBtn.Location = New Point(0, 135)
        birthingServicesBtn.Name = "birthingServicesBtn"
        birthingServicesBtn.Padding = New Padding(20, 0, 20, 0)
        birthingServicesBtn.Size = New Size(235, 45)
        birthingServicesBtn.TabIndex = 3
        birthingServicesBtn.Text = "Birthing Services"
        birthingServicesBtn.TextAlign = ContentAlignment.MiddleLeft
        birthingServicesBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        birthingServicesBtn.UseVisualStyleBackColor = False
        ' 
        ' pregnantProgressBtn
        ' 
        pregnantProgressBtn.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        pregnantProgressBtn.Dock = DockStyle.Top
        pregnantProgressBtn.FlatAppearance.BorderSize = 0
        pregnantProgressBtn.FlatStyle = FlatStyle.Flat
        pregnantProgressBtn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        pregnantProgressBtn.ForeColor = Color.Black
        pregnantProgressBtn.IconChar = FontAwesome.Sharp.IconChar.PersonPregnant
        pregnantProgressBtn.IconColor = Color.Black
        pregnantProgressBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        pregnantProgressBtn.IconSize = 32
        pregnantProgressBtn.ImageAlign = ContentAlignment.MiddleLeft
        pregnantProgressBtn.Location = New Point(0, 90)
        pregnantProgressBtn.Name = "pregnantProgressBtn"
        pregnantProgressBtn.Padding = New Padding(20, 0, 20, 0)
        pregnantProgressBtn.Size = New Size(235, 45)
        pregnantProgressBtn.TabIndex = 2
        pregnantProgressBtn.Text = "Pregnant"
        pregnantProgressBtn.TextAlign = ContentAlignment.MiddleLeft
        pregnantProgressBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        pregnantProgressBtn.UseVisualStyleBackColor = False
        ' 
        ' bloodPressureRecordsBtn
        ' 
        bloodPressureRecordsBtn.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        bloodPressureRecordsBtn.Dock = DockStyle.Top
        bloodPressureRecordsBtn.FlatAppearance.BorderSize = 0
        bloodPressureRecordsBtn.FlatStyle = FlatStyle.Flat
        bloodPressureRecordsBtn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        bloodPressureRecordsBtn.ForeColor = Color.Black
        bloodPressureRecordsBtn.IconChar = FontAwesome.Sharp.IconChar.Droplet
        bloodPressureRecordsBtn.IconColor = Color.Black
        bloodPressureRecordsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        bloodPressureRecordsBtn.IconSize = 32
        bloodPressureRecordsBtn.ImageAlign = ContentAlignment.MiddleLeft
        bloodPressureRecordsBtn.Location = New Point(0, 45)
        bloodPressureRecordsBtn.Name = "bloodPressureRecordsBtn"
        bloodPressureRecordsBtn.Padding = New Padding(20, 0, 20, 0)
        bloodPressureRecordsBtn.Size = New Size(235, 45)
        bloodPressureRecordsBtn.TabIndex = 1
        bloodPressureRecordsBtn.Text = "Blood Pressure"
        bloodPressureRecordsBtn.TextAlign = ContentAlignment.MiddleLeft
        bloodPressureRecordsBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        bloodPressureRecordsBtn.UseVisualStyleBackColor = False
        ' 
        ' referralFormBtn
        ' 
        referralFormBtn.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        referralFormBtn.Dock = DockStyle.Top
        referralFormBtn.FlatAppearance.BorderSize = 0
        referralFormBtn.FlatStyle = FlatStyle.Flat
        referralFormBtn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        referralFormBtn.ForeColor = Color.Black
        referralFormBtn.IconChar = FontAwesome.Sharp.IconChar.Newspaper
        referralFormBtn.IconColor = Color.Black
        referralFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        referralFormBtn.IconSize = 32
        referralFormBtn.ImageAlign = ContentAlignment.MiddleLeft
        referralFormBtn.Location = New Point(0, 0)
        referralFormBtn.Name = "referralFormBtn"
        referralFormBtn.Padding = New Padding(20, 0, 20, 0)
        referralFormBtn.Size = New Size(235, 45)
        referralFormBtn.TabIndex = 0
        referralFormBtn.Text = "Referral "
        referralFormBtn.TextAlign = ContentAlignment.MiddleLeft
        referralFormBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        referralFormBtn.UseVisualStyleBackColor = False
        ' 
        ' ServicesBtn
        ' 
        ServicesBtn.Dock = DockStyle.Top
        ServicesBtn.FlatAppearance.BorderSize = 0
        ServicesBtn.FlatStyle = FlatStyle.Flat
        ServicesBtn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        ServicesBtn.ForeColor = Color.Black
        ServicesBtn.IconChar = FontAwesome.Sharp.IconChar.BellConcierge
        ServicesBtn.IconColor = Color.Black
        ServicesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        ServicesBtn.IconSize = 32
        ServicesBtn.ImageAlign = ContentAlignment.MiddleLeft
        ServicesBtn.Location = New Point(0, 206)
        ServicesBtn.Name = "ServicesBtn"
        ServicesBtn.Padding = New Padding(10, 0, 20, 0)
        ServicesBtn.Size = New Size(235, 45)
        ServicesBtn.TabIndex = 19
        ServicesBtn.Text = "Services"
        ServicesBtn.TextAlign = ContentAlignment.MiddleLeft
        ServicesBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        ServicesBtn.UseVisualStyleBackColor = True
        ' 
        ' addPatient
        ' 
        addPatient.Dock = DockStyle.Top
        addPatient.FlatAppearance.BorderSize = 0
        addPatient.FlatStyle = FlatStyle.Flat
        addPatient.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        addPatient.ForeColor = Color.Black
        addPatient.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus
        addPatient.IconColor = Color.Black
        addPatient.IconFont = FontAwesome.Sharp.IconFont.Auto
        addPatient.IconSize = 32
        addPatient.ImageAlign = ContentAlignment.MiddleLeft
        addPatient.Location = New Point(0, 161)
        addPatient.Name = "addPatient"
        addPatient.Padding = New Padding(10, 0, 20, 0)
        addPatient.Size = New Size(235, 45)
        addPatient.TabIndex = 18
        addPatient.Text = "Add Patient"
        addPatient.TextAlign = ContentAlignment.MiddleLeft
        addPatient.TextImageRelation = TextImageRelation.ImageBeforeText
        addPatient.UseVisualStyleBackColor = True
        ' 
        ' dashBoardBtn
        ' 
        dashBoardBtn.Dock = DockStyle.Top
        dashBoardBtn.FlatAppearance.BorderSize = 0
        dashBoardBtn.FlatStyle = FlatStyle.Flat
        dashBoardBtn.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        dashBoardBtn.ForeColor = Color.Black
        dashBoardBtn.IconChar = FontAwesome.Sharp.IconChar.Dashboard
        dashBoardBtn.IconColor = Color.Black
        dashBoardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto
        dashBoardBtn.IconSize = 32
        dashBoardBtn.ImageAlign = ContentAlignment.MiddleLeft
        dashBoardBtn.Location = New Point(0, 116)
        dashBoardBtn.Name = "dashBoardBtn"
        dashBoardBtn.Padding = New Padding(10, 0, 20, 0)
        dashBoardBtn.Size = New Size(235, 45)
        dashBoardBtn.TabIndex = 17
        dashBoardBtn.Text = "Dashbord"
        dashBoardBtn.TextAlign = ContentAlignment.MiddleLeft
        dashBoardBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        dashBoardBtn.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(Guna2HtmlLabel1)
        PanelLogo.Controls.Add(PictureBox1)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(235, 116)
        PanelLogo.TabIndex = 16
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(53, 78)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(126, 25)
        Guna2HtmlLabel1.TabIndex = 1
        Guna2HtmlLabel1.Text = "Administrator" ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(82, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(57, 52)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(144), CByte(183), CByte(125))
        Panel4.Controls.Add(IconCurrentForm)
        Panel4.Controls.Add(Guna2ControlBox3)
        Panel4.Controls.Add(Guna2ControlBox2)
        Panel4.Controls.Add(Guna2ControlBox1)
        Panel4.Controls.Add(lblTxt)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(235, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(785, 57)
        Panel4.TabIndex = 1
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.Transparent
        IconCurrentForm.ForeColor = SystemColors.ControlText
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HospitalWide
        IconCurrentForm.IconColor = SystemColors.ControlText
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.IconSize = 46
        IconCurrentForm.Location = New Point(6, 5)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(52, 46)
        IconCurrentForm.SizeMode = PictureBoxSizeMode.CenterImage
        IconCurrentForm.TabIndex = 15
        IconCurrentForm.TabStop = False
        ' 
        ' Guna2ControlBox3
        ' 
        Guna2ControlBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox3.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox3.FillColor = Color.Transparent
        Guna2ControlBox3.HoverState.FillColor = Color.Gray
        Guna2ControlBox3.HoverState.IconColor = Color.White
        Guna2ControlBox3.IconColor = Color.Black
        Guna2ControlBox3.Location = New Point(697, 1)
        Guna2ControlBox3.Name = "Guna2ControlBox3"
        Guna2ControlBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox3.Size = New Size(27, 24)
        Guna2ControlBox3.TabIndex = 13
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges5
        Guna2ControlBox2.FillColor = Color.Transparent
        Guna2ControlBox2.HoverState.FillColor = Color.Gray
        Guna2ControlBox2.HoverState.IconColor = Color.White
        Guna2ControlBox2.IconColor = Color.Black
        Guna2ControlBox2.Location = New Point(728, 1)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2ControlBox2.Size = New Size(27, 24)
        Guna2ControlBox2.TabIndex = 12
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges7
        Guna2ControlBox1.FillColor = Color.Transparent
        Guna2ControlBox1.HoverState.FillColor = Color.Red
        Guna2ControlBox1.HoverState.IconColor = Color.Black
        Guna2ControlBox1.IconColor = Color.Black
        Guna2ControlBox1.Location = New Point(757, 1)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2ControlBox1.Size = New Size(27, 24)
        Guna2ControlBox1.TabIndex = 11
        ' 
        ' lblTxt
        ' 
        lblTxt.BackColor = Color.Transparent
        lblTxt.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTxt.Location = New Point(64, 20)
        lblTxt.Name = "lblTxt"
        lblTxt.Size = New Size(446, 22)
        lblTxt.TabIndex = 3
        lblTxt.Text = "Brgy. Zone V Health Center Information Management System" ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(243), CByte(248), CByte(255))
        mainPanel.Controls.Add(Guna2HtmlLabel4)
        mainPanel.Controls.Add(Guna2HtmlLabel3)
        mainPanel.CustomizableEdges = CustomizableEdges9
        mainPanel.Dock = DockStyle.Fill
        mainPanel.Location = New Point(235, 57)
        mainPanel.Name = "mainPanel"
        mainPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        mainPanel.Size = New Size(785, 605)
        mainPanel.TabIndex = 2
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel4.Location = New Point(351, 127)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(93, 22)
        Guna2HtmlLabel4.TabIndex = 14
        Guna2HtmlLabel4.Text = "Welcome to" ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(174, 172)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(446, 22)
        Guna2HtmlLabel3.TabIndex = 13
        Guna2HtmlLabel3.Text = "Brgy. Zone V Health Center Information Management System" ' 
        ' GunaBubbleDataset1
        ' 
        GunaBubbleDataset1.Label = "Bubble1"
        GunaBubbleDataset1.PointStyle = Guna.Charts.WinForms.PointStyle.Circle
        GunaBubbleDataset1.Rotation = 0
        ' 
        ' IconDropDownButton1
        ' 
        IconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconDropDownButton1.IconColor = Color.Black
        IconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconDropDownButton1.Name = "IconDropDownButton1"
        IconDropDownButton1.Size = New Size(23, 23)
        IconDropDownButton1.Text = "IconDropDownButton1" ' 
        ' IconDropDownButton2
        ' 
        IconDropDownButton2.IconChar = FontAwesome.Sharp.IconChar.None
        IconDropDownButton2.IconColor = Color.Black
        IconDropDownButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconDropDownButton2.Name = "IconDropDownButton2"
        IconDropDownButton2.Size = New Size(23, 23)
        IconDropDownButton2.Text = "IconDropDownButton2" ' 
        ' IconMenuItem1
        ' 
        IconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None
        IconMenuItem1.IconColor = Color.Black
        IconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconMenuItem1.Name = "IconMenuItem1"
        IconMenuItem1.Size = New Size(32, 19)
        IconMenuItem1.Text = "IconMenuItem1" ' 
        ' home
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1020, 662)
        Controls.Add(mainPanel)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "home"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        PanelLogo.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents s As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button9 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button11 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button10 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTxt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents mainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GunaBubbleDataset1 As Guna.Charts.WinForms.GunaBubbleDataset
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pregnantProgressBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents bloodPressureRecordsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents referralFormBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents ServicesBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents addPatient As FontAwesome.Sharp.IconButton
    Friend WithEvents dashBoardBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents IconDropDownButton1 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents IconDropDownButton2 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents IconMenuItem1 As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents immunizationBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents weighingChildrenBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents birthingServicesBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents logOutBn As FontAwesome.Sharp.IconButton
    Friend WithEvents staffBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
