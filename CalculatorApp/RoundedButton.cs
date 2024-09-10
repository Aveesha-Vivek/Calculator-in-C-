using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    protected override void OnPaint(PaintEventArgs e)
    {
        GraphicsPath path = new GraphicsPath();
        int borderRadius = 10; // Adjust this value for the corner radius

        RectangleF rect = new RectangleF(0, 0, Width, Height);
        path.AddArc(rect.X, rect.Y, borderRadius * 2, borderRadius * 2, 180, 90);
        path.AddArc(rect.Right - borderRadius * 2, rect.Y, borderRadius * 2, borderRadius * 2, 270, 90);
        path.AddArc(rect.Right - borderRadius * 2, rect.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
        path.AddArc(rect.X, rect.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
        path.CloseFigure();

        this.Region = new Region(path);

        base.OnPaint(e);
    }
}
