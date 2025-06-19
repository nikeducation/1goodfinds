Public Class MobileEditBusinessPage
    Inherits Form

    Public Sub New()
        Me.Text = "GoodFinds - Edit Business"
        Me.Size = New Size(400, 800)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.BackColor = Color.FromArgb(30, 30, 30)

        Dim logoBox As New PictureBox()
        logoBox.Size = New Size(120, 40)
        logoBox.Location = New Point(10, 10)
        logoBox.SizeMode = PictureBoxSizeMode.Zoom
        logoBox.Load("C:\Users\kctg3\Downloads\logoomc.png")

        Dim txtBusinessName As New TextBox()
        txtBusinessName.Text = "Business Name"
        txtBusinessName.Location = New Point(20, 70)
        txtBusinessName.Width = 340
        txtBusinessName.BackColor = Color.FromArgb(50, 50, 50)
        txtBusinessName.ForeColor = Color.Gray

        Dim txtDesc As New TextBox()
        txtDesc.Text = "Short description"
        txtDesc.Location = New Point(20, 120)
        txtDesc.Width = 340
        txtDesc.Height = 60
        txtDesc.Multiline = True
        txtDesc.BackColor = Color.FromArgb(50, 50, 50)
        txtDesc.ForeColor = Color.Gray

        Dim txtMenu As New TextBox()
        txtMenu.Text = "Menu items, comma separated"
        txtMenu.Location = New Point(20, 200)
        txtMenu.Width = 340
        txtMenu.Height = 60
        txtMenu.Multiline = True
        txtMenu.BackColor = Color.FromArgb(50, 50, 50)
        txtMenu.ForeColor = Color.Gray

        Dim btnSave As New Button()
        btnSave.Text = "Save & Back"
        btnSave.Location = New Point(20, 280)
        btnSave.Width = 340
        btnSave.BackColor = Color.FromArgb(70, 130, 180)
        btnSave.ForeColor = Color.White
        AddHandler btnSave.Click, Sub()
                                      Dim h As New MobileHomePage()
                                      h.Show()
                                      Me.Hide()
                                  End Sub

        Me.Controls.Add(logoBox)
        Me.Controls.Add(txtBusinessName)
        Me.Controls.Add(txtDesc)
        Me.Controls.Add(txtMenu)
        Me.Controls.Add(btnSave)
    End Sub
End Class
