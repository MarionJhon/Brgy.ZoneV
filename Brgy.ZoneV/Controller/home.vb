Imports FontAwesome.Sharp
Public Class home

    Private currentBtn As IconButton
    Private currentBtn1 As IconButton
    Private leftBorderBtn As Panel
    Private leftBorderBtn1 As Panel


    Sub childForm(ByVal panel As Form)
        mainPanel.Controls.Clear()

        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        mainPanel.Controls.Add(panel)
        panel.Dock = DockStyle.Fill
        panel.BringToFront()
        panel.Show()
    End Sub

    Private username As String

    Public Sub New(ByVal users As String)
        InitializeComponent()
        username = users
        If String.Compare(username, "admin", StringComparison.OrdinalIgnoreCase) <> 0 Then
            staffBtn.Visible = False
        End If

        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 45)
        leftBorderBtn1 = New Panel()
        leftBorderBtn1.Size = New Size(7, 45)
        Panel1.Controls.Add(leftBorderBtn)
        Panel3.Controls.Add(leftBorderBtn1)
    End Sub

    Private Sub ActiveButton(senderBtn As Object, customerColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            DisableButton1()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(27, 66, 66)
            currentBtn.ForeColor = customerColor
            currentBtn.IconColor = customerColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn.BackColor = customerColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub

    Private Sub ActiveButton1(senderBtn1 As Object, customerColor1 As Color)
        If senderBtn1 IsNot Nothing Then
            DisableButton1()
            DisableButton()
            currentBtn1 = CType(senderBtn1, IconButton)
            currentBtn1.BackColor = Color.FromArgb(27, 66, 66)
            currentBtn1.ForeColor = customerColor1
            currentBtn1.IconColor = customerColor1
            currentBtn1.TextAlign = ContentAlignment.MiddleCenter
            currentBtn1.ImageAlign = ContentAlignment.MiddleRight
            currentBtn1.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn1.BackColor = customerColor1
            leftBorderBtn1.Location = New Point(0, currentBtn1.Location.Y)
            leftBorderBtn1.Visible = True
            leftBorderBtn1.BringToFront()
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            leftBorderBtn.Visible = False
            currentBtn.BackColor = Color.FromArgb(66, 133, 91)
            currentBtn.ForeColor = Color.Black
            currentBtn.IconColor = Color.Black
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub DisableButton1()
        If currentBtn1 IsNot Nothing Then
            leftBorderBtn1.Visible = False
            currentBtn1.BackColor = Color.FromArgb(144, 183, 125)
            currentBtn1.ForeColor = Color.Black
            currentBtn1.IconColor = Color.Black
            currentBtn1.TextAlign = ContentAlignment.MiddleLeft
            currentBtn1.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn1.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub home_Load(sender As Object, e As EventArgs)
        Panel3.Visible = False
    End Sub

    Private Sub addPatient_Click_1(sender As Object, e As EventArgs) Handles addPatient.Click
        childForm(Patient)
        ActiveButton(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub ServicesBtn_Click_1(sender As Object, e As EventArgs) Handles ServicesBtn.Click
        If Panel3.Visible = False Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If
        ActiveButton(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub referralFormBtn_Click_1(sender As Object, e As EventArgs) Handles referralFormBtn.Click
        childForm(referralForm)
        ActiveButton1(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub bloodPressureRecordsBtn_Click(sender As Object, e As EventArgs) Handles bloodPressureRecordsBtn.Click
        childForm(bloodPressureRecord)
        ActiveButton1(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub pregnantProgressBtn_Click(sender As Object, e As EventArgs) Handles pregnantProgressBtn.Click
        childForm(pregnantProgress)
        ActiveButton1(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub birthingServicesBtn_Click(sender As Object, e As EventArgs) Handles birthingServicesBtn.Click
        childForm(birthingServices)
        ActiveButton1(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub weighingChildrenBtn_Click(sender As Object, e As EventArgs) Handles weighingChildrenBtn.Click
        childForm(weighingChildren)
        ActiveButton1(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub immunizationBtn_Click(sender As Object, e As EventArgs) Handles immunizationBtn.Click
        childForm(Immunization)
        ActiveButton1(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub staffBtn_Click(sender As Object, e As EventArgs) Handles staffBtn.Click
        childForm(Staff)
        ActiveButton(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        childForm(report)
        ActiveButton(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles logOutBn.Click
        ' Close the current form
        Me.Close()

        ' Show a new instance of the login form
        Dim loginForm As New login
        loginForm.ShowDialog()

        ' Dispose of resources after the login form is closed
        loginForm.Dispose()
    End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.BackColorChanged, PictureBox1.BackColorChanged
    '    Dim home = New home
    '    home.ShowDialog()
    'End Sub

    Private Sub dashBoardBtn_Click_1(sender As Object, e As EventArgs) Handles dashBoardBtn.Click
        childForm(dashBoard)
        ActiveButton(sender, Color.FromArgb(92, 131, 116))
    End Sub

    Public Sub ShowDashbordForm()
        ' Clear any existing controls in the main panel
        mainPanel.Controls.Clear()

        ' Create an instance of the pregnantProgress form
        Dim pregnantForm As New pregnantProgress()

        ' Set its properties (if needed)
        pregnantForm.TopLevel = False
        pregnantForm.Parent = mainPanel
        pregnantForm.Dock = DockStyle.Fill

        ' Show the pregnantForm
        dashBoard.Show()

        ' Show the main panel
        mainPanel.Show()
    End Sub
End Class