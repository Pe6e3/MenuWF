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
            if (protsField.Text.Count(c => c == ',') == 1 && protsField.Text.EndsWith(','))
            { }// Ничего не делаем, если уже есть запятая и пытаемся ввести еще одну

            else if (!decimal.TryParse(protsField.Text, out _))
            {
                if (protsField.Text.Length > 1)// Если введенный текст не является десятичным числом
                {
                    protsField.Text = protsField.Text.Substring(0, protsField.Text.Length - 1);
                    protsField.SelectionStart = protsField.Text.Length; // Перемещение курсора в конец текста
                }
                else
                    protsField.Text = "";
            }
        }


    }
}
