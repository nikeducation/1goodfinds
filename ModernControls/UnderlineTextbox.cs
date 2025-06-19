using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class UnderlineTextBox : TextBox
{
    private bool _isFocused = false;

    public UnderlineTextBox()
    {
        BorderStyle = BorderStyle.None;
        BackColor = Color.Black;
        ForeColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using (Pen pen = new Pen(_isFocused ? Color.White : Color.Gray, 2))
        {
            e.Graphics.DrawLine(pen, 0, Height - 1, Width, Height - 1);
        }
    }

    protected override void OnGotFocus(EventArgs e)
    {
        base.OnGotFocus(e);
        _isFocused = true;
        Invalidate();
    }

    protected override void OnLostFocus(EventArgs e)
    {
        base.OnLostFocus(e);
        _isFocused = false;
        Invalidate();
    }
}