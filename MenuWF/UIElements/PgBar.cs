namespace MenuWF.UIElements;

public class PgBar : ProgressBar
{
    public PgBar() : base()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height)); // задний фон
        e.Graphics.FillRectangle(new SolidBrush(Color.Aquamarine), new Rectangle(0, 0, Value * Width / Maximum, Height)); // прогресс
        e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(0, 0, Width - 2, Height - 2)); // граница
        e.Graphics.DrawString(Value.ToString(), Font, new SolidBrush(Color.Black), ClientRectangle); // текст
    }
}
