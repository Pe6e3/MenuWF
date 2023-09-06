namespace MenuWF.Forms
{
    partial class ProductsForm
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
            egoldsFormStyle1 = new UIElements.EgoldsFormStyle(components);
            allProductsListbox = new ListBox();
            productNameField = new TextBox();
            protsField = new TextBox();
            fatsField = new TextBox();
            carbsField = new TextBox();
            caloriesField = new TextBox();
            addProductBtn = new UXElements.buttonUI();
            protsInfoLabel = new Label();
            fatsInfoLabel = new Label();
            carbsInfoLabel = new Label();
            caloriesInfoLabel = new Label();
            delProdBtn = new UXElements.buttonUI();
            protsInfo = new TextBox();
            fatsInfo = new TextBox();
            carbsInfo = new TextBox();
            caloriesInfo = new TextBox();
            selectedProductLabel = new Label();
            backBtn = new UXElements.buttonUI();
            panel1 = new Panel();
            panel1.SuspendLayout();
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
            egoldsFormStyle1.HeaderColor = Color.DimGray;
            egoldsFormStyle1.HeaderColorAdditional = Color.White;
            egoldsFormStyle1.HeaderColorGradientEnable = false;
            egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            egoldsFormStyle1.HeaderHeight = 38;
            egoldsFormStyle1.HeaderImage = null;
            egoldsFormStyle1.HeaderTextColor = Color.White;
            egoldsFormStyle1.HeaderTextFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // allProductsListbox
            // 
            allProductsListbox.FormattingEnabled = true;
            allProductsListbox.ItemHeight = 15;
            allProductsListbox.Location = new Point(322, 69);
            allProductsListbox.Name = "allProductsListbox";
            allProductsListbox.Size = new Size(137, 244);
            allProductsListbox.TabIndex = 7;
            allProductsListbox.SelectedIndexChanged += allProductsListbox_SelectedIndexChanged;
            // 
            // productNameField
            // 
            productNameField.AccessibleRole = AccessibleRole.Text;
            productNameField.Location = new Point(96, 69);
            productNameField.Name = "productNameField";
            productNameField.PlaceholderText = "Название продукта";
            productNameField.Size = new Size(141, 23);
            productNameField.TabIndex = 1;
            productNameField.TextChanged += productNameField_TextChanged;
            // 
            // protsField
            // 
            protsField.AccessibleRole = AccessibleRole.Text;
            protsField.Location = new Point(96, 112);
            protsField.Name = "protsField";
            protsField.PlaceholderText = "Белки";
            protsField.Size = new Size(141, 23);
            protsField.TabIndex = 2;
            protsField.TextChanged += protsField_TextChanged;
            // 
            // fatsField
            // 
            fatsField.AccessibleRole = AccessibleRole.Text;
            fatsField.Location = new Point(96, 153);
            fatsField.Name = "fatsField";
            fatsField.PlaceholderText = "Жиры";
            fatsField.Size = new Size(141, 23);
            fatsField.TabIndex = 3;
            fatsField.TextChanged += fatsField_TextChanged;
            // 
            // carbsField
            // 
            carbsField.AccessibleRole = AccessibleRole.Text;
            carbsField.Location = new Point(96, 191);
            carbsField.Name = "carbsField";
            carbsField.PlaceholderText = "Углеводы";
            carbsField.Size = new Size(141, 23);
            carbsField.TabIndex = 4;
            carbsField.TextChanged += carbsField_TextChanged;
            // 
            // caloriesField
            // 
            caloriesField.AccessibleRole = AccessibleRole.Text;
            caloriesField.Location = new Point(96, 231);
            caloriesField.Name = "caloriesField";
            caloriesField.PlaceholderText = "Калории";
            caloriesField.Size = new Size(141, 23);
            caloriesField.TabIndex = 5;
            caloriesField.TextChanged += caloriesField_TextChanged;
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.Transparent;
            addProductBtn.Enabled = false;
            addProductBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addProductBtn.Font = new Font("W3$iP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(86, 279);
            addProductBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Rounding = 33;
            addProductBtn.RoundingEnable = true;
            addProductBtn.Size = new Size(165, 32);
            addProductBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            addProductBtn.TabIndex = 6;
            addProductBtn.Text = "Добавить продукт";
            addProductBtn.TextHover = null;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // protsInfoLabel
            // 
            protsInfoLabel.Location = new Point(465, 110);
            protsInfoLabel.Name = "protsInfoLabel";
            protsInfoLabel.Size = new Size(100, 25);
            protsInfoLabel.TabIndex = 8;
            protsInfoLabel.Text = "Белки";
            protsInfoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fatsInfoLabel
            // 
            fatsInfoLabel.Location = new Point(465, 140);
            fatsInfoLabel.Name = "fatsInfoLabel";
            fatsInfoLabel.Size = new Size(100, 25);
            fatsInfoLabel.TabIndex = 8;
            fatsInfoLabel.Text = "Жиры";
            fatsInfoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // carbsInfoLabel
            // 
            carbsInfoLabel.Location = new Point(465, 170);
            carbsInfoLabel.Name = "carbsInfoLabel";
            carbsInfoLabel.Size = new Size(100, 25);
            carbsInfoLabel.TabIndex = 8;
            carbsInfoLabel.Text = "Углеводы";
            carbsInfoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // caloriesInfoLabel
            // 
            caloriesInfoLabel.Location = new Point(465, 200);
            caloriesInfoLabel.Name = "caloriesInfoLabel";
            caloriesInfoLabel.Size = new Size(100, 25);
            caloriesInfoLabel.TabIndex = 8;
            caloriesInfoLabel.Text = "Калории";
            caloriesInfoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // delProdBtn
            // 
            delProdBtn.BackColor = Color.Transparent;
            delProdBtn.Enabled = false;
            delProdBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            delProdBtn.Font = new Font("W3$iP", 9F, FontStyle.Regular, GraphicsUnit.Point);
            delProdBtn.ForeColor = Color.White;
            delProdBtn.Location = new Point(571, 241);
            delProdBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            delProdBtn.Name = "delProdBtn";
            delProdBtn.Rounding = 33;
            delProdBtn.RoundingEnable = true;
            delProdBtn.Size = new Size(141, 32);
            delProdBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            delProdBtn.TabIndex = 12;
            delProdBtn.Text = "Удалить продукт";
            delProdBtn.TextHover = null;
            delProdBtn.Click += delProdBtn_Click;
            // 
            // protsInfo
            // 
            protsInfo.AccessibleRole = AccessibleRole.Text;
            protsInfo.Location = new Point(571, 112);
            protsInfo.Name = "protsInfo";
            protsInfo.Size = new Size(141, 23);
            protsInfo.TabIndex = 8;
            protsInfo.TextChanged += protsField_TextChanged;
            // 
            // fatsInfo
            // 
            fatsInfo.AccessibleRole = AccessibleRole.Text;
            fatsInfo.Location = new Point(571, 142);
            fatsInfo.Name = "fatsInfo";
            fatsInfo.Size = new Size(141, 23);
            fatsInfo.TabIndex = 9;
            fatsInfo.TextChanged += fatsField_TextChanged;
            // 
            // carbsInfo
            // 
            carbsInfo.AccessibleRole = AccessibleRole.Text;
            carbsInfo.Location = new Point(571, 172);
            carbsInfo.Name = "carbsInfo";
            carbsInfo.Size = new Size(141, 23);
            carbsInfo.TabIndex = 10;
            carbsInfo.TextChanged += carbsField_TextChanged;
            // 
            // caloriesInfo
            // 
            caloriesInfo.AccessibleRole = AccessibleRole.Text;
            caloriesInfo.Location = new Point(571, 202);
            caloriesInfo.Name = "caloriesInfo";
            caloriesInfo.Size = new Size(141, 23);
            caloriesInfo.TabIndex = 11;
            caloriesInfo.TextChanged += caloriesField_TextChanged;
            // 
            // selectedProductLabel
            // 
            selectedProductLabel.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            selectedProductLabel.Location = new Point(523, 69);
            selectedProductLabel.Name = "selectedProductLabel";
            selectedProductLabel.Size = new Size(189, 25);
            selectedProductLabel.TabIndex = 8;
            selectedProductLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.endColorBorderBtn = Color.LightSkyBlue;
            backBtn.Font = new Font("Candara Light", 35F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.LightCyan;
            backBtn.Location = new Point(12, 12);
            backBtn.middleColorBtn = Color.DeepSkyBlue;
            backBtn.Name = "backBtn";
            backBtn.Rounding = 33;
            backBtn.RoundingEnable = true;
            backBtn.Size = new Size(81, 36);
            backBtn.startColorBtn = Color.SkyBlue;
            backBtn.TabIndex = 30;
            backBtn.Text = "←";
            backBtn.TextHover = "назад";
            backBtn.Click += backBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(caloriesInfoLabel);
            panel1.Controls.Add(carbsInfoLabel);
            panel1.Controls.Add(fatsInfoLabel);
            panel1.Controls.Add(selectedProductLabel);
            panel1.Controls.Add(protsInfoLabel);
            panel1.Controls.Add(delProdBtn);
            panel1.Controls.Add(addProductBtn);
            panel1.Controls.Add(caloriesInfo);
            panel1.Controls.Add(caloriesField);
            panel1.Controls.Add(carbsInfo);
            panel1.Controls.Add(carbsField);
            panel1.Controls.Add(fatsInfo);
            panel1.Controls.Add(fatsField);
            panel1.Controls.Add(protsInfo);
            panel1.Controls.Add(protsField);
            panel1.Controls.Add(productNameField);
            panel1.Controls.Add(allProductsListbox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 358);
            panel1.TabIndex = 31;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(panel1);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UIElements.EgoldsFormStyle egoldsFormStyle1;
        private ListBox allProductsListbox;
        private TextBox productNameField;
        private TextBox protsField;
        private TextBox caloriesField;
        private TextBox carbsField;
        private TextBox fatsField;
        private UXElements.buttonUI addProductBtn;
        private Label caloriesInfoLabel;
        private Label carbsInfoLabel;
        private Label fatsInfoLabel;
        private Label protsInfoLabel;
        private UXElements.buttonUI delProdBtn;
        private TextBox caloriesInfo;
        private TextBox carbsInfo;
        private TextBox fatsInfo;
        private TextBox protsInfo;
        private Label selectedProductLabel;
        private UXElements.buttonUI backBtn;
        private Panel panel1;
    }
}