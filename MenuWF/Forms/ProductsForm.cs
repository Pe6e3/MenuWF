using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Repository;
using MenuWF.UIElements;

namespace MenuWF.Forms
{
    public partial class ProductsForm : ShadowedForm
    {
        private UnitOfWork _uow = new UnitOfWork();

        public ProductsForm()
        {
            InitializeComponent();
            Load += ProductsForm_Load;
            Animator.Start();
        }

        private void ProductsForm_Load(object? sender, EventArgs e)
        {
            RefreshProducts();
        }


        private async void RefreshProducts()
        {
            allProductsListbox.Items.Clear();
            allProductsListbox.DisplayMember = "Name";
            IEnumerable<Product> products = await _uow.ProductsRepository.GetAllAsync();

            foreach (Product product in products)
                allProductsListbox.Items.Add(product);
        }

        private void protsField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.ValidateDecimal(protsField, maxValue: 50);
        }

        private void fatsField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.ValidateDecimal(fatsField, maxValue: 100);

        }

        private void carbsField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.ValidateDecimal(carbsField, maxValue: 80);

        }

        private void caloriesField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.ValidateDecimal(caloriesField, maxValue: 900);
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Name = productNameField.Text;
                product.Prots = string.IsNullOrWhiteSpace(protsField.Text) ? 0 : Convert.ToDecimal(protsField.Text);
                product.Fats = string.IsNullOrWhiteSpace(fatsField.Text) ? 0 : Convert.ToDecimal(fatsField.Text);
                product.Carbs = string.IsNullOrWhiteSpace(carbsField.Text) ? 0 : Convert.ToDecimal(carbsField.Text);
                product.Calories = string.IsNullOrWhiteSpace(caloriesField.Text) ? 0 : Convert.ToDecimal(caloriesField.Text);

                if (productNameField.Text.Length > 0)
                    AddProduct(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при попытке добавить продукт: " + ex);
            }

        }

        private async void AddProduct(Product product)
        {
            await _uow.ProductsRepository.Insert(product);
            RefreshProducts();
            FormHelper.ClearFields(this);
            this.ActiveControl = null;
        }

        private void allProductsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            delProdBtn.Enabled = true;
            Product? product = (Product?)allProductsListbox.SelectedItem;
            if (product != null)
                RefreshProductCard(product);
            else
                FormHelper.ClearFields(this);
        }

        private void RefreshProductCard(Product? product)
        {
            protsInfo.Text = product.Prots.ToString("0.0");
            fatsInfo.Text = product.Fats.ToString("0.0");
            carbsInfo.Text = product.Carbs.ToString("0.0");
            caloriesInfo.Text = product.Calories.ToString("0.0");
            selectedProductLabel.Text = product?.Name;

        }

        private async void delProdBtn_Click(object sender, EventArgs e)
        {
            Product? product = (Product?)allProductsListbox.SelectedItem;
            if (product != null)
            {
                await _uow.ProductsRepository.Delete(product);
                RefreshProducts();
                FormHelper.ClearFields(this);
                this.ActiveControl = null;
                delProdBtn.Enabled = false;
                selectedProductLabel.Text = "";
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormHelper.OpenMainForm(this);
        }
    }
}
