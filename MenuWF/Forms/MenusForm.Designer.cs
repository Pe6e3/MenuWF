﻿namespace MenuWF.Forms
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
            breakfastProdsLB = new ListBox();
            dinnerProdsLB = new ListBox();
            supperProdsLB = new ListBox();
            dayProdsLB = new ListBox();
            dateOfJournal = new DateTimePicker();
            breakfastDishesLW = new ListView();
            dinnerDishesLW = new ListView();
            supperDishesLW = new ListView();
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
            // addDinnerDishBtn
            // 
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
            // breakfastDishesLW
            // 
            breakfastDishesLW.Location = new Point(12, 21);
            breakfastDishesLW.Name = "breakfastDishesLW";
            breakfastDishesLW.Size = new Size(232, 139);
            breakfastDishesLW.TabIndex = 19;
            breakfastDishesLW.UseCompatibleStateImageBehavior = false;
            // 
            // dinnerDishesLW
            // 
            dinnerDishesLW.Location = new Point(12, 206);
            dinnerDishesLW.Name = "dinnerDishesLW";
            dinnerDishesLW.Size = new Size(232, 139);
            dinnerDishesLW.TabIndex = 19;
            dinnerDishesLW.UseCompatibleStateImageBehavior = false;
            // 
            // supperDishesLW
            // 
            supperDishesLW.Location = new Point(12, 381);
            supperDishesLW.Name = "supperDishesLW";
            supperDishesLW.Size = new Size(232, 139);
            supperDishesLW.TabIndex = 19;
            supperDishesLW.UseCompatibleStateImageBehavior = false;
            // 
            // MenusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 601);
            Controls.Add(supperDishesLW);
            Controls.Add(dinnerDishesLW);
            Controls.Add(breakfastDishesLW);
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
            Controls.Add(supperProdsLB);
            Controls.Add(dinnerProdsLB);
            Controls.Add(dayProdsLB);
            Controls.Add(breakfastProdsLB);
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
        private ListBox supperProdsLB;
        private ListBox dinnerProdsLB;
        private ListBox breakfastProdsLB;
        private ListBox dayProdsLB;
        private DateTimePicker dateOfJournal;
        private ListView supperDishesLW;
        private ListView dinnerDishesLW;
        private ListView breakfastDishesLW;
    }
}