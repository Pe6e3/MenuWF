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
            addProductBtn = new buttonUI();
            addDishBtn = new buttonUI();
            addMenuBtn = new buttonUI();
            egoldsFormStyle1 = new UIElements.EgoldsFormStyle(components);
            cardui1 = new cardUI();
            SuspendLayout();
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.Tomato;
            addProductBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addProductBtn.Font = new Font("Intro ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(401, 170);
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
            // cardui1
            // 
            cardui1.BackColor = Color.White;
            cardui1.BackColorCurtain = Color.FromArgb(231, 76, 60);
            cardui1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cardui1.FontDescrition = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cardui1.FontHeader = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cardui1.ForeColorDescrition = Color.Black;
            cardui1.ForeColorHeader = Color.White;
            cardui1.Location = new Point(12, 12);
            cardui1.Name = "cardui1";
            cardui1.Size = new Size(250, 200);
            cardui1.TabIndex = 3;
            cardui1.Text = "cardui1";
            cardui1.TextDescrition = "Your description text for this control";
            cardui1.TextHeader = "Header";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 685);
            Controls.Add(cardui1);
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
        private UIElements.EgoldsFormStyle egoldsFormStyle1;
        private cardUI cardui1;
    }
}