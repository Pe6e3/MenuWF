namespace MenuWF.Forms
{
    partial class DishesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishesForm));
            egoldsFormStyle1 = new UIElements.EgoldsFormStyle(components);
            listBox1 = new ListBox();
            buttonui1 = new UXElements.buttonUI();
            SuspendLayout();
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(323, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // buttonui1
            // 
            buttonui1.endColorBorderBtn = Color.LightSkyBlue;
            buttonui1.Font = new Font("Candara Light", 35F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui1.ForeColor = Color.LightCyan;
            buttonui1.Location = new Point(12, 471);
            buttonui1.middleColorBtn = Color.DeepSkyBlue;
            buttonui1.Name = "buttonui1";
            buttonui1.Rounding = 33;
            buttonui1.RoundingEnable = true;
            buttonui1.Size = new Size(81, 36);
            buttonui1.startColorBtn = Color.SkyBlue;
            buttonui1.TabIndex = 1;
            buttonui1.Text = "←";
            buttonui1.TextHover = "назад";
            buttonui1.Click += buttonui1_Click;
            // 
            // DishesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 519);
            Controls.Add(buttonui1);
            Controls.Add(listBox1);
            Name = "DishesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Блюда";
            ResumeLayout(false);
        }

        #endregion

        private UIElements.EgoldsFormStyle egoldsFormStyle1;
        private ListBox listBox1;
        private UXElements.buttonUI buttonui1;
    }
}