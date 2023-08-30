namespace MenuWF.Forms
{
    partial class MenusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenusForm));
            egoldsFormStyle1 = new UIElements.EgoldsFormStyle(components);
            allDishesListbox = new ListBox();
            addDishBtn = new UXElements.buttonUI();
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
            // allDishesListbox
            // 
            allDishesListbox.FormattingEnabled = true;
            allDishesListbox.ItemHeight = 15;
            allDishesListbox.Location = new Point(311, 41);
            allDishesListbox.Name = "allDishesListbox";
            allDishesListbox.Size = new Size(233, 304);
            allDishesListbox.TabIndex = 9;
            // 
            // addDishBtn
            // 
            addDishBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addDishBtn.ForeColor = Color.White;
            addDishBtn.Location = new Point(309, 364);
            addDishBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addDishBtn.Name = "addDishBtn";
            addDishBtn.Rounding = 33;
            addDishBtn.RoundingEnable = true;
            addDishBtn.Size = new Size(235, 36);
            addDishBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addDishBtn.TabIndex = 14;
            addDishBtn.Text = "Добавить";
            addDishBtn.TextHover = "Создать новое блюдо";
            // 
            // buttonui1
            // 
            buttonui1.endColorBorderBtn = Color.LightSkyBlue;
            buttonui1.Font = new Font("Candara Light", 35F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui1.ForeColor = Color.LightCyan;
            buttonui1.Location = new Point(12, 402);
            buttonui1.middleColorBtn = Color.DeepSkyBlue;
            buttonui1.Name = "buttonui1";
            buttonui1.Rounding = 33;
            buttonui1.RoundingEnable = true;
            buttonui1.Size = new Size(81, 36);
            buttonui1.startColorBtn = Color.SkyBlue;
            buttonui1.TabIndex = 15;
            buttonui1.Text = "←";
            buttonui1.TextHover = "назад";
            // 
            // MenusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonui1);
            Controls.Add(addDishBtn);
            Controls.Add(allDishesListbox);
            Name = "MenusForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню на день";
            ResumeLayout(false);
        }

        #endregion

        private UIElements.EgoldsFormStyle egoldsFormStyle1;
        private ListBox allDishesListbox;
        private UXElements.buttonUI addDishBtn;
        private UXElements.buttonUI buttonui1;
    }
}