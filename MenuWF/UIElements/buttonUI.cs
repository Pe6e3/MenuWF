using MenuWF.UIElements;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace MenuWF.UXElements;

public class buttonUI : Control
{
    #region -- Свойства --

    [DisplayName("Цвет левого края")]
    public Color startColorBtn
    {
        get => _startColorBorder;
        set => _startColorBorder = value.IsEmpty ? FlatColors.GrayDark : value;
    }

    [DisplayName("Цвет середины")]
    public Color middleColorBtn
    {
        get => _middleColorBtn;
        set => _middleColorBtn = value.IsEmpty ? FlatColors.Gray : value;
    }

    [DisplayName("Цвет правого края")]
    public Color endColorBorderBtn
    {
        get => _endColorBorderBtn;
        set => _endColorBorderBtn = value.IsEmpty ? FlatColors.GreenSea : value;
    }

    [Description("Текст кнопки при наведении")]
    public string TextHover { get; set; }

    [DisplayName("Rounding [%]")]
    [DefaultValue(33)]
    [Description("Вкл/выкл закругление углов")]
    public bool RoundingEnable
    {
        get => roundingEnable;
        set
        {
            roundingEnable = value;
            Refresh();
        }
    }
    [Description("Радиус загругления углов в процентах")]
    public int Rounding
    {
        get => roundingPercent;
        set
        {
            if (value >= 0 && value <= 100)
            {
                roundingPercent = value;
                Refresh();
            }
        }
    }

    #endregion


    #region -- Переменные --

    private StringFormat SF = new StringFormat();
    private bool MouseEntered = false;
    private bool MousePressed = false;

    private bool roundingEnable = true;
    private int roundingPercent = 33;

    Animation CurtainButtonAnim = new Animation();
    Animation RippleButtonAnim = new Animation();
    Animation TextSlideAnim = new Animation();


    Point ClickLocation = new Point();
    private Color _startColorBorder;
    private Color _middleColorBtn;
    private Color _endColorBorderBtn;
    #endregion


    #region -- Конструктор --
    public buttonUI()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
        DoubleBuffered = true;
        Size = new Size(170, 70);
        Font = new Font("Verdana", 12F, FontStyle.Bold);
        ForeColor = Color.White;
        Cursor = Cursors.Hand;

