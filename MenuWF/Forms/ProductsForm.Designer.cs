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
            allProductsListbox.Location = new Point(543, 34);
            allProductsListbox.Name = "allProductsListbox";
            allProductsListbox.Size = new Size(120, 274);
            allProductsListbox.TabIndex = 0;
            // 
            // productNameField
            // 
            productNameField.AccessibleRole = AccessibleRole.Text;
            productNameField.Location = new Point(99, 34);
            productNameField.Name = "productNameField";
            productNameField.PlaceholderText = "Название продукта";
            productNameField.Size = new Size(141, 23);
            productNameField.TabIndex = 2;
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
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}