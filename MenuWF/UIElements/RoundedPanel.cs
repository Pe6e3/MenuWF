using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MenuWF.UIElements
{
    public class RoundedPanel : Panel
    {
        private int cornerRadius = 10; // Радиус скругления углов

        [Category("Appearance")] // Указываем категорию, в которой будет отображаться свойство
        [Browsable(true)] // Указываем, что свойство видимо в окне свойств
        public Color BorderColor { get; set; } = Color.Gray;

        [Category("Appearance")]
        [Browsable(true)]
        public int BorderWidth { get; set; } = 10;

        [Category("Appearance")]
        [Browsable(true)]
        public Color PanelColor { get; set; } = Color.LightGray;

        public int CornerRadius
        {
            get { return cornerRadius; }
            set { cornerRadius = value; Invalidate(); }
        }

        public RoundedPanel()
        {
            DoubleBuffered = true;
            BackColor = Color.Transparent;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width, Height);

            using (GraphicsPath borderPath = new GraphicsPath())
            {
                borderPath.StartFigure();
                borderPath.AddArc(rect.Left + BorderWidth / 2, rect.Top + BorderWidth / 2, cornerRadius * 2, cornerRadius * 2, 180, 90);                                           // левый верхний
                borderPath.AddArc(rect.Right - BorderWidth / 2 - cornerRadius * 2, rect.Top + BorderWidth / 2, cornerRadius * 2, cornerRadius * 2, 270, 90);                       // правый верхний
                borderPath.AddArc(rect.Right - BorderWidth / 2 - cornerRadius * 2, rect.Bottom - BorderWidth / 2 - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);   // правый нижний
                borderPath.AddArc(rect.Left + BorderWidth / 2, rect.Bottom - BorderWidth / 2 - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);                      // левый нижний
                borderPath.CloseFigure();

                // Рисуйте границу панели
                using (Pen pen = new Pen(BorderColor, BorderWidth))
                {
                    graph.DrawPath(pen, borderPath);
                }
                graph.FillPath(new SolidBrush(PanelColor), borderPath);

            }

        }
    }
}
