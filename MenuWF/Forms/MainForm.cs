using MenuWF.Data;
using MenuWF.UIElements;

namespace MenuWF
{
    public partial class MainForm : Form
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
            MessageBox.Show("�������� ��� ������� �� ��������");
        }
    }
}