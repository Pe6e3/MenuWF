using System.Drawing.Drawing2D;

namespace MenuWF.Forms
{
    public class bottonUX : Control
    {
        private StringFormat SF= new StringFormat();
        public bottonUX()
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
            Rectangle rect = new Rectangle(0, 0, Width-1, Height-1);
            graph.DrawRectangle(new Pen(BackColor), rect);
            graph.FillRectangle(new SolidBrush(BackColor), rect);
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
        }
    }
}
