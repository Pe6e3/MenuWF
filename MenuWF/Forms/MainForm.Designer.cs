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
            addProductBtn = new buttonUI();
            addDishBtn = new buttonUI();
            addMenuBtn = new buttonUI();
            SuspendLayout();
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.Tomato;
            addProductBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addProductBtn.Font = new Font("Intro ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(400, 170);
            addProductBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Rounding = 33;
            addProductBtn.RoundingEnable = true;
            addProductBtn.Size = new Size(169, 70);
            addProductBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addProductBtn.TabIndex = 1;
            addProductBtn.Text = "Добавить продукт";
            addProductBtn.TextHover = "Страница добавления продукта";
            // 
            // addDishBtn
            // 
            addDishBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addDishBtn.Font = new Font("Intro ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addDishBtn.ForeColor = Color.White;
            addDishBtn.Location = new Point(400, 265);
            addDishBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addDishBtn.Name = "addDishBtn";
            addDishBtn.Rounding = 33;
            addDishBtn.RoundingEnable = true;
            addDishBtn.Size = new Size(169, 70);
            addDishBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addDishBtn.TabIndex = 1;
            addDishBtn.Text = "Добавить блюдо";
            addDishBtn.TextHover = "Совместить продукты в блюдо";
            // 
            // addMenuBtn
            // 
            addMenuBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addMenuBtn.Font = new Font("Intro ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addMenuBtn.ForeColor = Color.White;
            addMenuBtn.Location = new Point(400, 359);
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
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 685);
            Controls.Add(addMenuBtn);
            Controls.Add(addDishBtn);
            Controls.Add(addProductBtn);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Стартовое окно";
            ResumeLayout(false);
        }

        #endregion
        private buttonUI addProductBtn;
        private buttonUI addDishBtn;
        private buttonUI addMenuBtn;
    }
}