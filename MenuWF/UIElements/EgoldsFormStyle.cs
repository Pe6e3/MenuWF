using MenuWF.UXElements;
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
        private Size IconSize = new Size(14, 14);

        private bool MousePressed = false;
        private Point clickPosition;     // позиция курсора в момент клика
        private Point moveStartPosition; // позция формы в момент клика
        private Pen WhitePen = new Pen(Color.White) { Width = 1.7F };

        private Rectangle rectBtnClose = new Rectangle();
        private bool btnCloseHovered = false;

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
            SetDoubleBuffered(Form);
            OffSetControls();
            Form.Paint += FormPaint;

            Form.MouseDown += Form_MouseDown;
            Form.MouseUp += Form_MouseUp;
            Form.MouseMove += Form_MouseMove;
            Form.MouseLeave += Form_MouseLeave;
        }

        private void Form_MouseLeave(object? sender, EventArgs e)
        {
            btnCloseHovered = false;
            Form.Invalidate();
        }

        private void Form_MouseUp(object? sender, MouseEventArgs e)
        {
            MousePressed = false;
            if (e.Button == MouseButtons.Left)
                if (rectBtnClose.Contains(e.Location))
                    Form.Close();
        }
        private void Form_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Location.Y <= HeaderHeight)
            {
                MousePressed = true;
                clickPosition = Cursor.Position;
                moveStartPosition = Form.Location;
            }
        }

        private void Form_MouseMove(object? sender, MouseEventArgs e)
        {
            if (MousePressed)
            {
                Size frmOffset = new Size(Point.Subtract(Cursor.Position, new Size(clickPosition)));
                Form.Location = Point.Add(moveStartPosition, frmOffset);
            }
            else
            {
                if (rectBtnClose.Contains(e.Location))// Если мышь не нажата, проверяем, находится ли курсор над кнопкой закрытия
                {
                    if (!btnCloseHovered) // Если кнопка закрытия не была выделена ранее
                    {
                        btnCloseHovered = true;// Отмечаем, что кнопка закрытия теперь выделена
                        Form.Invalidate(); // Обновляем вид формы, чтобы отобразить выделение кнопки
                    }
                }
                else
                {
                    if (btnCloseHovered)// Если курсор не на кнопке закрытия, и кнопка была выделена ранее
                    {
                        btnCloseHovered = false;// Отмечаем, что кнопка закрытия теперь не выделена
                        Form.Invalidate(); // Обновляем вид формы, чтобы снять выделение с кнопки
                    }
                }
            }
        }



        private void FormPaint(object? sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }

        private void DrawStyle(Graphics graph)
        {
            graph.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rectHeader = new Rectangle(0, 0, Form.Width - 1, HeaderHeight);     // Заголовок формы
            Rectangle rectBorder = new Rectangle(0, 0, Form.Width - 1, Form.Height - 1);  // Обводка заголовка
            Rectangle rectTitleText = new Rectangle(rectHeader.X + 30, rectHeader.Y, rectHeader.Width, rectHeader.Height); // Текст названия окна
            Rectangle rectIcon = new Rectangle(
                rectHeader.Height / 2 - IconSize.Width / 2,
                rectHeader.Height / 2 - IconSize.Height / 2,
                IconSize.Width, IconSize.Height
                );
            rectBtnClose = new Rectangle(rectHeader.Width - rectHeader.Height, rectHeader.Y, rectHeader.Height, rectHeader.Height);
            Rectangle rectCrosshair = new Rectangle(
                rectBtnClose.X + rectBtnClose.Width / 2 - 5,
                rectBtnClose.Height / 2 - 5,
                10, 10);

            // Шапка
            graph.DrawRectangle(new Pen(HeaderColor), rectHeader);
            graph.FillRectangle(new SolidBrush(HeaderColor), rectHeader);

            // Обводка окна
            graph.DrawRectangle(new Pen(HeaderColor), rectBorder);

            // Текст заголовка
            graph.DrawString(Form.Text, Font, new SolidBrush(Color.White), rectTitleText, SF);

            // Иконка
            graph.DrawImage(Form.Icon.ToBitmap(), rectIcon);

            // Кнопка Х
            graph.DrawRectangle(new Pen(btnCloseHovered ? FlatColors.Red : HeaderColor), rectBtnClose);
            graph.FillRectangle(new SolidBrush(btnCloseHovered ? FlatColors.Red : HeaderColor), rectBtnClose);

            DrawCrosshair(graph, rectCrosshair, (btnCloseHovered ? WhitePen : new Pen(FlatColors.Gray)));

        }

        private void DrawCrosshair(Graphics graph, Rectangle rect, Pen pen)
        {
            graph.DrawLine(pen, rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
            graph.DrawLine(pen, rect.X + rect.Width, rect.Y, rect.X, rect.Y + rect.Height);

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

        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession) return;

            System.Reflection.PropertyInfo pDoubleBuffered =
                typeof(Control).GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance);
            pDoubleBuffered.SetValue(c, true, null);
        }


    }
}
