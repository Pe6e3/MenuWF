using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;


namespace MenuWF.UXElements;

public class cardUI : Control
{
    #region -- Переменные --
    private float CurtainHeight;
    private bool MouseEntered = false;
    private bool MousePressed = false;

    #endregion

    #region -- Свойства --

    public Color BackColorCurtain { get; set; } = FlatColors.Red;
    public string TextHeader { get; set; } = "Header";
    public Font FontHeader { get; set; } = new Font("Verdana", 12F, FontStyle.Bold);
    public Color ForeColorHeader { get; set; } = Color.White;

    public string TextDescription { get; set; } = "Описание этого элемента";
    public Font FontDescription { get; set; } = new Font("Verdana", 8.25F, FontStyle.Regular);
    public Color ForeColorDescription { get; set; } = Color.Black;
    #endregion

    public cardUI()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
        DoubleBuffered = true;
        Size = new Size(250, 200);
        Font = new Font("Verdana", 9F, FontStyle.Regular);
        BackColor = Color.White;
        CurtainHeight = Height - 60;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graph = e.Graphics;
        graph.SmoothingMode = SmoothingMode.HighQuality;
        graph.Clear(Parent.BackColor);
        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
        Rectangle rectCurtain = new Rectangle(0, 0, Width - 1, (int)CurtainHeight);   

        // Фон
        graph.FillRectangle(new SolidBrush(BackColor), rect);


        // Шторка
        graph.DrawRectangle(new Pen(BackColorCurtain), rectCurtain);
        graph.FillRectangle(new SolidBrush(BackColorCurtain), rectCurtain);

        // Обводка
        graph.DrawRectangle(new Pen(BackColor), rect);

        graph.DrawString(Text, Font, new SolidBrush(ForeColor), 15, Height - 37);
        graph.DrawString(TextHeader, FontHeader, new SolidBrush(ForeColorHeader), new Rectangle(15, 15, rectCurtain.Width, rectCurtain.Height));

    }
    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        if (Height <= 100)
            Height = 100;
        if (Width <= 100)
            Width = 100;
        CurtainHeight = Height - 60;
        Invalidate();
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
