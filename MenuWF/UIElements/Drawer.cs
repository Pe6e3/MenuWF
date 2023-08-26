using System.Drawing.Drawing2D;

namespace MenuWF.UIElements;

public class Drawer
{
    public static GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize)
    {
        GraphicsPath gp = new GraphicsPath();

        gp.AddArc(rect.X+1, rect.Y+1, RoundSize, RoundSize, 180, 90);
        gp.AddArc(rect.X-1 + rect.Width - RoundSize, rect.Y+1, RoundSize, RoundSize, 270, 90);
        gp.AddArc(rect.X-1 + rect.Width - RoundSize, rect.Y-1 + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
        gp.AddArc(rect.X+1, rect.Y-1 + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

        gp.CloseFigure();

        return gp;
    }
}
