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
            cardui1 = new cardUI();
            buttonui2 = new buttonUI();
            buttonui1 = new buttonUI();
            buttonui3 = new buttonUI();
            SuspendLayout();
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
            cardui1.TabIndex = 2;
            cardui1.Text = "Краткое описание";
            cardui1.TextDescrition = "Тут длинное описание карточки";
            cardui1.TextHeader = "Заголовок карточки";
            // 
            // buttonui2
            // 
            buttonui2.BackColor = Color.Tomato;
            buttonui2.endColorBorderBtn = Color.Khaki;
            buttonui2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui2.ForeColor = Color.White;
            buttonui2.Location = new Point(27, 218);
            buttonui2.middleColorBtn = Color.FromArgb(192, 192, 0);
            buttonui2.Name = "buttonui2";
            buttonui2.Rounding = 80;
            buttonui2.RoundingEnable = true;
            buttonui2.Size = new Size(763, 455);
            buttonui2.startColorBtn = Color.Lime;
            buttonui2.TabIndex = 3;
            buttonui2.Text = "buttonui1";
            buttonui2.TextHover = null;
            // 
            // buttonui1
            // 
            buttonui1.BackColor = Color.Tomato;
            buttonui1.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            buttonui1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui1.ForeColor = Color.White;
            buttonui1.Location = new Point(547, 59);
            buttonui1.middleColorBtn = Color.FromArgb(189, 195, 199);
            buttonui1.Name = "buttonui1";
            buttonui1.Rounding = 100;
            buttonui1.RoundingEnable = false;
            buttonui1.Size = new Size(100, 30);
            buttonui1.startColorBtn = Color.FromArgb(100, 100, 100, 100);
            buttonui1.TabIndex = 4;
            buttonui1.Text = "buttonui1";
            buttonui1.TextHover = null;
            // 
            // buttonui3
            // 
            buttonui3.BackColor = Color.Tomato;
            buttonui3.endColorBorderBtn = Color.FromArgb(0, 0, 192);
            buttonui3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui3.ForeColor = Color.White;
            buttonui3.Location = new Point(711, 146);
            buttonui3.middleColorBtn = Color.Red;
            buttonui3.Name = "buttonui3";
            buttonui3.Rounding = 100;
            buttonui3.RoundingEnable = false;
            buttonui3.Size = new Size(100, 30);
            buttonui3.startColorBtn = Color.Yellow;
            buttonui3.TabIndex = 5;
            buttonui3.Text = "buttonui3";
            buttonui3.TextHover = null;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 685);
            Controls.Add(buttonui3);
            Controls.Add(buttonui1);
            Controls.Add(buttonui2);
            Controls.Add(cardui1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Стартовое окно";
            ResumeLayout(false);
        }

        #endregion
        private cardUI cardui1;
        private buttonUI buttonui2;
        private buttonUI buttonui1;
        private buttonUI buttonui3;
    }
}