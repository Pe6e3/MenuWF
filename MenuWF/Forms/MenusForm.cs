using MenuWF.Repository;
using MenuWF.UIElements;

namespace MenuWF.Forms
{
    public partial class MenusForm : ShadowedForm
    {
        public MenusForm()
        {
            InitializeComponent();
        }

        private void MenusForm_Load(object sender, EventArgs e)
        {
            RefreshProductsComboBoxes();
        }

        public async void RefreshProductsComboBoxes()
        {
            breakfastDishCB.Items.Clear();
            dinnerDishCB.Items.Clear();
            supperDishCB.Items.Clear();

            breakfastDishCB.DisplayMember = "Name";
            dinnerDishCB.DisplayMember = "Name";
            supperDishCB.DisplayMember = "Name";

            using (var uow = new UnitOfWork())
            {
                var products = await uow.ProductsRepository.GetAll();
                breakfastDishCB.DataSource = products;
                dinnerDishCB.DataSource = products;
                supperDishCB.DataSource = products;
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormHelper.OpenMainForm(this);
        }
    }
}