        SF.Alignment = StringAlignment.Center;
        SF.LineAlignment = StringAlignment.Center;
    }
    #endregion

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graph = e.Graphics;
        graph.SmoothingMode = SmoothingMode.HighQuality;
        //graph.Clear(Parent.BackColor);

        Rectangle rect = new Rectangle(0, 0, Width, Height);
        Rectangle rectCurtain = new Rectangle(0, 0, (int)CurtainButtonAnim.Value, Height);
        Rectangle rectRipple = new Rectangle(
            ClickLocation.X - (int)RippleButtonAnim.Value,
            ClickLocation.Y - (int)RippleButtonAnim.Value,
            (int)RippleButtonAnim.Value * 2,
            (int)RippleButtonAnim.Value * 2
            );

        Rectangle rectText = new Rectangle((int)TextSlideAnim.Value, rect.Y, rect.Width, rect.Height);
        Rectangle rectTextHover = new Rectangle((int)TextSlideAnim.Value - rect.Width, rect.Y, rect.Width, rect.Height);


        // Скорость анимаций
        CurtainButtonAnim.StepDivider = TextSlideAnim.StepDivider = 14;
        RippleButtonAnim.StepDivider = 20;



        // Закругление
        float roundingValue = 0.1F;
        if (RoundingEnable && roundingPercent > 0)
            roundingValue = Height / 100F * roundingPercent;

        GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundingValue);

        // фон кнопки

        // Определение точек и позиций для градиента
        Point startPoint = new Point(0, 0); // Левый край
        Point endPoint = new Point(Width, 0); //Правый край

        LinearGradientBrush buttonGradient = new LinearGradientBrush(startPoint, endPoint, Color.Black, Color.Black);
        ColorBlend colorBlend = new ColorBlend();
        colorBlend.Colors = new Color[] { startColorBtn, middleColorBtn, endColorBorderBtn };
        colorBlend.Positions = new float[] { 0.0f, 0.4f, 1.0f };
        buttonGradient.InterpolationColors = colorBlend;

        BackColor = Color.Transparent;
        graph.DrawPath(new Pen(Color.LightGray), rectPath);
        graph.FillPath(buttonGradient, rectPath);


        graph.SetClip(rectPath);

        // шторка кнопки при наведении
        LinearGradientBrush buttonCurtainGradient = new LinearGradientBrush(startPoint, endPoint, Color.White, Color.Blue);
        ColorBlend colorCurtainBlend = new ColorBlend();
       

        colorCurtainBlend.Colors = new Color[] {
                CurtainColor(startColorBtn,addBlue: 40),
                CurtainColor(middleColorBtn,addBlue: 40),
                CurtainColor(endColorBorderBtn,addBlue: 40)
            };

        colorCurtainBlend.Positions = new float[] { 0.0f, 0.45f, 1.0f };
        buttonCurtainGradient.InterpolationColors = colorCurtainBlend;

        graph.DrawRectangle(new Pen(Color.FromArgb(150, Color.White)), rectCurtain);
        graph.FillRectangle(buttonCurtainGradient, rectCurtain);


        // Ripple-эффект при нажатии на кнопку
        if (RippleButtonAnim.Value > 0 && RippleButtonAnim.Value < RippleButtonAnim.TargetValue)
        {
            graph.DrawEllipse(new Pen(Color.FromArgb(90, Color.Black)), rectRipple);
            graph.FillEllipse(new SolidBrush(Color.FromArgb(30, Color.Black)), rectRipple);
        }
        else if (RippleButtonAnim.Value >= RippleButtonAnim.TargetValue)
            RippleButtonAnim.Value = 0;


        Font FontHover = new Font(Font.FontFamily, 9F, Font.Style);  // Задаем шрифт текста на шторке такой же, как основной, только с размером 9f


        // Рисуем текст
        if (string.IsNullOrEmpty(TextHover))
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
        else
        {
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectText, SF);
            graph.DrawString(TextHover, FontHover, new SolidBrush(ForeColor), rectTextHover, SF);
        }
    }
    private Color CurtainColor(Color color, int addBlue)
    {
        int B = Math.Min(color.B + addBlue, 255); // Ограничение до 255
        return Color.FromArgb((int)(color.A * 0.9f), color.R, color.G, B);
    }
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        MouseEntered = true;
        ButtonCurtainAction();
        TextSlideAction();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        MouseEntered = false;
        ButtonCurtainAction();
        TextSlideAction();
    }

    private void TextSlideAction()
    {
        if (MouseEntered)
            TextSlideAnim = new Animation("TextSlide_" + Handle, Invalidate, TextSlideAnim.Value, Width - 1);
        else
            TextSlideAnim = new Animation("TextSlide_" + Handle, Invalidate, TextSlideAnim.Value, 0);


        Animator.Request(TextSlideAnim, true);
    }

    private void ButtonCurtainAction()
    {
        if (MouseEntered)
            CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, Width - 1);
        else
            CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, 0);

        TextSlideAnim.StepDivider = 14;
        Animator.Request(CurtainButtonAnim, true);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        MousePressed = true;
        CurtainButtonAnim.Value = CurtainButtonAnim.TargetValue;
        ClickLocation = e.Location;
        ButtonRippleAction();
    }

    private void ButtonRippleAction()
    {
        RippleButtonAnim = new Animation("ButtonRipple_" + Handle, Invalidate, 0, Width);
        Animator.Request(RippleButtonAnim, true);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        MousePressed = false;
    }

}
