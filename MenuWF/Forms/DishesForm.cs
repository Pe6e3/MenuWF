using MenuWF.Data;
using MenuWF.UIElements;

namespace MenuWF.Forms;

public partial class DishesForm : ShadowedForm
{
    private readonly AppDbContext _db;
    public DishesForm(AppDbContext db)
    {
        _db = db;
        InitializeComponent();
        Animator.Start();

    }


    public DishesForm()
    {
        InitializeComponent();
    }

    private void buttonui1_Click(object sender, EventArgs e)
    {
        FormHelper.OpenMainForm(this, _db);
    }
}
