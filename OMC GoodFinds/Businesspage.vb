Public Class Businesspage
    Inherits Form

    Public Sub New()
        Me.Text = "GoodFinds - Business Profile"
        Me.Size = New Size(400, 800)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.BackColor = Color.FromArgb(30, 30, 30)
        Me.AutoScroll = True

        ' Banner
        Dim banner As New PictureBox()
        banner.Size = New Size(400, 160)
        banner.Location = New Point(0, 0)
        banner.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Controls.Add(banner)

        ' Business Name
        Dim lblTitle As New Label()
        lblTitle.Text = "Joe's Coffee House"
        lblTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 170)
        lblTitle.AutoSize = True
        Me.Controls.Add(lblTitle)

        ' Description
        Dim lblDesc As New Label()
        lblDesc.Text = "Artisan coffee shop serving fresh brews, sandwiches, and homemade desserts."
        lblDesc.Font = New Font("Segoe UI", 10)
        lblDesc.ForeColor = Color.LightGray
        lblDesc.Location = New Point(20, 200)
        lblDesc.Size = New Size(360, 40)
        Me.Controls.Add(lblDesc)

        ' Live Menu Section
        Dim lblMenu As New Label()
        lblMenu.Text = "Live Menu"
        lblMenu.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblMenu.ForeColor = Color.White
        lblMenu.Location = New Point(20, 250)
        lblMenu.AutoSize = True
        Me.Controls.Add(lblMenu)

        Dim menuItems As (String, String, String)() = {
            ("https://source.unsplash.com/360x120/?street-food", "Americano", "Available"),
            ("https://source.unsplash.com/360x120/?street-food", "Latte", "Unavailable"),
            ("https://source.unsplash.com/360x120/?street-food", "Egg Sandwich", "Available")
        }

        Dim yOffset As Integer = 280
        For Each item In menuItems
            Dim panel As New Panel()
            panel.Location = New Point(20, yOffset)
            panel.Size = New Size(340, 70)
            panel.BackColor = Color.FromArgb(40, 40, 40)

            Dim pic As New PictureBox()
            pic.Size = New Size(60, 60)
            pic.Location = New Point(5, 5)
            pic.SizeMode = PictureBoxSizeMode.StretchImage

            Dim nameLbl As New Label()
            nameLbl.Text = item.Item2
            nameLbl.ForeColor = Color.White
            nameLbl.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            nameLbl.Location = New Point(75, 10)
            nameLbl.AutoSize = True

            Dim statusLbl As New Label()
            statusLbl.Text = item.Item3
            statusLbl.ForeColor = If(item.Item3 = "Available", Color.LightGreen, Color.Red)
            statusLbl.Font = New Font("Segoe UI", 9)
            statusLbl.Location = New Point(75, 35)
            statusLbl.AutoSize = True

            panel.Controls.Add(pic)
            panel.Controls.Add(nameLbl)
            panel.Controls.Add(statusLbl)
            Me.Controls.Add(panel)

            yOffset += 80
        Next

        ' Deals section
        Dim lblDeals As New Label()
        lblDeals.Text = "🔥 Limited-Time Deals"
        lblDeals.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblDeals.ForeColor = Color.White
        lblDeals.Location = New Point(20, yOffset)
        lblDeals.AutoSize = True
        Me.Controls.Add(lblDeals)

        Dim lblDeal1 As New Label()
        lblDeal1.Text = "- Free cookie with any large drink (until 5PM)"
        lblDeal1.ForeColor = Color.Gold
        lblDeal1.Font = New Font("Segoe UI", 9)
        lblDeal1.Location = New Point(20, yOffset + 30)
        lblDeal1.AutoSize = True
        Me.Controls.Add(lblDeal1)

        Dim lblDeal2 As New Label()
        lblDeal2.Text = "- 10% off student promo"
        lblDeal2.ForeColor = Color.Gold
        lblDeal2.Font = New Font("Segoe UI", 9)
        lblDeal2.Location = New Point(20, yOffset + 55)
        lblDeal2.AutoSize = True
        Me.Controls.Add(lblDeal2)

        ' Back button
        Dim btnBack As New Button()
        btnBack.Text = "Back"
        btnBack.Size = New Size(340, 40)
        btnBack.Location = New Point(20, yOffset + 90)
        btnBack.BackColor = Color.FromArgb(70, 130, 180)
        btnBack.ForeColor = Color.White
        AddHandler btnBack.Click, Sub()
                                      Dim h As New MobileHomePage()
                                      h.Show()
                                      Me.Hide()
                                  End Sub
        Me.Controls.Add(btnBack)
    End Sub
End Class
