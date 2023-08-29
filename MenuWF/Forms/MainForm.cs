using MenuWF.Data;
using MenuWF.Forms;
using MenuWF.Repository;
using MenuWF.UIElements;

namespace MenuWF
{
    public partial class MainForm : ShadowedForm
    {
        private readonly UnitOfWork _uow;
        public MainForm(UnitOfWork uow)
        {
            _uow = uow;
            InitializeComponent();
            Animator.Start();
        }

        private void cardui1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Действие при нажатии на карточку");
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            FormHelper.RedirectToForm(this, new ProductsForm(_uow));
        }

        private void DishesBtn_Click(object sender, EventArgs e)
        {
            FormHelper.RedirectToForm(this, new DishesForm(_uow));

        }
    }
}