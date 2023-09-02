﻿using System.Drawing.Drawing2D;

namespace MenuWF.UIElements;
public class RoundedPanel : Panel
{
    private int cornerRadius = 10; // Радиус скругления углов
    private Color borderColor = Color.Red; // Цвет края
    private int borderWidth = 1; // Толщина края

    public int CornerRadius
    {
        get { return cornerRadius; }
        set { cornerRadius = value; Invalidate(); }
    }

    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; Invalidate(); }
    }

    public int BorderWidth
    {
        get { return borderWidth; }
        set { borderWidth = value; Invalidate(); }
    }

    public RoundedPanel()
    {
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics graph = e.Graphics;
        graph.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, Width, Height);

        // Создайте графический путь для скругленного панели
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(rect.Left, rect.Top, cornerRadius * 2, cornerRadius * 2, 180, 90);
        path.AddArc(rect.Right - cornerRadius * 2, rect.Top, cornerRadius * 2, cornerRadius * 2, 270, 90);
        path.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
        path.AddArc(rect.Left, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
        path.CloseFigure();

        // Заполните панель скругленным фоном
        using (SolidBrush brush = new SolidBrush(BackColor))
        {
            graph.FillPath(brush, path);
        }

        // Рисуйте границу панели
        using (Pen pen = new Pen(borderColor, borderWidth))
        {
            graph.DrawPath(pen, path);
        }
    }
}