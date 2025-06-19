Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class RoundedCornerTExtBox
    Inherits TextBox
    <DllImport("gdi32.dll", EntryPoint:="CreateRoundedRectRgn")>
    Private Shared Function CreateRoundedRectRgn(ByVal nLeftRect As Integer, nTopRect As Integer,
                                                 ByVal nRightRect As Integer, nBottomRect As Integer,
                                                 ByVal nHeightRect As Integer, ByVal nWidthRect As Integer)

    End Function
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundedRectRgn(2, 3, Me.Width, Me.Height, 15, 15))

    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundedRectRgn(2, 3, Me.Width, Me.Height, 15, 15))
    End Sub

End Class
