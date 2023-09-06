using MenuWF.UXElements;

namespace MenuWF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ProductsBtn = new buttonUI();
            DishesBtn = new buttonUI();
            addMenuBtn = new buttonUI();
            egoldsFormStyle1 = new UIElements.EgoldsFormStyle(components);
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductsBtn
            // 
            ProductsBtn.BackColor = Color.Transparent;
            ProductsBtn.Cursor = Cursors.Hand;
            ProductsBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            ProductsBtn.Font = new Font("Intro ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ProductsBtn.ForeColor = Color.White;
            ProductsBtn.Location = new Point(186, 90);
            ProductsBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            ProductsBtn.Name = "ProductsBtn";
            ProductsBtn.Rounding = 33;
            ProductsBtn.RoundingEnable = true;
            ProductsBtn.Size = new Size(169, 70);
            ProductsBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            ProductsBtn.TabIndex = 1;
            ProductsBtn.Text = "Продукты";
            ProductsBtn.TextHover = "Список продуктов, добавить новые";
            ProductsBtn.Click += addProductBtn_Click;
            // 
            // DishesBtn
            // 
            DishesBtn.BackColor = Color.Transparent;
            DishesBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            DishesBtn.Font = new Font("Intro ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DishesBtn.ForeColor = Color.White;
            DishesBtn.Location = new Point(186, 222);
            DishesBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            DishesBtn.Name = "DishesBtn";
            DishesBtn.Rounding = 33;
            DishesBtn.RoundingEnable = true;
            DishesBtn.Size = new Size(169, 70);
            DishesBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            DishesBtn.TabIndex = 1;
            DishesBtn.Text = "Блюда";
            DishesBtn.TextHover = "Список блюд, добавить новые";
            DishesBtn.Click += DishesBtn_Click;
            // 
            // addMenuBtn
            // 
            addMenuBtn.BackColor = Color.Transparent;
            addMenuBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addMenuBtn.Font = new Font("Intro ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addMenuBtn.ForeColor = Color.White;
            addMenuBtn.Location = new Point(185, 353);
            addMenuBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addMenuBtn.Name = "addMenuBtn";
            addMenuBtn.Rounding = 33;
            addMenuBtn.RoundingEnable = true;
            addMenuBtn.Size = new Size(170, 70);
            addMenuBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addMenuBtn.TabIndex = 2;
            addMenuBtn.TabStop = false;
            addMenuBtn.Text = "Составить меню";
            addMenuBtn.TextHover = "Сформировать Завтрак, Обед и Ужин из блюд";
            addMenuBtn.Click += addMenuBtn_Click;
            // 
            // egoldsFormStyle1
            // 
            egoldsFormStyle1.AllowUserResize = false;
            egoldsFormStyle1.BackColor = Color.White;
            egoldsFormStyle1.ContextMenuForm = null;
            egoldsFormStyle1.ControlBoxButtonsWidth = 20;
            egoldsFormStyle1.EnableControlBoxIconsLight = true;
            egoldsFormStyle1.EnableControlBoxMouseLight = true;
            egoldsFormStyle1.Form = this;
            egoldsFormStyle1.FormStyle = UIElements.EgoldsFormStyle.fStyle.UserStyle;
            egoldsFormStyle1.HeaderColor = Color.DarkSlateGray;
            egoldsFormStyle1.HeaderColorAdditional = Color.FromArgb(140, 100, 100);
            egoldsFormStyle1.HeaderColorGradientEnable = true;
            egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            egoldsFormStyle1.HeaderHeight = 38;
            egoldsFormStyle1.HeaderImage = (Image)resources.GetObject("egoldsFormStyle1.HeaderImage");
            egoldsFormStyle1.HeaderTextColor = Color.White;
            egoldsFormStyle1.HeaderTextFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(addMenuBtn);
            panel1.Controls.Add(ProductsBtn);
            panel1.Controls.Add(DishesBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 555);
            panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 536);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Стартовое окно";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private buttonUI ProductsBtn;
        private buttonUI DishesBtn;
        private buttonUI addMenuBtn;
        private UIElements.EgoldsFormStyle egoldsFormStyle1;
        private Panel panel1;
    }
}