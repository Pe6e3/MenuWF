using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace MenuWF.UXElements;

public class bottonUI : Control
{
    private StringFormat SF = new StringFormat();
    private bool MouseEntered = false;
    private bool MousePressed = false;
    public bottonUI()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
        DoubleBuffered = true;
        Size = new Size(100, 30);
        BackColor = Color.Tomato;
        ForeColor = Color.White;

        SF.Alignment = StringAlignment.Center;
        SF.LineAlignment = StringAlignment.Center;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graph = e.Graphics;
        graph.SmoothingMode = SmoothingMode.HighQuality;
        graph.Clear(Parent.BackColor);
        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
        graph.DrawRectangle(new Pen(BackColor), rect);
        graph.FillRectangle(new SolidBrush(BackColor), rect);
        graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);

        if (MouseEntered)
        {
            graph.DrawRectangle(new Pen(Color.FromArgb(150, Color.White)), rect);
            graph.FillRectangle(new SolidBrush(Color.FromArgb(80, Color.White)), rect);
        }

        if (MousePressed)
        {
            graph.DrawRectangle(new Pen(Color.FromArgb(90, Color.Black)), rect);
            graph.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
        }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        MouseEntered = true;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        MouseEntered = false;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        MousePressed = true;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        MousePressed = false;
        Invalidate();
    }

}
