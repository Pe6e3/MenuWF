using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MenuWF.UIElements
{
    public partial class EgoldsFormStyle : Component
    {

        #region  -- Свойства --
        public Form Form { get; set; }
        public fStyle FormStyle
        {
            get => formStyle;
            set
            {
                formStyle = value;
                Sign();
            }
        }


        #endregion

        #region  -- Переменные --
        public fStyle formStyle = fStyle.None;
        public enum fStyle // Набор стилей
        {
            None,
            UserStyle,
            SimpleDark,
            TelegramStyle
        }
        private int HeaderHeight = 28;
        private Color HeaderColor = Color.DimGray;
        private StringFormat SF = new StringFormat();
        private Font Font = new Font("Arial", 9F, FontStyle.Regular);


        #endregion

        #region  -- Конструкторы --

        public EgoldsFormStyle()
        {
            InitializeComponent();
        }

        public EgoldsFormStyle(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        #endregion

        private void Sign()
        {
            if (Form != null)
                Form.Load += Form_Load;
        }

        private void Apply()
        {
            SF.Alignment = StringAlignment.Near;
            SF.LineAlignment = StringAlignment.Center;
            Form.FormBorderStyle = FormBorderStyle.None;
            OffSetControls();
            Form.Paint += FormPaint;
        }

        private void FormPaint(object? sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }

        private void DrawStyle(Graphics graph)
        {
            graph.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rectHeader = new Rectangle(0, 0, Form.Width - 1, HeaderHeight);
            Rectangle rectBorder = new Rectangle(0, 0, Form.Width - 1, Form.Height - 1);

            Rectangle rectTitleText = new Rectangle(rectHeader.X +30, rectHeader.Y, rectHeader.Width, rectHeader.Height);
            // Шапка
            graph.DrawRectangle(new Pen(HeaderColor), rectHeader);
            graph.FillRectangle(new SolidBrush(HeaderColor), rectHeader);

            // Обводка окна
            graph.DrawRectangle(new Pen(HeaderColor), rectBorder);

            // Текст заголовка
            graph.DrawString(Form.Text, Font, new SolidBrush(Color.White), rectTitleText, SF);
        }

        private void OffSetControls()
        {
            Form.Height += HeaderHeight;
            foreach (Control ctrl in Form.Controls)
            {
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + HeaderHeight);
                ctrl.Refresh();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Apply();
        }

    }
}
