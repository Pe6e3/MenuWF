using MenuWF.UIElements;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace MenuWF.UXElements;

public class bottonUI : Control
{
    private StringFormat SF = new StringFormat();
    private bool MouseEntered = false;
    private bool MousePressed = false;

    Animation CurtainButtonAnim = new Animation();
    Animation RippleButtonAnim = new Animation();
    Point ClickLocation = new Point();
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
        Rectangle rectCurtain = new Rectangle(0, 0, (int)CurtainButtonAnim.Value, Height - 1);
        Rectangle rectRipple = new Rectangle(
            ClickLocation.X - (int)RippleButtonAnim.Value / 2,
            ClickLocation.Y - (int)RippleButtonAnim.Value / 2,
            (int)RippleButtonAnim.Value,
            (int)RippleButtonAnim.Value
            );


        // фон кнопки
        graph.DrawRectangle(new Pen(BackColor), rect);
        graph.FillRectangle(new SolidBrush(BackColor), rect);

        // шторка кнопки при наведении
        graph.DrawRectangle(new Pen(Color.FromArgb(150, Color.White)), rectCurtain);
        graph.FillRectangle(new SolidBrush(Color.FromArgb(80, Color.White)), rectCurtain);


        // Ripple-эффект при нажатии на кнопку
        if (RippleButtonAnim.Value > 0 && RippleButtonAnim.Value < RippleButtonAnim.TargetValue)
        {
            graph.DrawEllipse(new Pen(Color.FromArgb(90, Color.Black)), rectRipple);
            graph.FillEllipse(new SolidBrush(Color.FromArgb(30, Color.Black)), rectRipple);

        }
        else if (RippleButtonAnim.Value >= RippleButtonAnim.TargetValue)
            RippleButtonAnim.Value = 0;


        graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        MouseEntered = true;
        ButtonCurtainAction();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        MouseEntered = false;
        ButtonCurtainAction();

    }

    private void ButtonCurtainAction()
    {
        if (MouseEntered)
            CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, Width - 1);
        else
            CurtainButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtainButtonAnim.Value, 0);

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
