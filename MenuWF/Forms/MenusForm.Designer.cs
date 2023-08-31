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
            addBreakfastDishBtn = new UXElements.buttonUI();
            backBtn = new UXElements.buttonUI();
            breakfastDishCB = new ComboBox();
            dinnerDishCB = new ComboBox();
            supperDishCB = new ComboBox();
            addDinnerDishBtn = new UXElements.buttonUI();
            addSupperDishBtn = new UXElements.buttonUI();
            breakfastDishWeightField = new TextBox();
            dinnerDishWeightField = new TextBox();
            supperDishWeightField = new TextBox();
            deleteDinnerDishBtn = new UXElements.buttonUI();
            deleteBreakfastDishBtn = new UXElements.buttonUI();
            deleteSupperDishBtn = new UXElements.buttonUI();
            dateOfJournal = new DateTimePicker();
            breakfastDishesLV = new ListView();
            dinnerDishesLV = new ListView();
            supperDishesLV = new ListView();
            breakfastProductsLV = new ListView();
            dinnerProductsLV = new ListView();
            supperProductsLV = new ListView();
            dayProdsLV = new ListView();
            breakfastSumWeightDishesLabel = new Label();
            dinnerSumWeightDishesLabel = new Label();
            supperSumWeightDishesLabel = new Label();
            sumBfProductsLabel = new Label();
            sumDinnerProductsLabel = new Label();
            sumSupperProductsLabel = new Label();
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
            // addBreakfastDishBtn
            // 
            addBreakfastDishBtn.Enabled = false;
            addBreakfastDishBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addBreakfastDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBreakfastDishBtn.ForeColor = Color.White;
            addBreakfastDishBtn.Location = new Point(282, 79);
            addBreakfastDishBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addBreakfastDishBtn.Name = "addBreakfastDishBtn";
            addBreakfastDishBtn.Rounding = 33;
            addBreakfastDishBtn.RoundingEnable = true;
            addBreakfastDishBtn.Size = new Size(188, 36);
            addBreakfastDishBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addBreakfastDishBtn.TabIndex = 14;
            addBreakfastDishBtn.Text = "Добавить";
            addBreakfastDishBtn.TextHover = "Добавить блюдо на завтрак";
            addBreakfastDishBtn.Click += addBreakfastDishBtn_Click;
            // 
            // backBtn
            // 
            backBtn.endColorBorderBtn = Color.LightSkyBlue;
            backBtn.Font = new Font("Candara Light", 35F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.LightCyan;
            backBtn.Location = new Point(12, 550);
            backBtn.middleColorBtn = Color.DeepSkyBlue;
            backBtn.Name = "backBtn";
            backBtn.Rounding = 33;
            backBtn.RoundingEnable = true;
            backBtn.Size = new Size(81, 36);
            backBtn.startColorBtn = Color.SkyBlue;
            backBtn.TabIndex = 15;
            backBtn.Text = "←";
            backBtn.TextHover = "назад";
            backBtn.Click += backBtn_Click;
            // 
            // breakfastDishCB
            // 
            breakfastDishCB.DropDownStyle = ComboBoxStyle.DropDownList;
            breakfastDishCB.FormattingEnabled = true;
            breakfastDishCB.Location = new Point(282, 21);
            breakfastDishCB.Name = "breakfastDishCB";
            breakfastDishCB.Size = new Size(188, 23);
            breakfastDishCB.TabIndex = 16;
            // 
            // dinnerDishCB
            // 
            dinnerDishCB.DropDownStyle = ComboBoxStyle.DropDownList;
            dinnerDishCB.FormattingEnabled = true;
            dinnerDishCB.Location = new Point(282, 206);
            dinnerDishCB.Name = "dinnerDishCB";
            dinnerDishCB.Size = new Size(188, 23);
            dinnerDishCB.TabIndex = 16;
            // 
            // supperDishCB
            // 
            supperDishCB.DropDownStyle = ComboBoxStyle.DropDownList;
            supperDishCB.FormattingEnabled = true;
            supperDishCB.Location = new Point(282, 381);
            supperDishCB.MaxDropDownItems = 15;
            supperDishCB.Name = "supperDishCB";
            supperDishCB.Size = new Size(188, 23);
            supperDishCB.TabIndex = 16;
            // 
            // addDinnerDishBtn
            // 
            addDinnerDishBtn.Enabled = false;
            addDinnerDishBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addDinnerDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addDinnerDishBtn.ForeColor = Color.White;
            addDinnerDishBtn.Location = new Point(282, 264);
            addDinnerDishBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addDinnerDishBtn.Name = "addDinnerDishBtn";
            addDinnerDishBtn.Rounding = 33;
            addDinnerDishBtn.RoundingEnable = true;
            addDinnerDishBtn.Size = new Size(188, 36);
            addDinnerDishBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addDinnerDishBtn.TabIndex = 14;
            addDinnerDishBtn.Text = "Добавить";
            addDinnerDishBtn.TextHover = "Добавить блюдо на обед";
            addDinnerDishBtn.Click += addDinnerDishBtn_Click;
            // 
            // addSupperDishBtn
            // 
            addSupperDishBtn.Enabled = false;
            addSupperDishBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addSupperDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addSupperDishBtn.ForeColor = Color.White;
            addSupperDishBtn.Location = new Point(282, 439);
            addSupperDishBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addSupperDishBtn.Name = "addSupperDishBtn";
            addSupperDishBtn.Rounding = 33;
            addSupperDishBtn.RoundingEnable = true;
            addSupperDishBtn.Size = new Size(188, 36);
            addSupperDishBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addSupperDishBtn.TabIndex = 14;
            addSupperDishBtn.Text = "Добавить";
            addSupperDishBtn.TextHover = "Добавить блюдо на ужин";
            addSupperDishBtn.Click += addSupperDishBtn_Click;
            // 
            // breakfastDishWeightField
            // 
            breakfastDishWeightField.Location = new Point(282, 50);
            breakfastDishWeightField.Name = "breakfastDishWeightField";
            breakfastDishWeightField.Size = new Size(100, 23);
            breakfastDishWeightField.TabIndex = 17;
            breakfastDishWeightField.TextChanged += breakfastDishWeightField_TextChanged;
            // 
            // dinnerDishWeightField
            // 
            dinnerDishWeightField.Location = new Point(282, 235);
            dinnerDishWeightField.Name = "dinnerDishWeightField";
            dinnerDishWeightField.Size = new Size(100, 23);
            dinnerDishWeightField.TabIndex = 17;
            dinnerDishWeightField.TextChanged += dinnerDishWeightField_TextChanged;
            // 
            // supperDishWeightField
            // 
            supperDishWeightField.Location = new Point(282, 410);
            supperDishWeightField.Name = "supperDishWeightField";
            supperDishWeightField.Size = new Size(100, 23);
            supperDishWeightField.TabIndex = 17;
            supperDishWeightField.TextChanged += supperDishWeightField_TextChanged;
            // 
            // deleteDinnerDishBtn
            // 
            deleteDinnerDishBtn.Enabled = false;
            deleteDinnerDishBtn.endColorBorderBtn = Color.DarkOrange;
            deleteDinnerDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteDinnerDishBtn.ForeColor = Color.Sienna;
            deleteDinnerDishBtn.Location = new Point(282, 306);
            deleteDinnerDishBtn.middleColorBtn = Color.NavajoWhite;
            deleteDinnerDishBtn.Name = "deleteDinnerDishBtn";
            deleteDinnerDishBtn.Rounding = 33;
            deleteDinnerDishBtn.RoundingEnable = true;
            deleteDinnerDishBtn.Size = new Size(188, 36);
            deleteDinnerDishBtn.startColorBtn = Color.Orange;
            deleteDinnerDishBtn.TabIndex = 14;
            deleteDinnerDishBtn.Text = "Удалить";
            deleteDinnerDishBtn.TextHover = "Удалить выбранное блюдо из Обеда";
            deleteDinnerDishBtn.Click += deleteDinnerDishBtn_Click;
            // 
            // deleteBreakfastDishBtn
            // 
            deleteBreakfastDishBtn.Enabled = false;
            deleteBreakfastDishBtn.endColorBorderBtn = Color.DarkOrange;
            deleteBreakfastDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBreakfastDishBtn.ForeColor = Color.Sienna;
            deleteBreakfastDishBtn.Location = new Point(282, 124);
            deleteBreakfastDishBtn.middleColorBtn = Color.NavajoWhite;
            deleteBreakfastDishBtn.Name = "deleteBreakfastDishBtn";
            deleteBreakfastDishBtn.Rounding = 33;
            deleteBreakfastDishBtn.RoundingEnable = true;
            deleteBreakfastDishBtn.Size = new Size(188, 36);
            deleteBreakfastDishBtn.startColorBtn = Color.Orange;
            deleteBreakfastDishBtn.TabIndex = 14;
            deleteBreakfastDishBtn.Text = "Удалить";
            deleteBreakfastDishBtn.TextHover = "Удалить выбранное блюдо из Завтрака";
            deleteBreakfastDishBtn.Click += deleteBreakfastDishBtn_Click;
            // 
            // deleteSupperDishBtn
            // 
            deleteSupperDishBtn.Enabled = false;
            deleteSupperDishBtn.endColorBorderBtn = Color.DarkOrange;
            deleteSupperDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSupperDishBtn.ForeColor = Color.Sienna;
            deleteSupperDishBtn.Location = new Point(282, 484);
            deleteSupperDishBtn.middleColorBtn = Color.NavajoWhite;
            deleteSupperDishBtn.Name = "deleteSupperDishBtn";
            deleteSupperDishBtn.Rounding = 33;
            deleteSupperDishBtn.RoundingEnable = true;
            deleteSupperDishBtn.Size = new Size(188, 36);
            deleteSupperDishBtn.startColorBtn = Color.Orange;
            deleteSupperDishBtn.TabIndex = 14;
            deleteSupperDishBtn.Text = "Удалить";
            deleteSupperDishBtn.TextHover = "Удалить выбранное блюдо из Ужина";
            deleteSupperDishBtn.Click += deleteSupperDishBtn_Click;
            // 
            // dateOfJournal
            // 
            dateOfJournal.Format = DateTimePickerFormat.Short;
            dateOfJournal.Location = new Point(132, 550);
            dateOfJournal.Name = "dateOfJournal";
            dateOfJournal.Size = new Size(99, 23);
            dateOfJournal.TabIndex = 18;
            dateOfJournal.Value = new DateTime(2023, 8, 30, 21, 32, 34, 0);
            // 
            // breakfastDishesLV
            // 
            breakfastDishesLV.Location = new Point(12, 21);
            breakfastDishesLV.Name = "breakfastDishesLV";
            breakfastDishesLV.Size = new Size(232, 139);
            breakfastDishesLV.TabIndex = 19;
            breakfastDishesLV.UseCompatibleStateImageBehavior = false;
            breakfastDishesLV.SelectedIndexChanged += breakfastDishesLV_SelectedIndexChanged;
            // 
            // dinnerDishesLV
            // 
            dinnerDishesLV.Location = new Point(12, 206);
            dinnerDishesLV.Name = "dinnerDishesLV";
            dinnerDishesLV.Size = new Size(232, 139);
            dinnerDishesLV.TabIndex = 19;
            dinnerDishesLV.UseCompatibleStateImageBehavior = false;
            dinnerDishesLV.SelectedIndexChanged += dinnerDishesLV_SelectedIndexChanged;
            // 
            // supperDishesLV
            // 
            supperDishesLV.Location = new Point(12, 381);
            supperDishesLV.Name = "supperDishesLV";
            supperDishesLV.Size = new Size(232, 139);
            supperDishesLV.TabIndex = 19;
            supperDishesLV.UseCompatibleStateImageBehavior = false;
            supperDishesLV.SelectedIndexChanged += supperDishesLV_SelectedIndexChanged;
            // 
            // breakfastProductsLV
            // 
            breakfastProductsLV.Location = new Point(500, 21);
            breakfastProductsLV.Name = "breakfastProductsLV";
            breakfastProductsLV.Size = new Size(222, 139);
            breakfastProductsLV.TabIndex = 19;
            breakfastProductsLV.UseCompatibleStateImageBehavior = false;
            // 
            // dinnerProductsLV
            // 
            dinnerProductsLV.Location = new Point(500, 206);
            dinnerProductsLV.Name = "dinnerProductsLV";
            dinnerProductsLV.Size = new Size(222, 139);
            dinnerProductsLV.TabIndex = 19;
            dinnerProductsLV.UseCompatibleStateImageBehavior = false;
            // 
            // supperProductsLV
            // 
            supperProductsLV.Location = new Point(500, 381);
            supperProductsLV.Name = "supperProductsLV";
            supperProductsLV.Size = new Size(222, 139);
            supperProductsLV.TabIndex = 19;
            supperProductsLV.UseCompatibleStateImageBehavior = false;
            // 
            // dayProdsLV
            // 
            dayProdsLV.Location = new Point(758, 21);
            dayProdsLV.Name = "dayProdsLV";
            dayProdsLV.Size = new Size(233, 499);
            dayProdsLV.TabIndex = 19;
            dayProdsLV.UseCompatibleStateImageBehavior = false;
            // 
            // breakfastSumWeightDishesLabel
            // 
            breakfastSumWeightDishesLabel.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            breakfastSumWeightDishesLabel.ForeColor = Color.DarkRed;
            breakfastSumWeightDishesLabel.Location = new Point(12, 163);
            breakfastSumWeightDishesLabel.Name = "breakfastSumWeightDishesLabel";
            breakfastSumWeightDishesLabel.Size = new Size(232, 25);
            breakfastSumWeightDishesLabel.TabIndex = 20;
            breakfastSumWeightDishesLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // dinnerSumWeightDishesLabel
            // 
            dinnerSumWeightDishesLabel.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dinnerSumWeightDishesLabel.ForeColor = Color.DarkRed;
            dinnerSumWeightDishesLabel.Location = new Point(12, 348);
            dinnerSumWeightDishesLabel.Name = "dinnerSumWeightDishesLabel";
            dinnerSumWeightDishesLabel.Size = new Size(232, 25);
            dinnerSumWeightDishesLabel.TabIndex = 20;
            dinnerSumWeightDishesLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // supperSumWeightDishesLabel
            // 
            supperSumWeightDishesLabel.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            supperSumWeightDishesLabel.ForeColor = Color.DarkRed;
            supperSumWeightDishesLabel.Location = new Point(12, 522);
            supperSumWeightDishesLabel.Name = "supperSumWeightDishesLabel";
            supperSumWeightDishesLabel.Size = new Size(232, 25);
            supperSumWeightDishesLabel.TabIndex = 20;
            supperSumWeightDishesLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // sumBfProductsLabel
            // 
            sumBfProductsLabel.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            sumBfProductsLabel.ForeColor = Color.DarkRed;
            sumBfProductsLabel.Location = new Point(490, 163);
            sumBfProductsLabel.Name = "sumBfProductsLabel";
            sumBfProductsLabel.Size = new Size(232, 25);
            sumBfProductsLabel.TabIndex = 20;
            sumBfProductsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // sumDinnerProductsLabel
            // 
            sumDinnerProductsLabel.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            sumDinnerProductsLabel.ForeColor = Color.DarkRed;
            sumDinnerProductsLabel.Location = new Point(490, 348);
            sumDinnerProductsLabel.Name = "sumDinnerProductsLabel";
            sumDinnerProductsLabel.Size = new Size(232, 25);
            sumDinnerProductsLabel.TabIndex = 20;
            sumDinnerProductsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // sumSupperProductsLabel
            // 
            sumSupperProductsLabel.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            sumSupperProductsLabel.ForeColor = Color.DarkRed;
            sumSupperProductsLabel.Location = new Point(490, 522);
            sumSupperProductsLabel.Name = "sumSupperProductsLabel";
            sumSupperProductsLabel.Size = new Size(232, 25);
            sumSupperProductsLabel.TabIndex = 20;
            sumSupperProductsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // MenusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 601);
            Controls.Add(sumSupperProductsLabel);
            Controls.Add(supperSumWeightDishesLabel);
            Controls.Add(sumDinnerProductsLabel);
            Controls.Add(dinnerSumWeightDishesLabel);
            Controls.Add(sumBfProductsLabel);
            Controls.Add(breakfastSumWeightDishesLabel);
            Controls.Add(supperProductsLV);
            Controls.Add(supperDishesLV);
            Controls.Add(dinnerProductsLV);
            Controls.Add(dinnerDishesLV);
            Controls.Add(dayProdsLV);
            Controls.Add(breakfastProductsLV);
            Controls.Add(breakfastDishesLV);
            Controls.Add(dateOfJournal);
            Controls.Add(supperDishWeightField);
            Controls.Add(dinnerDishWeightField);
            Controls.Add(breakfastDishWeightField);
            Controls.Add(supperDishCB);
            Controls.Add(dinnerDishCB);
            Controls.Add(breakfastDishCB);
            Controls.Add(backBtn);
            Controls.Add(addSupperDishBtn);
            Controls.Add(deleteSupperDishBtn);
            Controls.Add(deleteBreakfastDishBtn);
            Controls.Add(deleteDinnerDishBtn);
            Controls.Add(addDinnerDishBtn);
            Controls.Add(addBreakfastDishBtn);
            Name = "MenusForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню на день";
            Load += MenusForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UIElements.EgoldsFormStyle egoldsFormStyle1;
        private UXElements.buttonUI addBreakfastDishBtn;
        private UXElements.buttonUI backBtn;
        private ComboBox supperDishCB;
        private ComboBox dinnerDishCB;
        private ComboBox breakfastDishCB;
        private UXElements.buttonUI addDinnerDishBtn;
        private TextBox supperDishWeightField;
        private TextBox dinnerDishWeightField;
        private TextBox breakfastDishWeightField;
        private UXElements.buttonUI addSupperDishBtn;
        private UXElements.buttonUI deleteDinnerDishBtn;
        private UXElements.buttonUI deleteSupperDishBtn;
        private UXElements.buttonUI deleteBreakfastDishBtn;
        private DateTimePicker dateOfJournal;
        private ListView supperDishesLV;
        private ListView dinnerDishesLV;
        private ListView breakfastDishesLV;
        private ListView supperProductsLV;
        private ListView dinnerProductsLV;
        private ListView dayProdsLV;
        private ListView breakfastProductsLV;
        private Label breakfastSumWeightDishesLabel;
        private Label supperSumWeightDishesLabel;
        private Label dinnerSumWeightDishesLabel;
        private Label sumSupperProductsLabel;
        private Label sumDinnerProductsLabel;
        private Label sumBfProductsLabel;
    }
}