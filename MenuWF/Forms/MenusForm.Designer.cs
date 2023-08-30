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
            breakfastDishesLB = new ListBox();
            addDishBtn = new UXElements.buttonUI();
            backBtn = new UXElements.buttonUI();
            dinnerDishesLB = new ListBox();
            supperDishesLB = new ListBox();
            breakfastDishCB = new ComboBox();
            dinnerDishCB = new ComboBox();
            supperDishCB = new ComboBox();
            buttonui2 = new UXElements.buttonUI();
            buttonui3 = new UXElements.buttonUI();
            breakfastDishWeightField = new TextBox();
            dinnerDishWeightField = new TextBox();
            supperDishWeightField = new TextBox();
            deleteDinnerDishBtn = new UXElements.buttonUI();
            deleteBreakfastDishBtn = new UXElements.buttonUI();
            deleteSupperDishBtn = new UXElements.buttonUI();
            breakfastProdsLB = new ListBox();
            dinnerProdsLB = new ListBox();
            supperProdsLB = new ListBox();
            dayProdsLB = new ListBox();
            dateOfJournal = new DateTimePicker();
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
            // breakfastDishesLB
            // 
            breakfastDishesLB.FormattingEnabled = true;
            breakfastDishesLB.ItemHeight = 15;
            breakfastDishesLB.Location = new Point(29, 21);
            breakfastDishesLB.Name = "breakfastDishesLB";
            breakfastDishesLB.Size = new Size(233, 139);
            breakfastDishesLB.TabIndex = 9;
            // 
            // addDishBtn
            // 
            addDishBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addDishBtn.ForeColor = Color.White;
            addDishBtn.Location = new Point(282, 79);
            addDishBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addDishBtn.Name = "addDishBtn";
            addDishBtn.Rounding = 33;
            addDishBtn.RoundingEnable = true;
            addDishBtn.Size = new Size(188, 36);
            addDishBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addDishBtn.TabIndex = 14;
            addDishBtn.Text = "Добавить";
            addDishBtn.TextHover = "Добавить блюдо на завтрак";
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
            // dinnerDishesLB
            // 
            dinnerDishesLB.FormattingEnabled = true;
            dinnerDishesLB.ItemHeight = 15;
            dinnerDishesLB.Location = new Point(29, 206);
            dinnerDishesLB.Name = "dinnerDishesLB";
            dinnerDishesLB.Size = new Size(233, 139);
            dinnerDishesLB.TabIndex = 9;
            // 
            // supperDishesLB
            // 
            supperDishesLB.FormattingEnabled = true;
            supperDishesLB.ItemHeight = 15;
            supperDishesLB.Location = new Point(29, 381);
            supperDishesLB.Name = "supperDishesLB";
            supperDishesLB.Size = new Size(233, 139);
            supperDishesLB.TabIndex = 9;
            // 
            // breakfastDishCB
            // 
            breakfastDishCB.FormattingEnabled = true;
            breakfastDishCB.Location = new Point(282, 21);
            breakfastDishCB.Name = "breakfastDishCB";
            breakfastDishCB.Size = new Size(188, 23);
            breakfastDishCB.TabIndex = 16;
            // 
            // dinnerDishCB
            // 
            dinnerDishCB.FormattingEnabled = true;
            dinnerDishCB.Location = new Point(282, 206);
            dinnerDishCB.Name = "dinnerDishCB";
            dinnerDishCB.Size = new Size(188, 23);
            dinnerDishCB.TabIndex = 16;
            // 
            // supperDishCB
            // 
            supperDishCB.FormattingEnabled = true;
            supperDishCB.Location = new Point(282, 381);
            supperDishCB.Name = "supperDishCB";
            supperDishCB.Size = new Size(188, 23);
            supperDishCB.TabIndex = 16;
            // 
            // buttonui2
            // 
            buttonui2.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            buttonui2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui2.ForeColor = Color.White;
            buttonui2.Location = new Point(282, 264);
            buttonui2.middleColorBtn = Color.FromArgb(189, 195, 199);
            buttonui2.Name = "buttonui2";
            buttonui2.Rounding = 33;
            buttonui2.RoundingEnable = true;
            buttonui2.Size = new Size(188, 36);
            buttonui2.startColorBtn = Color.FromArgb(127, 140, 141);
            buttonui2.TabIndex = 14;
            buttonui2.Text = "Добавить";
            buttonui2.TextHover = "Добавить блюдо на обед";
            // 
            // buttonui3
            // 
            buttonui3.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            buttonui3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonui3.ForeColor = Color.White;
            buttonui3.Location = new Point(282, 439);
            buttonui3.middleColorBtn = Color.FromArgb(189, 195, 199);
            buttonui3.Name = "buttonui3";
            buttonui3.Rounding = 33;
            buttonui3.RoundingEnable = true;
            buttonui3.Size = new Size(188, 36);
            buttonui3.startColorBtn = Color.FromArgb(127, 140, 141);
            buttonui3.TabIndex = 14;
            buttonui3.Text = "Добавить";
            buttonui3.TextHover = "Добавить блюдо на ужин";
            // 
            // breakfastDishWeightField
            // 
            breakfastDishWeightField.Location = new Point(282, 50);
            breakfastDishWeightField.Name = "breakfastDishWeightField";
            breakfastDishWeightField.Size = new Size(100, 23);
            breakfastDishWeightField.TabIndex = 17;
            // 
            // dinnerDishWeightField
            // 
            dinnerDishWeightField.Location = new Point(282, 235);
            dinnerDishWeightField.Name = "dinnerDishWeightField";
            dinnerDishWeightField.Size = new Size(100, 23);
            dinnerDishWeightField.TabIndex = 17;
            // 
            // supperDishWeightField
            // 
            supperDishWeightField.Location = new Point(282, 410);
            supperDishWeightField.Name = "supperDishWeightField";
            supperDishWeightField.Size = new Size(100, 23);
            supperDishWeightField.TabIndex = 17;
            // 
            // deleteDinnerDishBtn
            // 
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
            // 
            // deleteBreakfastDishBtn
            // 
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
            // 
            // deleteSupperDishBtn
            // 
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
            // 
            // breakfastProdsLB
            // 
            breakfastProdsLB.FormattingEnabled = true;
            breakfastProdsLB.ItemHeight = 15;
            breakfastProdsLB.Location = new Point(487, 21);
            breakfastProdsLB.Name = "breakfastProdsLB";
            breakfastProdsLB.Size = new Size(233, 139);
            breakfastProdsLB.TabIndex = 9;
            // 
            // dinnerProdsLB
            // 
            dinnerProdsLB.FormattingEnabled = true;
            dinnerProdsLB.ItemHeight = 15;
            dinnerProdsLB.Location = new Point(487, 203);
            dinnerProdsLB.Name = "dinnerProdsLB";
            dinnerProdsLB.Size = new Size(233, 139);
            dinnerProdsLB.TabIndex = 9;
            // 
            // supperProdsLB
            // 
            supperProdsLB.FormattingEnabled = true;
            supperProdsLB.ItemHeight = 15;
            supperProdsLB.Location = new Point(487, 381);
            supperProdsLB.Name = "supperProdsLB";
            supperProdsLB.Size = new Size(233, 139);
            supperProdsLB.TabIndex = 9;
            // 
            // dayProdsLB
            // 
            dayProdsLB.FormattingEnabled = true;
            dayProdsLB.ItemHeight = 15;
            dayProdsLB.Location = new Point(758, 21);
            dayProdsLB.Name = "dayProdsLB";
            dayProdsLB.Size = new Size(233, 499);
            dayProdsLB.TabIndex = 9;
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
            // MenusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 601);
            Controls.Add(dateOfJournal);
            Controls.Add(supperDishWeightField);
            Controls.Add(dinnerDishWeightField);
            Controls.Add(breakfastDishWeightField);
            Controls.Add(supperDishCB);
            Controls.Add(dinnerDishCB);
            Controls.Add(breakfastDishCB);
            Controls.Add(backBtn);
            Controls.Add(buttonui3);
            Controls.Add(deleteSupperDishBtn);
            Controls.Add(deleteBreakfastDishBtn);
            Controls.Add(deleteDinnerDishBtn);
            Controls.Add(buttonui2);
            Controls.Add(addDishBtn);
            Controls.Add(supperDishesLB);
            Controls.Add(dinnerDishesLB);
            Controls.Add(supperProdsLB);
            Controls.Add(dinnerProdsLB);
            Controls.Add(dayProdsLB);
            Controls.Add(breakfastProdsLB);
            Controls.Add(breakfastDishesLB);
            Name = "MenusForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню на день";
            Load += MenusForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UIElements.EgoldsFormStyle egoldsFormStyle1;
        private ListBox breakfastDishesLB;
        private UXElements.buttonUI addDishBtn;
        private UXElements.buttonUI backBtn;
        private ListBox supperDishesLB;
        private ListBox dinnerDishesLB;
        private ComboBox supperDishCB;
        private ComboBox dinnerDishCB;
        private ComboBox breakfastDishCB;
        private UXElements.buttonUI buttonui2;
        private TextBox supperDishWeightField;
        private TextBox dinnerDishWeightField;
        private TextBox breakfastDishWeightField;
        private UXElements.buttonUI buttonui3;
        private UXElements.buttonUI deleteDinnerDishBtn;
        private UXElements.buttonUI deleteSupperDishBtn;
        private UXElements.buttonUI deleteBreakfastDishBtn;
        private ListBox supperProdsLB;
        private ListBox dinnerProdsLB;
        private ListBox breakfastProdsLB;
        private ListBox dayProdsLB;
        private DateTimePicker dateOfJournal;
    }
}