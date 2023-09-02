using MenuWF.UIElements;

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
            egoldsFormStyle1 = new EgoldsFormStyle(components);
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
            protsLabel = new Label();
            personCountField = new TextBox();
            infoLabelTite = new Label();
            fatsLabel = new Label();
            carbsLabel = new Label();
            caloriesLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            infoLabelProts = new Label();
            infoLabelFats = new Label();
            infoLabelCarbs = new Label();
            infoLabelCalories = new Label();
            infoLabelCountPerson = new Label();
            protsPercentLabel = new Label();
            fatsPercentLabel = new Label();
            carbsPercentLabel = new Label();
            caloriesPercentLabel = new Label();
            breakfastPanel = new RoundedPanel();
            bfDecreaseBtn = new UXElements.buttonUI();
            bfIncreaseBtn = new UXElements.buttonUI();
            label5 = new Label();
            dinnerPanel = new Panel();
            dinnerDecreaseBtn = new UXElements.buttonUI();
            dinnerIncreaseBtn = new UXElements.buttonUI();
            label6 = new Label();
            supperPanel = new Panel();
            supperDecreaseBtn = new UXElements.buttonUI();
            supperIncreaseBtn = new UXElements.buttonUI();
            label7 = new Label();
            resultsPanel = new Panel();
            protsProgressBar = new ProgressBar();
            label10 = new Label();
            prodPerPersonLabel = new Label();
            prodWeightSumLabel = new Label();
            label8 = new Label();
            label4 = new Label();
            fatsProgressBar = new ProgressBar();
            carbsProgressBar = new ProgressBar();
            caloriesProgressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            breakfastPanel.SuspendLayout();
            dinnerPanel.SuspendLayout();
            supperPanel.SuspendLayout();
            resultsPanel.SuspendLayout();
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
            egoldsFormStyle1.FormStyle = EgoldsFormStyle.fStyle.UserStyle;
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
            addBreakfastDishBtn.BackColor = Color.Transparent;
            addBreakfastDishBtn.Enabled = false;
            addBreakfastDishBtn.endColorBorderBtn = Color.LimeGreen;
            addBreakfastDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBreakfastDishBtn.ForeColor = Color.LemonChiffon;
            addBreakfastDishBtn.Location = new Point(277, 82);
            addBreakfastDishBtn.middleColorBtn = Color.ForestGreen;
            addBreakfastDishBtn.Name = "addBreakfastDishBtn";
            addBreakfastDishBtn.Rounding = 33;
            addBreakfastDishBtn.RoundingEnable = true;
            addBreakfastDishBtn.Size = new Size(188, 36);
            addBreakfastDishBtn.startColorBtn = Color.YellowGreen;
            addBreakfastDishBtn.TabIndex = 14;
            addBreakfastDishBtn.Text = "Добавить";
            addBreakfastDishBtn.TextHover = "Добавить блюдо на завтрак";
            addBreakfastDishBtn.Click += addBreakfastDishBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            backBtn.Font = new Font("Candara Light", 35F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.LightCyan;
            backBtn.Location = new Point(16, 12);
            backBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            backBtn.Name = "backBtn";
            backBtn.Rounding = 33;
            backBtn.RoundingEnable = true;
            backBtn.Size = new Size(67, 33);
            backBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            backBtn.TabIndex = 15;
            backBtn.Text = "←";
            backBtn.TextHover = "назад";
            backBtn.Click += backBtn_Click;
            // 
            // breakfastDishCB
            // 
            breakfastDishCB.DropDownStyle = ComboBoxStyle.DropDownList;
            breakfastDishCB.FormattingEnabled = true;
            breakfastDishCB.Location = new Point(277, 24);
            breakfastDishCB.Name = "breakfastDishCB";
            breakfastDishCB.Size = new Size(188, 23);
            breakfastDishCB.TabIndex = 16;
            // 
            // dinnerDishCB
            // 
            dinnerDishCB.DropDownStyle = ComboBoxStyle.DropDownList;
            dinnerDishCB.FormattingEnabled = true;
            dinnerDishCB.Location = new Point(277, 23);
            dinnerDishCB.Name = "dinnerDishCB";
            dinnerDishCB.Size = new Size(188, 23);
            dinnerDishCB.TabIndex = 16;
            // 
            // supperDishCB
            // 
            supperDishCB.DropDownStyle = ComboBoxStyle.DropDownList;
            supperDishCB.FormattingEnabled = true;
            supperDishCB.Location = new Point(277, 23);
            supperDishCB.MaxDropDownItems = 15;
            supperDishCB.Name = "supperDishCB";
            supperDishCB.Size = new Size(188, 23);
            supperDishCB.TabIndex = 16;
            // 
            // addDinnerDishBtn
            // 
            addDinnerDishBtn.BackColor = Color.Transparent;
            addDinnerDishBtn.Enabled = false;
            addDinnerDishBtn.endColorBorderBtn = Color.LimeGreen;
            addDinnerDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addDinnerDishBtn.ForeColor = Color.LemonChiffon;
            addDinnerDishBtn.Location = new Point(277, 81);
            addDinnerDishBtn.middleColorBtn = Color.ForestGreen;
            addDinnerDishBtn.Name = "addDinnerDishBtn";
            addDinnerDishBtn.Rounding = 33;
            addDinnerDishBtn.RoundingEnable = true;
            addDinnerDishBtn.Size = new Size(188, 36);
            addDinnerDishBtn.startColorBtn = Color.YellowGreen;
            addDinnerDishBtn.TabIndex = 14;
            addDinnerDishBtn.Text = "Добавить";
            addDinnerDishBtn.TextHover = "Добавить блюдо на обед";
            addDinnerDishBtn.Click += addDinnerDishBtn_Click;
            // 
            // addSupperDishBtn
            // 
            addSupperDishBtn.BackColor = Color.Transparent;
            addSupperDishBtn.Enabled = false;
            addSupperDishBtn.endColorBorderBtn = Color.LimeGreen;
            addSupperDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addSupperDishBtn.ForeColor = Color.LemonChiffon;
            addSupperDishBtn.Location = new Point(277, 81);
            addSupperDishBtn.middleColorBtn = Color.ForestGreen;
            addSupperDishBtn.Name = "addSupperDishBtn";
            addSupperDishBtn.Rounding = 33;
            addSupperDishBtn.RoundingEnable = true;
            addSupperDishBtn.Size = new Size(188, 36);
            addSupperDishBtn.startColorBtn = Color.YellowGreen;
            addSupperDishBtn.TabIndex = 14;
            addSupperDishBtn.Text = "Добавить";
            addSupperDishBtn.TextHover = "Добавить блюдо на ужин";
            addSupperDishBtn.Click += addSupperDishBtn_Click;
            // 
            // breakfastDishWeightField
            // 
            breakfastDishWeightField.Location = new Point(341, 53);
            breakfastDishWeightField.Name = "breakfastDishWeightField";
            breakfastDishWeightField.Size = new Size(69, 23);
            breakfastDishWeightField.TabIndex = 17;
            breakfastDishWeightField.TextAlign = HorizontalAlignment.Center;
            breakfastDishWeightField.TextChanged += breakfastDishWeightField_TextChanged;
            // 
            // dinnerDishWeightField
            // 
            dinnerDishWeightField.Location = new Point(341, 52);
            dinnerDishWeightField.Name = "dinnerDishWeightField";
            dinnerDishWeightField.Size = new Size(69, 23);
            dinnerDishWeightField.TabIndex = 17;
            dinnerDishWeightField.TextAlign = HorizontalAlignment.Center;
            dinnerDishWeightField.TextChanged += dinnerDishWeightField_TextChanged;
            // 
            // supperDishWeightField
            // 
            supperDishWeightField.Location = new Point(341, 52);
            supperDishWeightField.Name = "supperDishWeightField";
            supperDishWeightField.Size = new Size(69, 23);
            supperDishWeightField.TabIndex = 17;
            supperDishWeightField.TextAlign = HorizontalAlignment.Center;
            supperDishWeightField.TextChanged += supperDishWeightField_TextChanged;
            // 
            // deleteDinnerDishBtn
            // 
            deleteDinnerDishBtn.BackColor = Color.Transparent;
            deleteDinnerDishBtn.Enabled = false;
            deleteDinnerDishBtn.endColorBorderBtn = Color.DarkOrange;
            deleteDinnerDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteDinnerDishBtn.ForeColor = Color.Sienna;
            deleteDinnerDishBtn.Location = new Point(277, 155);
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
            deleteBreakfastDishBtn.BackColor = Color.Transparent;
            deleteBreakfastDishBtn.Enabled = false;
            deleteBreakfastDishBtn.endColorBorderBtn = Color.DarkOrange;
            deleteBreakfastDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBreakfastDishBtn.ForeColor = Color.Sienna;
            deleteBreakfastDishBtn.Location = new Point(277, 156);
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
            deleteSupperDishBtn.BackColor = Color.Transparent;
            deleteSupperDishBtn.Enabled = false;
            deleteSupperDishBtn.endColorBorderBtn = Color.DarkOrange;
            deleteSupperDishBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSupperDishBtn.ForeColor = Color.Sienna;
            deleteSupperDishBtn.Location = new Point(277, 155);
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
            dateOfJournal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateOfJournal.Format = DateTimePickerFormat.Short;
            dateOfJournal.Location = new Point(888, 14);
            dateOfJournal.Name = "dateOfJournal";
            dateOfJournal.Size = new Size(130, 33);
            dateOfJournal.TabIndex = 18;
            dateOfJournal.Value = new DateTime(2023, 9, 1, 0, 0, 0, 0);
            dateOfJournal.ValueChanged += dateOfJournal_ValueChanged;
            // 
            // breakfastDishesLV
            // 
            breakfastDishesLV.BackColor = Color.WhiteSmoke;
            breakfastDishesLV.Location = new Point(16, 24);
            breakfastDishesLV.Name = "breakfastDishesLV";
            breakfastDishesLV.Size = new Size(230, 140);
            breakfastDishesLV.TabIndex = 19;
            breakfastDishesLV.UseCompatibleStateImageBehavior = false;
            breakfastDishesLV.SelectedIndexChanged += breakfastDishesLV_SelectedIndexChanged;
            // 
            // dinnerDishesLV
            // 
            dinnerDishesLV.BackColor = Color.WhiteSmoke;
            dinnerDishesLV.Location = new Point(16, 23);
            dinnerDishesLV.Name = "dinnerDishesLV";
            dinnerDishesLV.Size = new Size(230, 140);
            dinnerDishesLV.TabIndex = 19;
            dinnerDishesLV.UseCompatibleStateImageBehavior = false;
            dinnerDishesLV.SelectedIndexChanged += dinnerDishesLV_SelectedIndexChanged;
            // 
            // supperDishesLV
            // 
            supperDishesLV.BackColor = Color.WhiteSmoke;
            supperDishesLV.Location = new Point(16, 23);
            supperDishesLV.Name = "supperDishesLV";
            supperDishesLV.Size = new Size(230, 140);
            supperDishesLV.TabIndex = 19;
            supperDishesLV.UseCompatibleStateImageBehavior = false;
            supperDishesLV.SelectedIndexChanged += supperDishesLV_SelectedIndexChanged;
            // 
            // breakfastProductsLV
            // 
            breakfastProductsLV.BackColor = Color.WhiteSmoke;
            breakfastProductsLV.Location = new Point(495, 24);
            breakfastProductsLV.Name = "breakfastProductsLV";
            breakfastProductsLV.Size = new Size(233, 163);
            breakfastProductsLV.TabIndex = 19;
            breakfastProductsLV.UseCompatibleStateImageBehavior = false;
            // 
            // dinnerProductsLV
            // 
            dinnerProductsLV.BackColor = Color.WhiteSmoke;
            dinnerProductsLV.Location = new Point(497, 23);
            dinnerProductsLV.Name = "dinnerProductsLV";
            dinnerProductsLV.Size = new Size(233, 163);
            dinnerProductsLV.TabIndex = 19;
            dinnerProductsLV.UseCompatibleStateImageBehavior = false;
            // 
            // supperProductsLV
            // 
            supperProductsLV.BackColor = Color.WhiteSmoke;
            supperProductsLV.Location = new Point(496, 23);
            supperProductsLV.Name = "supperProductsLV";
            supperProductsLV.Size = new Size(233, 163);
            supperProductsLV.TabIndex = 19;
            supperProductsLV.UseCompatibleStateImageBehavior = false;
            // 
            // dayProdsLV
            // 
            dayProdsLV.BackColor = Color.WhiteSmoke;
            dayProdsLV.Location = new Point(11, 34);
            dayProdsLV.Name = "dayProdsLV";
            dayProdsLV.Size = new Size(215, 351);
            dayProdsLV.TabIndex = 19;
            dayProdsLV.UseCompatibleStateImageBehavior = false;
            // 
            // breakfastSumWeightDishesLabel
            // 
            breakfastSumWeightDishesLabel.BorderStyle = BorderStyle.Fixed3D;
            breakfastSumWeightDishesLabel.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            breakfastSumWeightDishesLabel.ForeColor = Color.DarkRed;
            breakfastSumWeightDishesLabel.Location = new Point(166, 167);
            breakfastSumWeightDishesLabel.Name = "breakfastSumWeightDishesLabel";
            breakfastSumWeightDishesLabel.Size = new Size(80, 25);
            breakfastSumWeightDishesLabel.TabIndex = 20;
            breakfastSumWeightDishesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dinnerSumWeightDishesLabel
            // 
            dinnerSumWeightDishesLabel.BorderStyle = BorderStyle.Fixed3D;
            dinnerSumWeightDishesLabel.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dinnerSumWeightDishesLabel.ForeColor = Color.DarkRed;
            dinnerSumWeightDishesLabel.Location = new Point(162, 166);
            dinnerSumWeightDishesLabel.Name = "dinnerSumWeightDishesLabel";
            dinnerSumWeightDishesLabel.Size = new Size(80, 25);
            dinnerSumWeightDishesLabel.TabIndex = 20;
            dinnerSumWeightDishesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // supperSumWeightDishesLabel
            // 
            supperSumWeightDishesLabel.BorderStyle = BorderStyle.Fixed3D;
            supperSumWeightDishesLabel.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            supperSumWeightDishesLabel.ForeColor = Color.DarkRed;
            supperSumWeightDishesLabel.Location = new Point(166, 166);
            supperSumWeightDishesLabel.Name = "supperSumWeightDishesLabel";
            supperSumWeightDishesLabel.Size = new Size(80, 25);
            supperSumWeightDishesLabel.TabIndex = 20;
            supperSumWeightDishesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // protsLabel
            // 
            protsLabel.BorderStyle = BorderStyle.Fixed3D;
            protsLabel.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            protsLabel.ForeColor = Color.DarkRed;
            protsLabel.Location = new Point(80, 506);
            protsLabel.Name = "protsLabel";
            protsLabel.Size = new Size(42, 23);
            protsLabel.TabIndex = 20;
            protsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // personCountField
            // 
            personCountField.BackColor = Color.WhiteSmoke;
            personCountField.Location = new Point(173, 437);
            personCountField.Name = "personCountField";
            personCountField.Size = new Size(53, 23);
            personCountField.TabIndex = 17;
            personCountField.Text = "20";
            personCountField.TextAlign = HorizontalAlignment.Center;
            personCountField.TextChanged += personCountField_TextChanged;
            // 
            // infoLabelTite
            // 
            infoLabelTite.BackColor = Color.Transparent;
            infoLabelTite.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabelTite.ForeColor = Color.DarkRed;
            infoLabelTite.Location = new Point(-1, 475);
            infoLabelTite.Name = "infoLabelTite";
            infoLabelTite.Size = new Size(241, 31);
            infoLabelTite.TabIndex = 20;
            infoLabelTite.Text = "Итого КБЖУ на человека:";
            infoLabelTite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fatsLabel
            // 
            fatsLabel.BorderStyle = BorderStyle.Fixed3D;
            fatsLabel.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            fatsLabel.ForeColor = Color.DarkRed;
            fatsLabel.Location = new Point(80, 531);
            fatsLabel.Name = "fatsLabel";
            fatsLabel.Size = new Size(42, 23);
            fatsLabel.TabIndex = 20;
            fatsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // carbsLabel
            // 
            carbsLabel.BorderStyle = BorderStyle.Fixed3D;
            carbsLabel.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            carbsLabel.ForeColor = Color.DarkRed;
            carbsLabel.Location = new Point(80, 556);
            carbsLabel.Name = "carbsLabel";
            carbsLabel.Size = new Size(42, 23);
            carbsLabel.TabIndex = 20;
            carbsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // caloriesLabel
            // 
            caloriesLabel.BorderStyle = BorderStyle.Fixed3D;
            caloriesLabel.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            caloriesLabel.ForeColor = Color.DarkRed;
            caloriesLabel.Location = new Point(80, 581);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(42, 23);
            caloriesLabel.TabIndex = 20;
            caloriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(16, 2);
            label1.Name = "label1";
            label1.Size = new Size(230, 23);
            label1.TabIndex = 20;
            label1.Text = "Блюда на завтрак";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(230, 23);
            label2.TabIndex = 20;
            label2.Text = "Блюда на обед";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(16, 0);
            label3.Name = "label3";
            label3.Size = new Size(230, 23);
            label3.TabIndex = 20;
            label3.Text = "Блюда на ужин";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // infoLabelProts
            // 
            infoLabelProts.BackColor = Color.Transparent;
            infoLabelProts.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabelProts.ForeColor = Color.DarkRed;
            infoLabelProts.Location = new Point(2, 507);
            infoLabelProts.Name = "infoLabelProts";
            infoLabelProts.Size = new Size(77, 21);
            infoLabelProts.TabIndex = 20;
            infoLabelProts.Text = "Белки:";
            infoLabelProts.TextAlign = ContentAlignment.MiddleRight;
            // 
            // infoLabelFats
            // 
            infoLabelFats.BackColor = Color.Transparent;
            infoLabelFats.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabelFats.ForeColor = Color.DarkRed;
            infoLabelFats.Location = new Point(2, 532);
            infoLabelFats.Name = "infoLabelFats";
            infoLabelFats.Size = new Size(77, 21);
            infoLabelFats.TabIndex = 20;
            infoLabelFats.Text = "Жиры:";
            infoLabelFats.TextAlign = ContentAlignment.MiddleRight;
            // 
            // infoLabelCarbs
            // 
            infoLabelCarbs.BackColor = Color.Transparent;
            infoLabelCarbs.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabelCarbs.ForeColor = Color.DarkRed;
            infoLabelCarbs.Location = new Point(2, 557);
            infoLabelCarbs.Name = "infoLabelCarbs";
            infoLabelCarbs.Size = new Size(77, 21);
            infoLabelCarbs.TabIndex = 20;
            infoLabelCarbs.Text = "Углеводы:";
            infoLabelCarbs.TextAlign = ContentAlignment.MiddleRight;
            // 
            // infoLabelCalories
            // 
            infoLabelCalories.BackColor = Color.Transparent;
            infoLabelCalories.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabelCalories.ForeColor = Color.DarkRed;
            infoLabelCalories.Location = new Point(2, 581);
            infoLabelCalories.Name = "infoLabelCalories";
            infoLabelCalories.Size = new Size(77, 21);
            infoLabelCalories.TabIndex = 20;
            infoLabelCalories.Text = "Калории:";
            infoLabelCalories.TextAlign = ContentAlignment.MiddleRight;
            // 
            // infoLabelCountPerson
            // 
            infoLabelCountPerson.BackColor = Color.Transparent;
            infoLabelCountPerson.Font = new Font("Palatino Linotype", 7F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabelCountPerson.ForeColor = Color.DarkRed;
            infoLabelCountPerson.Location = new Point(35, 435);
            infoLabelCountPerson.Name = "infoLabelCountPerson";
            infoLabelCountPerson.Size = new Size(127, 25);
            infoLabelCountPerson.TabIndex = 20;
            infoLabelCountPerson.Text = "Количество персон:";
            infoLabelCountPerson.TextAlign = ContentAlignment.MiddleRight;
            // 
            // protsPercentLabel
            // 
            protsPercentLabel.BackColor = Color.Transparent;
            protsPercentLabel.Font = new Font("Palatino Linotype", 7F, FontStyle.Bold, GraphicsUnit.Point);
            protsPercentLabel.ForeColor = Color.DarkRed;
            protsPercentLabel.Location = new Point(125, 506);
            protsPercentLabel.Name = "protsPercentLabel";
            protsPercentLabel.Size = new Size(34, 21);
            protsPercentLabel.TabIndex = 20;
            protsPercentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fatsPercentLabel
            // 
            fatsPercentLabel.BackColor = Color.Transparent;
            fatsPercentLabel.Font = new Font("Palatino Linotype", 7F, FontStyle.Bold, GraphicsUnit.Point);
            fatsPercentLabel.ForeColor = Color.DarkRed;
            fatsPercentLabel.Location = new Point(125, 531);
            fatsPercentLabel.Name = "fatsPercentLabel";
            fatsPercentLabel.Size = new Size(34, 21);
            fatsPercentLabel.TabIndex = 20;
            fatsPercentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // carbsPercentLabel
            // 
            carbsPercentLabel.BackColor = Color.Transparent;
            carbsPercentLabel.Font = new Font("Palatino Linotype", 7F, FontStyle.Bold, GraphicsUnit.Point);
            carbsPercentLabel.ForeColor = Color.DarkRed;
            carbsPercentLabel.Location = new Point(125, 556);
            carbsPercentLabel.Name = "carbsPercentLabel";
            carbsPercentLabel.Size = new Size(34, 21);
            carbsPercentLabel.TabIndex = 20;
            carbsPercentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // caloriesPercentLabel
            // 
            caloriesPercentLabel.BackColor = Color.Transparent;
            caloriesPercentLabel.Font = new Font("Palatino Linotype", 7F, FontStyle.Bold, GraphicsUnit.Point);
            caloriesPercentLabel.ForeColor = Color.DarkRed;
            caloriesPercentLabel.Location = new Point(125, 581);
            caloriesPercentLabel.Name = "caloriesPercentLabel";
            caloriesPercentLabel.Size = new Size(34, 21);
            caloriesPercentLabel.TabIndex = 20;
            caloriesPercentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // breakfastPanel
            // 
            breakfastPanel.BackColor = Color.Transparent;
            breakfastPanel.BorderColor = Color.FromArgb(60, 121, 121, 156);
            breakfastPanel.BorderWidth = 7;
            breakfastPanel.Controls.Add(bfDecreaseBtn);
            breakfastPanel.Controls.Add(bfIncreaseBtn);
            breakfastPanel.Controls.Add(label1);
            breakfastPanel.Controls.Add(breakfastSumWeightDishesLabel);
            breakfastPanel.Controls.Add(breakfastProductsLV);
            breakfastPanel.Controls.Add(breakfastDishesLV);
            breakfastPanel.Controls.Add(breakfastDishWeightField);
            breakfastPanel.Controls.Add(label5);
            breakfastPanel.Controls.Add(breakfastDishCB);
            breakfastPanel.Controls.Add(deleteBreakfastDishBtn);
            breakfastPanel.Controls.Add(addBreakfastDishBtn);
            breakfastPanel.CornerRadius = 12;
            breakfastPanel.Location = new Point(12, 53);
            breakfastPanel.Name = "breakfastPanel";
            breakfastPanel.PanelColor = Color.Silver;
            breakfastPanel.Size = new Size(750, 200);
            breakfastPanel.TabIndex = 21;
            // 
            // bfDecreaseBtn
            // 
            bfDecreaseBtn.BackColor = Color.Transparent;
            bfDecreaseBtn.endColorBorderBtn = Color.SkyBlue;
            bfDecreaseBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bfDecreaseBtn.ForeColor = Color.Indigo;
            bfDecreaseBtn.Location = new Point(315, 53);
            bfDecreaseBtn.middleColorBtn = Color.CornflowerBlue;
            bfDecreaseBtn.Name = "bfDecreaseBtn";
            bfDecreaseBtn.Rounding = 33;
            bfDecreaseBtn.RoundingEnable = true;
            bfDecreaseBtn.Size = new Size(20, 20);
            bfDecreaseBtn.startColorBtn = Color.DeepSkyBlue;
            bfDecreaseBtn.TabIndex = 22;
            bfDecreaseBtn.Text = "-";
            bfDecreaseBtn.TextHover = "";
            bfDecreaseBtn.Click += bfDecreaseBtn_Click;
            // 
            // bfIncreaseBtn
            // 
            bfIncreaseBtn.BackColor = Color.Transparent;
            bfIncreaseBtn.endColorBorderBtn = Color.SkyBlue;
            bfIncreaseBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bfIncreaseBtn.ForeColor = Color.Indigo;
            bfIncreaseBtn.Location = new Point(416, 53);
            bfIncreaseBtn.middleColorBtn = Color.CornflowerBlue;
            bfIncreaseBtn.Name = "bfIncreaseBtn";
            bfIncreaseBtn.Rounding = 33;
            bfIncreaseBtn.RoundingEnable = true;
            bfIncreaseBtn.Size = new Size(20, 20);
            bfIncreaseBtn.startColorBtn = Color.DeepSkyBlue;
            bfIncreaseBtn.TabIndex = 21;
            bfIncreaseBtn.Text = "+";
            bfIncreaseBtn.TextHover = "";
            bfIncreaseBtn.Click += bfIncreaseBtn_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(497, 0);
            label5.Name = "label5";
            label5.Size = new Size(230, 23);
            label5.TabIndex = 20;
            label5.Text = "Продукты на завтрак";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dinnerPanel
            // 
            dinnerPanel.BackColor = Color.FromArgb(30, 250, 150, 0);
            dinnerPanel.Controls.Add(dinnerDecreaseBtn);
            dinnerPanel.Controls.Add(dinnerSumWeightDishesLabel);
            dinnerPanel.Controls.Add(dinnerIncreaseBtn);
            dinnerPanel.Controls.Add(label2);
            dinnerPanel.Controls.Add(dinnerProductsLV);
            dinnerPanel.Controls.Add(dinnerDishesLV);
            dinnerPanel.Controls.Add(dinnerDishWeightField);
            dinnerPanel.Controls.Add(label6);
            dinnerPanel.Controls.Add(dinnerDishCB);
            dinnerPanel.Controls.Add(deleteDinnerDishBtn);
            dinnerPanel.Controls.Add(addDinnerDishBtn);
            dinnerPanel.Location = new Point(12, 264);
            dinnerPanel.Name = "dinnerPanel";
            dinnerPanel.Size = new Size(750, 200);
            dinnerPanel.TabIndex = 22;
            // 
            // dinnerDecreaseBtn
            // 
            dinnerDecreaseBtn.BackColor = Color.Transparent;
            dinnerDecreaseBtn.endColorBorderBtn = Color.SkyBlue;
            dinnerDecreaseBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dinnerDecreaseBtn.ForeColor = Color.Indigo;
            dinnerDecreaseBtn.Location = new Point(315, 52);
            dinnerDecreaseBtn.middleColorBtn = Color.CornflowerBlue;
            dinnerDecreaseBtn.Name = "dinnerDecreaseBtn";
            dinnerDecreaseBtn.Rounding = 33;
            dinnerDecreaseBtn.RoundingEnable = true;
            dinnerDecreaseBtn.Size = new Size(20, 20);
            dinnerDecreaseBtn.startColorBtn = Color.DeepSkyBlue;
            dinnerDecreaseBtn.TabIndex = 22;
            dinnerDecreaseBtn.Text = "-";
            dinnerDecreaseBtn.TextHover = "";
            dinnerDecreaseBtn.Click += dinnerDecreaseBtn_Click;
            // 
            // dinnerIncreaseBtn
            // 
            dinnerIncreaseBtn.BackColor = Color.Transparent;
            dinnerIncreaseBtn.endColorBorderBtn = Color.SkyBlue;
            dinnerIncreaseBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dinnerIncreaseBtn.ForeColor = Color.Indigo;
            dinnerIncreaseBtn.Location = new Point(416, 52);
            dinnerIncreaseBtn.middleColorBtn = Color.CornflowerBlue;
            dinnerIncreaseBtn.Name = "dinnerIncreaseBtn";
            dinnerIncreaseBtn.Rounding = 33;
            dinnerIncreaseBtn.RoundingEnable = true;
            dinnerIncreaseBtn.Size = new Size(20, 20);
            dinnerIncreaseBtn.startColorBtn = Color.DeepSkyBlue;
            dinnerIncreaseBtn.TabIndex = 21;
            dinnerIncreaseBtn.Text = "+";
            dinnerIncreaseBtn.TextHover = "";
            dinnerIncreaseBtn.Click += dinnerIncreaseBtn_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(497, 0);
            label6.Name = "label6";
            label6.Size = new Size(230, 23);
            label6.TabIndex = 20;
            label6.Text = "Продукты на обед";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // supperPanel
            // 
            supperPanel.BackColor = Color.FromArgb(30, 250, 150, 0);
            supperPanel.Controls.Add(supperDecreaseBtn);
            supperPanel.Controls.Add(supperSumWeightDishesLabel);
            supperPanel.Controls.Add(label3);
            supperPanel.Controls.Add(supperIncreaseBtn);
            supperPanel.Controls.Add(supperProductsLV);
            supperPanel.Controls.Add(supperDishesLV);
            supperPanel.Controls.Add(supperDishWeightField);
            supperPanel.Controls.Add(label7);
            supperPanel.Controls.Add(supperDishCB);
            supperPanel.Controls.Add(addSupperDishBtn);
            supperPanel.Controls.Add(deleteSupperDishBtn);
            supperPanel.Location = new Point(12, 476);
            supperPanel.Name = "supperPanel";
            supperPanel.Size = new Size(750, 200);
            supperPanel.TabIndex = 23;
            // 
            // supperDecreaseBtn
            // 
            supperDecreaseBtn.BackColor = Color.Transparent;
            supperDecreaseBtn.endColorBorderBtn = Color.SkyBlue;
            supperDecreaseBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            supperDecreaseBtn.ForeColor = Color.Indigo;
            supperDecreaseBtn.Location = new Point(315, 52);
            supperDecreaseBtn.middleColorBtn = Color.CornflowerBlue;
            supperDecreaseBtn.Name = "supperDecreaseBtn";
            supperDecreaseBtn.Rounding = 33;
            supperDecreaseBtn.RoundingEnable = true;
            supperDecreaseBtn.Size = new Size(20, 20);
            supperDecreaseBtn.startColorBtn = Color.DeepSkyBlue;
            supperDecreaseBtn.TabIndex = 22;
            supperDecreaseBtn.Text = "-";
            supperDecreaseBtn.TextHover = "";
            supperDecreaseBtn.Click += supperDecreaseBtn_Click;
            // 
            // supperIncreaseBtn
            // 
            supperIncreaseBtn.BackColor = Color.Transparent;
            supperIncreaseBtn.endColorBorderBtn = Color.SkyBlue;
            supperIncreaseBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            supperIncreaseBtn.ForeColor = Color.Indigo;
            supperIncreaseBtn.Location = new Point(416, 52);
            supperIncreaseBtn.middleColorBtn = Color.CornflowerBlue;
            supperIncreaseBtn.Name = "supperIncreaseBtn";
            supperIncreaseBtn.Rounding = 33;
            supperIncreaseBtn.RoundingEnable = true;
            supperIncreaseBtn.Size = new Size(20, 20);
            supperIncreaseBtn.startColorBtn = Color.DeepSkyBlue;
            supperIncreaseBtn.TabIndex = 21;
            supperIncreaseBtn.Text = "+";
            supperIncreaseBtn.TextHover = "";
            supperIncreaseBtn.Click += supperIncreaseBtn_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(497, 0);
            label7.Name = "label7";
            label7.Size = new Size(230, 23);
            label7.TabIndex = 20;
            label7.Text = "Продукты на ужин";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultsPanel
            // 
            resultsPanel.BackColor = Color.FromArgb(30, 250, 150, 0);
            resultsPanel.Controls.Add(protsPercentLabel);
            resultsPanel.Controls.Add(protsProgressBar);
            resultsPanel.Controls.Add(label10);
            resultsPanel.Controls.Add(prodPerPersonLabel);
            resultsPanel.Controls.Add(prodWeightSumLabel);
            resultsPanel.Controls.Add(label8);
            resultsPanel.Controls.Add(caloriesPercentLabel);
            resultsPanel.Controls.Add(infoLabelCalories);
            resultsPanel.Controls.Add(carbsPercentLabel);
            resultsPanel.Controls.Add(infoLabelCarbs);
            resultsPanel.Controls.Add(fatsPercentLabel);
            resultsPanel.Controls.Add(infoLabelFats);
            resultsPanel.Controls.Add(label4);
            resultsPanel.Controls.Add(infoLabelCountPerson);
            resultsPanel.Controls.Add(infoLabelProts);
            resultsPanel.Controls.Add(infoLabelTite);
            resultsPanel.Controls.Add(carbsLabel);
            resultsPanel.Controls.Add(fatsLabel);
            resultsPanel.Controls.Add(caloriesLabel);
            resultsPanel.Controls.Add(protsLabel);
            resultsPanel.Controls.Add(personCountField);
            resultsPanel.Controls.Add(dayProdsLV);
            resultsPanel.Controls.Add(fatsProgressBar);
            resultsPanel.Controls.Add(carbsProgressBar);
            resultsPanel.Controls.Add(caloriesProgressBar);
            resultsPanel.Location = new Point(776, 53);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Size = new Size(241, 623);
            resultsPanel.TabIndex = 24;
            // 
            // protsProgressBar
            // 
            protsProgressBar.Location = new Point(159, 506);
            protsProgressBar.Name = "protsProgressBar";
            protsProgressBar.Size = new Size(67, 22);
            protsProgressBar.TabIndex = 24;
            protsProgressBar.Value = 50;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Palatino Linotype", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkRed;
            label10.Location = new Point(35, 409);
            label10.Name = "label10";
            label10.Size = new Size(126, 25);
            label10.TabIndex = 23;
            label10.Text = "На человека";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // prodPerPersonLabel
            // 
            prodPerPersonLabel.BorderStyle = BorderStyle.Fixed3D;
            prodPerPersonLabel.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            prodPerPersonLabel.ForeColor = Color.DarkRed;
            prodPerPersonLabel.Location = new Point(173, 411);
            prodPerPersonLabel.Name = "prodPerPersonLabel";
            prodPerPersonLabel.Size = new Size(53, 23);
            prodPerPersonLabel.TabIndex = 22;
            // 
            // prodWeightSumLabel
            // 
            prodWeightSumLabel.BorderStyle = BorderStyle.Fixed3D;
            prodWeightSumLabel.Font = new Font("Palatino Linotype", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            prodWeightSumLabel.ForeColor = Color.DarkRed;
            prodWeightSumLabel.Location = new Point(173, 388);
            prodWeightSumLabel.Name = "prodWeightSumLabel";
            prodWeightSumLabel.Size = new Size(53, 23);
            prodWeightSumLabel.TabIndex = 22;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Palatino Linotype", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(35, 390);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 21;
            label8.Text = "Всего продуктов";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(49, 5);
            label4.Name = "label4";
            label4.Size = new Size(154, 23);
            label4.TabIndex = 20;
            label4.Text = "Все продукты на день";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fatsProgressBar
            // 
            fatsProgressBar.Location = new Point(159, 531);
            fatsProgressBar.Name = "fatsProgressBar";
            fatsProgressBar.Size = new Size(67, 22);
            fatsProgressBar.TabIndex = 24;
            fatsProgressBar.Value = 50;
            // 
            // carbsProgressBar
            // 
            carbsProgressBar.Location = new Point(159, 556);
            carbsProgressBar.Name = "carbsProgressBar";
            carbsProgressBar.Size = new Size(67, 22);
            carbsProgressBar.TabIndex = 24;
            carbsProgressBar.Value = 50;
            // 
            // caloriesProgressBar
            // 
            caloriesProgressBar.Location = new Point(159, 581);
            caloriesProgressBar.Name = "caloriesProgressBar";
            caloriesProgressBar.Size = new Size(67, 22);
            caloriesProgressBar.TabIndex = 24;
            caloriesProgressBar.Value = 50;
            // 
            // MenusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1026, 686);
            Controls.Add(resultsPanel);
            Controls.Add(supperPanel);
            Controls.Add(dinnerPanel);
            Controls.Add(breakfastPanel);
            Controls.Add(dateOfJournal);
            Controls.Add(backBtn);
            Name = "MenusForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню на день";
            Load += MenusForm_Load;
            breakfastPanel.ResumeLayout(false);
            breakfastPanel.PerformLayout();
            dinnerPanel.ResumeLayout(false);
            dinnerPanel.PerformLayout();
            supperPanel.ResumeLayout(false);
            supperPanel.PerformLayout();
            resultsPanel.ResumeLayout(false);
            resultsPanel.PerformLayout();
            ResumeLayout(false);
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
        private Label infoLabelTite;
        private Label carbsLabel;
        private Label fatsLabel;
        private Label caloriesLabel;
        private Label protsLabel;
        private TextBox personCountField;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label infoLabelProts;
        private Label infoLabelCalories;
        private Label infoLabelCarbs;
        private Label infoLabelFats;
        private Label infoLabelCountPerson;
        private Label caloriesPercentLabel;
        private Label carbsPercentLabel;
        private Label fatsPercentLabel;
        private Label protsPercentLabel;
        private Panel resultsPanel;
        private Panel supperPanel;
        private Panel dinnerPanel;
        private RoundedPanel breakfastPanel;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private UXElements.buttonUI bfDecreaseBtn;
        private UXElements.buttonUI bfIncreaseBtn;
        private UXElements.buttonUI supperDecreaseBtn;
        private UXElements.buttonUI supperIncreaseBtn;
        private UXElements.buttonUI dinnerDecreaseBtn;
        private UXElements.buttonUI dinnerIncreaseBtn;
        private System.Windows.Forms.Timer timer1;
        private Label label8;
        private Label label10;
        private Label prodPerPersonLabel;
        private Label prodWeightSumLabel;
        private ProgressBar protsProgressBar;
        private ProgressBar caloriesProgressBar;
        private ProgressBar carbsProgressBar;
        private ProgressBar fatsProgressBar;
    }
}