using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.UIElements;

namespace MenuWF.Forms
{
    public partial class ProductsForm : Form
    {
        private readonly AppDbContext _db;
        public ProductsForm(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
            Load += ProductsForm_Load;
            Animator.Start();
        }

        private void ProductsForm_Load(object? sender, EventArgs e)
        {
            RefreshProducts();
        }


        private void RefreshProducts()
        {
            allProductsListbox.Items.Clear();
            allProductsListbox.DisplayMember = "Name";
            List<Product> products = _db.Products.ToList();

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

        private void AddProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            RefreshProducts();
            FormHelper.ClearFields(this);
            this.ActiveControl = null;
        }



    }
}
