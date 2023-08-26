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
            buttonui1 = new buttonUI();
            buttonui2 = new buttonUI();
            buttonui3 = new buttonUI();
            buttonui4 = new buttonUI();
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
            // buttonui1
            // 
            buttonui1.BackColor = Color.Tomato;
            buttonui1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui1.ForeColor = Color.White;
            buttonui1.Location = new Point(375, 64);
            buttonui1.Name = "buttonui1";
            buttonui1.Rounding = 50;
            buttonui1.RoundingEnable = true;
            buttonui1.Size = new Size(186, 101);
            buttonui1.TabIndex = 3;
            buttonui1.Text = "buttonui1";
            buttonui1.TextHover = null;
            // 
            // buttonui2
            // 
            buttonui2.BackColor = Color.Tomato;
            buttonui2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui2.ForeColor = Color.White;
            buttonui2.Location = new Point(27, 218);
            buttonui2.Name = "buttonui2";
            buttonui2.Rounding = 80;
            buttonui2.RoundingEnable = true;
            buttonui2.Size = new Size(763, 455);
            buttonui2.TabIndex = 3;
            buttonui2.Text = "buttonui1";
            buttonui2.TextHover = null;
            // 
            // buttonui3
            // 
            buttonui3.BackColor = Color.Tomato;
            buttonui3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui3.ForeColor = Color.White;
            buttonui3.Location = new Point(375, 12);
            buttonui3.Name = "buttonui3";
            buttonui3.Rounding = 30;
            buttonui3.RoundingEnable = true;
            buttonui3.Size = new Size(337, 43);
            buttonui3.TabIndex = 3;
            buttonui3.Text = "buttonui1";
            buttonui3.TextHover = null;
            // 
            // buttonui4
            // 
            buttonui4.BackColor = Color.Tomato;
            buttonui4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui4.ForeColor = Color.White;
            buttonui4.Location = new Point(616, 61);
            buttonui4.Name = "buttonui4";
            buttonui4.Rounding = 10;
            buttonui4.RoundingEnable = true;
            buttonui4.Size = new Size(185, 129);
            buttonui4.TabIndex = 3;
            buttonui4.Text = "buttonui1";
            buttonui4.TextHover = null;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 685);
            Controls.Add(buttonui4);
            Controls.Add(buttonui3);
            Controls.Add(buttonui2);
            Controls.Add(buttonui1);
            Controls.Add(cardui1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Стартовое окно";
            ResumeLayout(false);
        }

        #endregion
        private cardUI cardui1;
        private buttonUI buttonui1;
        private buttonUI buttonui2;
        private buttonUI buttonui3;
        private buttonUI buttonui4;
    }
}