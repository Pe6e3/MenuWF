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
            productsButton = new Button();
            bottonux1 = new bottonUI();
            cardui1 = new cardUI();
            SuspendLayout();
            // 
            // productsButton
            // 
            productsButton.Location = new Point(83, 337);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(111, 43);
            productsButton.TabIndex = 0;
            productsButton.Text = "Продукты";
            productsButton.UseVisualStyleBackColor = true;
            // 
            // bottonux1
            // 
            bottonux1.BackColor = Color.Tomato;
            bottonux1.Font = new Font("Goudy Old Style", 16F, FontStyle.Bold, GraphicsUnit.Point);
            bottonux1.ForeColor = Color.White;
            bottonux1.Location = new Point(350, 115);
            bottonux1.Name = "bottonux1";
            bottonux1.Size = new Size(210, 66);
            bottonux1.TabIndex = 1;
            bottonux1.Text = "Войти в систему";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cardui1);
            Controls.Add(bottonux1);
            Controls.Add(productsButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Стартовое окно";
            ResumeLayout(false);
        }

        #endregion

        private Button productsButton;
        private bottonUI bottonux1;
        private cardUI cardui1;
    }
}