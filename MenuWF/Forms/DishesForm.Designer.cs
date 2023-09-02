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
            allDishesListbox = new ListBox();
            selectedDishLabel = new Label();
            nutritionList = new ListView();
            newDishField = new TextBox();
            addDishBtn = new UXElements.buttonUI();
            productsComboBox = new ComboBox();
            prodWeightField = new TextBox();
            addProdToDishBtn = new UXElements.buttonUI();
            backBtn = new UXElements.buttonUI();
            deleteProdFromDishBtn = new UXElements.buttonUI();
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
            allDishesListbox.Location = new Point(38, 68);
            allDishesListbox.Name = "allDishesListbox";
            allDishesListbox.Size = new Size(233, 304);
            allDishesListbox.TabIndex = 8;
            allDishesListbox.SelectedIndexChanged += allDishesListbox_SelectedIndexChanged;
            // 
            // selectedDishLabel
            // 
            selectedDishLabel.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            selectedDishLabel.Location = new Point(359, 68);
            selectedDishLabel.Name = "selectedDishLabel";
            selectedDishLabel.Size = new Size(204, 25);
            selectedDishLabel.TabIndex = 9;
            selectedDishLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nutritionList
            // 
            nutritionList.ImeMode = ImeMode.NoControl;
            nutritionList.Location = new Point(359, 112);
            nutritionList.Name = "nutritionList";
            nutritionList.Size = new Size(204, 260);
            nutritionList.TabIndex = 11;
            nutritionList.UseCompatibleStateImageBehavior = false;
            // 
            // newDishField
            // 
            newDishField.Location = new Point(40, 393);
            newDishField.Name = "newDishField";
            newDishField.PlaceholderText = "Новое блюдо";
            newDishField.Size = new Size(231, 23);
            newDishField.TabIndex = 12;
            newDishField.TextChanged += newDishField_TextChanged;
            // 
            // addDishBtn
            // 
            addDishBtn.BackColor = Color.Transparent;
            addDishBtn.Enabled = false;
            addDishBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addDishBtn.ForeColor = Color.White;
            addDishBtn.Location = new Point(36, 422);
            addDishBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addDishBtn.Name = "addDishBtn";
            addDishBtn.Rounding = 33;
            addDishBtn.RoundingEnable = true;
            addDishBtn.Size = new Size(235, 36);
            addDishBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addDishBtn.TabIndex = 13;
            addDishBtn.Text = "Добавить";
            addDishBtn.TextHover = "Создать новое блюдо";
            addDishBtn.Click += addDishBtn_Click;
            // 
            // productsComboBox
            // 
            productsComboBox.FormattingEnabled = true;
            productsComboBox.Location = new Point(614, 112);
            productsComboBox.Name = "productsComboBox";
            productsComboBox.Size = new Size(188, 23);
            productsComboBox.TabIndex = 14;
            productsComboBox.TextUpdate += productsComboBox_TextUpdate;
            // 
            // prodWeightField
            // 
            prodWeightField.AccessibleRole = AccessibleRole.Text;
            prodWeightField.Location = new Point(614, 141);
            prodWeightField.Name = "prodWeightField";
            prodWeightField.PlaceholderText = "вес продукта";
            prodWeightField.Size = new Size(141, 23);
            prodWeightField.TabIndex = 15;
            prodWeightField.TextChanged += prodWeightField_TextChanged;
            // 
            // addProdToDishBtn
            // 
            addProdToDishBtn.BackColor = Color.Transparent;
            addProdToDishBtn.Enabled = false;
            addProdToDishBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addProdToDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProdToDishBtn.ForeColor = Color.White;
            addProdToDishBtn.Location = new Point(614, 188);
            addProdToDishBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addProdToDishBtn.Name = "addProdToDishBtn";
            addProdToDishBtn.Rounding = 33;
            addProdToDishBtn.RoundingEnable = true;
            addProdToDishBtn.Size = new Size(188, 36);
            addProdToDishBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addProdToDishBtn.TabIndex = 13;
            addProdToDishBtn.Text = "Добавить в блюдо";
            addProdToDishBtn.TextHover = "продукт будет добавлен в блюдо";
            addProdToDishBtn.Click += addProdToDishBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.endColorBorderBtn = Color.LightSkyBlue;
            backBtn.Font = new Font("Candara Light", 35F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.LightCyan;
            backBtn.Location = new Point(12, 471);
            backBtn.middleColorBtn = Color.DeepSkyBlue;
            backBtn.Name = "backBtn";
            backBtn.Rounding = 33;
            backBtn.RoundingEnable = true;
            backBtn.Size = new Size(81, 36);
            backBtn.startColorBtn = Color.SkyBlue;
            backBtn.TabIndex = 31;
            backBtn.Text = "←";
            backBtn.TextHover = "назад";
            backBtn.Click += backBtn_Click;
            // 
            // deleteProdFromDishBtn
            // 
            deleteProdFromDishBtn.BackColor = Color.Transparent;
            deleteProdFromDishBtn.endColorBorderBtn = Color.DarkOrange;
            deleteProdFromDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteProdFromDishBtn.ForeColor = Color.Sienna;
            deleteProdFromDishBtn.Location = new Point(359, 393);
            deleteProdFromDishBtn.middleColorBtn = Color.NavajoWhite;
            deleteProdFromDishBtn.Name = "deleteProdFromDishBtn";
            deleteProdFromDishBtn.Rounding = 33;
            deleteProdFromDishBtn.RoundingEnable = true;
            deleteProdFromDishBtn.Size = new Size(204, 47);
            deleteProdFromDishBtn.startColorBtn = Color.Orange;
            deleteProdFromDishBtn.TabIndex = 32;
            deleteProdFromDishBtn.Text = "Удалить продукт из блюда";
            deleteProdFromDishBtn.TextHover = "продукт будет удален из блюда";
            deleteProdFromDishBtn.Click += deleteProdFromDishBtn_Click;
            // 
            // DishesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 519);
            Controls.Add(deleteProdFromDishBtn);
            Controls.Add(backBtn);
            Controls.Add(prodWeightField);
            Controls.Add(productsComboBox);
            Controls.Add(addProdToDishBtn);
            Controls.Add(addDishBtn);
            Controls.Add(newDishField);
            Controls.Add(nutritionList);
            Controls.Add(selectedDishLabel);
            Controls.Add(allDishesListbox);
            Name = "DishesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Блюда";
            Load += DishesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UIElements.EgoldsFormStyle egoldsFormStyle1;
        private UXElements.buttonUI backBtn;
        private ListBox allDishesListbox;
        private Label selectedDishLabel;
        private ListView nutritionList;
        private ComboBox productsComboBox;
        private UXElements.buttonUI addDishBtn;
        private TextBox newDishField;
        private TextBox prodWeightField;
        private UXElements.buttonUI addProdToDishBtn;
        private UXElements.buttonUI deleteProdFromDishBtn;
    }
}