Public Class MSignInpage
    Inherits Form

    Public Sub New()
        Me.Text = "Sign In"
        Me.Size = New Size(400, 800)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.BackColor = Color.FromArgb(30, 30, 30)

        ' Big centered logo
        Dim logoBox As New PictureBox()
        logoBox.Size = New Size(200, 80)
        logoBox.Location = New Point((Me.ClientSize.Width - 200) \ 2, 30)
        logoBox.SizeMode = PictureBoxSizeMode.Zoom
        logoBox.Image = My.Resources.logoomc

        Dim lblTitle As New Label()
        lblTitle.Text = "Sign In to GoodFinds"
        lblTitle.ForeColor = Color.White
        lblTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblTitle.Location = New Point(30, 130)
        lblTitle.AutoSize = True

        Dim txtEmail As New TextBox()
        txtEmail.Text = "Email"
        txtEmail.Location = New Point(30, 180)
        txtEmail.Width = 320
        txtEmail.BackColor = Color.FromArgb(50, 50, 50)
        txtEmail.ForeColor = Color.Gray

        Dim txtPassword As New TextBox()
        txtPassword.Text = "Password"
        txtPassword.Location = New Point(30, 230)
        txtPassword.Width = 320
        txtPassword.BackColor = Color.FromArgb(50, 50, 50)
        txtPassword.ForeColor = Color.Gray

        Dim btnLogin As New Button()
        btnLogin.Text = "Login"
        btnLogin.Location = New Point(30, 290)
        btnLogin.Width = 320
        btnLogin.BackColor = Color.FromArgb(70, 130, 180)
        btnLogin.ForeColor = Color.White
        AddHandler btnLogin.Click, Sub()
                                       Dim home As New MobileHomePage()
                                       home.Show()
                                       Me.Hide()
                                   End Sub

        Me.Controls.Add(logoBox)
        Me.Controls.Add(lblTitle)
        Me.Controls.Add(txtEmail)
        Me.Controls.Add(txtPassword)
        Me.Controls.Add(btnLogin)
    End Sub
End Class
