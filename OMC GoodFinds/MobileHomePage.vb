Public Class MobileHomePage
    Inherits Form

    Public Sub New()
        Me.Text = "GoodFinds - Home"
        Me.Size = New Size(400, 800)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.BackColor = Color.FromArgb(30, 30, 30)
        Me.AutoScroll = True

        Dim logoBox As New PictureBox()
        logoBox.Size = New Size(120, 40)
        logoBox.Location = New Point(10, 10)
        logoBox.SizeMode = PictureBoxSizeMode.Zoom
        logoBox.Load("C:\Users\kctg3\Downloads\logoomc.png")
        Me.Controls.Add(logoBox)

        Dim yOffset As Integer = 60

        ' Generate 3 sample businesses
        For i As Integer = 1 To 3
            Dim cardPanel As New Panel()
            cardPanel.Size = New Size(360, 220)
            cardPanel.Location = New Point(20, yOffset)
            cardPanel.BackColor = Color.FromArgb(45, 45, 45)
            cardPanel.BorderStyle = BorderStyle.FixedSingle

            Dim banner As New PictureBox()
            banner.Size = New Size(360, 120)
            banner.Location = New Point(0, 0)
            banner.SizeMode = PictureBoxSizeMode.StretchImage

            ' Random stock images
            banner.Load("https://dummyimage.com/360x120/222/fff.png&text=Coffee+Shop+Banner")

            Dim lblName As New Label()
            lblName.Text = $"Business {i}"
            lblName.ForeColor = Color.White
            lblName.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblName.Location = New Point(10, 130)
            lblName.AutoSize = True

            Dim lblMenuPreview As New Label()
            lblMenuPreview.Text = "Sample Item 1, Sample Item 2"
            lblMenuPreview.ForeColor = Color.LightGray
            lblMenuPreview.Font = New Font("Segoe UI", 9)
            lblMenuPreview.Location = New Point(10, 160)
            lblMenuPreview.AutoSize = True

            Dim btnVisit As New Button()
            btnVisit.Text = "Visit"
            btnVisit.Size = New Size(100, 30)
            btnVisit.Location = New Point(250, 170)
            btnVisit.BackColor = Color.FromArgb(70, 130, 180)
            btnVisit.ForeColor = Color.White
            AddHandler btnVisit.Click, Sub()
                                           Dim b As New Businesspage()
                                           b.Show()
                                           Me.Hide()
                                       End Sub

            cardPanel.Controls.Add(banner)
            cardPanel.Controls.Add(lblName)
            cardPanel.Controls.Add(lblMenuPreview)
            cardPanel.Controls.Add(btnVisit)

            Me.Controls.Add(cardPanel)
            yOffset += 240
        Next
    End Sub
End Class
