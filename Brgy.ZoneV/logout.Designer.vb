<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logout
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Timer1 = New Timer(components)
        closeBtn = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 8
        ' 
        ' closeBtn
        ' 
        closeBtn.CustomizableEdges = CustomizableEdges1
        closeBtn.DisabledState.BorderColor = Color.DarkGray
        closeBtn.DisabledState.CustomBorderColor = Color.DarkGray
        closeBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        closeBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        closeBtn.FillColor = Color.Red
        closeBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        closeBtn.ForeColor = Color.Black
        closeBtn.Location = New Point(504, 2)
        closeBtn.Name = "closeBtn"
        closeBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        closeBtn.Size = New Size(34, 23)
        closeBtn.TabIndex = 76
        closeBtn.Text = "x"' 
        ' logout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(540, 299)
        Controls.Add(closeBtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "logout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "logout"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
End Class
