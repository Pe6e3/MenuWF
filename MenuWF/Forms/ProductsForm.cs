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
    }
}
