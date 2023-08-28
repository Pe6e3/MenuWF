using MenuWF.Data;
using MenuWF.Forms;
using MenuWF.UIElements;

namespace MenuWF
{
    public partial class MainForm : ShadowedForm
    {
        private readonly AppDbContext _db;
        public MainForm(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
            Animator.Start();
        }

        private void cardui1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Действие при нажатии на карточку");
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            FormHelper.RedirectToForm(this, new ProductsForm(_db));
        }
    }
}