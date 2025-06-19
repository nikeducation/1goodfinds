using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : TextBox
{
    public RoundedTextBox()
    {
        BorderStyle = BorderStyle.None;
        Padding = new Padding(10);
        BackColor = Color.Black;
        ForeColor = Color.White;
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, 10, 10, 180, 90);
            path.AddArc(Width - 10, 0, 10, 10, 270, 90);
            path.AddArc(Width - 10, Height - 10, 10, 10, 0, 90);
            path.AddArc(0, Height - 10, 10, 10, 90, 90);
            path.CloseFigure();

            Region = new Region(path);
        }
    }
}
