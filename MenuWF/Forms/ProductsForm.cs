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
            Animator.Start();
        }

        public void ProductsForm_Load()
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
    }
}
