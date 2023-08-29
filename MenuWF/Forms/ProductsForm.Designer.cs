﻿namespace MenuWF.Forms
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
            protsInfo = new Label();
            fatsInfo = new Label();
            carbsInfo = new Label();
            caloriesInfo = new Label();
            delProdBtn = new UXElements.buttonUI();
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
            allProductsListbox.Location = new Point(325, 34);
            allProductsListbox.Name = "allProductsListbox";
            allProductsListbox.Size = new Size(120, 274);
            allProductsListbox.TabIndex = 7;
            allProductsListbox.SelectedIndexChanged += allProductsListbox_SelectedIndexChanged;
            // 
            // productNameField
            // 
            productNameField.AccessibleRole = AccessibleRole.Text;
            productNameField.Location = new Point(99, 34);
            productNameField.Name = "productNameField";
            productNameField.PlaceholderText = "Название продукта";
            productNameField.Size = new Size(141, 23);
            productNameField.TabIndex = 1;
            // 
            // protsField
            // 
            protsField.AccessibleRole = AccessibleRole.Text;
            protsField.Location = new Point(99, 77);
            protsField.Name = "protsField";
            protsField.PlaceholderText = "Белки";
            protsField.Size = new Size(141, 23);
            protsField.TabIndex = 2;
            protsField.TextChanged += protsField_TextChanged;
            // 
            // fatsField
            // 
            fatsField.AccessibleRole = AccessibleRole.Text;
            fatsField.Location = new Point(99, 118);
            fatsField.Name = "fatsField";
            fatsField.PlaceholderText = "Жиры";
            fatsField.Size = new Size(141, 23);
            fatsField.TabIndex = 3;
            fatsField.TextChanged += fatsField_TextChanged;
            // 
            // carbsField
            // 
            carbsField.AccessibleRole = AccessibleRole.Text;
            carbsField.Location = new Point(99, 156);
            carbsField.Name = "carbsField";
            carbsField.PlaceholderText = "Углеводы";
            carbsField.Size = new Size(141, 23);
            carbsField.TabIndex = 4;
            carbsField.TextChanged += carbsField_TextChanged;
            // 
            // caloriesField
            // 
            caloriesField.AccessibleRole = AccessibleRole.Text;
            caloriesField.Location = new Point(99, 196);
            caloriesField.Name = "caloriesField";
            caloriesField.PlaceholderText = "Калории";
            caloriesField.Size = new Size(141, 23);
            caloriesField.TabIndex = 5;
            caloriesField.TextChanged += caloriesField_TextChanged;
            // 
            // addProductBtn
            // 
            addProductBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            addProductBtn.Font = new Font("W3$iP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(89, 244);
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
            // protsInfo
            // 
            protsInfo.BorderStyle = BorderStyle.Fixed3D;
            protsInfo.Location = new Point(476, 36);
            protsInfo.Name = "protsInfo";
            protsInfo.Size = new Size(100, 25);
            protsInfo.TabIndex = 8;
            // 
            // fatsInfo
            // 
            fatsInfo.BorderStyle = BorderStyle.Fixed3D;
            fatsInfo.Location = new Point(476, 66);
            fatsInfo.Name = "fatsInfo";
            fatsInfo.Size = new Size(100, 25);
            fatsInfo.TabIndex = 8;
            // 
            // carbsInfo
            // 
            carbsInfo.BorderStyle = BorderStyle.Fixed3D;
            carbsInfo.Location = new Point(476, 96);
            carbsInfo.Name = "carbsInfo";
            carbsInfo.Size = new Size(100, 25);
            carbsInfo.TabIndex = 8;
            // 
            // caloriesInfo
            // 
            caloriesInfo.BorderStyle = BorderStyle.Fixed3D;
            caloriesInfo.Location = new Point(476, 126);
            caloriesInfo.Name = "caloriesInfo";
            caloriesInfo.Size = new Size(100, 25);
            caloriesInfo.TabIndex = 8;
            // 
            // delProdBtn
            // 
            delProdBtn.Enabled = false;
            delProdBtn.endColorBorderBtn = Color.FromArgb(26, 188, 156);
            delProdBtn.Font = new Font("W3$iP", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delProdBtn.ForeColor = Color.White;
            delProdBtn.Location = new Point(476, 168);
            delProdBtn.middleColorBtn = Color.FromArgb(189, 195, 199);
            delProdBtn.Name = "delProdBtn";
            delProdBtn.Rounding = 33;
            delProdBtn.RoundingEnable = true;
            delProdBtn.Size = new Size(165, 32);
            delProdBtn.startColorBtn = Color.FromArgb(127, 140, 141);
            delProdBtn.TabIndex = 6;
            delProdBtn.Text = "Удалить продукт";
            delProdBtn.TextHover = null;
            delProdBtn.Click += delProdBtn_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(caloriesInfo);
            Controls.Add(carbsInfo);
            Controls.Add(fatsInfo);
            Controls.Add(protsInfo);
            Controls.Add(delProdBtn);
            Controls.Add(addProductBtn);
            Controls.Add(caloriesField);
            Controls.Add(carbsField);
            Controls.Add(fatsField);
            Controls.Add(protsField);
            Controls.Add(productNameField);
            Controls.Add(allProductsListbox);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            ResumeLayout(false);
            PerformLayout();
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
        private Label caloriesInfo;
        private Label carbsInfo;
        private Label fatsInfo;
        private Label protsInfo;
        private UXElements.buttonUI delProdBtn;
    }
}