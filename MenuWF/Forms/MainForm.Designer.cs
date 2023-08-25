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
            bottonux1 = new Forms.bottonUX();
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
            bottonux1.Location = new Point(125, 114);
            bottonux1.Name = "bottonux1";
            bottonux1.Size = new Size(100, 30);
            bottonux1.TabIndex = 1;
            bottonux1.Text = "bottonux1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bottonux1);
            Controls.Add(productsButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Стартовое окно";
            ResumeLayout(false);
        }

        #endregion

        private Button productsButton;
        private Forms.bottonUX bottonux1;
    }
}