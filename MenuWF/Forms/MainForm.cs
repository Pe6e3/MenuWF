using MenuWF.Data;
using MenuWF.Forms;
using MenuWF.Repository;
using MenuWF.UIElements;

namespace MenuWF
{
    public partial class MainForm : ShadowedForm
    {
        private UnitOfWork _uow = new UnitOfWork();
        public MainForm()
        {
            InitializeComponent();
            Animator.Start();
        }

        private void cardui1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Действие при нажатии на карточку");
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            FormHelper.RedirectToForm(this, new ProductsForm());
        }

        private void DishesBtn_Click(object sender, EventArgs e)
        {
            FormHelper.RedirectToForm(this, new DishesForm());

        }
    }
}