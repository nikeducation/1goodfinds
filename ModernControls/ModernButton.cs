using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernButton : Button
{
    public ModernButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = Color.FromArgb(40, 40, 40);
        ForeColor = Color.White;
        Font = new Font("Segoe UI", 10, FontStyle.Bold);
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        BackColor = Color.FromArgb(60, 60, 60);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        BackColor = Color.FromArgb(40, 40, 40);
    }
}