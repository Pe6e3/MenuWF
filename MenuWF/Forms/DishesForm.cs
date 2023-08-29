using MenuWF.Entities;
using MenuWF.Repository;
using MenuWF.UIElements;

namespace MenuWF.Forms;

public partial class DishesForm : ShadowedForm
{
    private readonly UnitOfWork _uow;
    public DishesForm(UnitOfWork uow)
    {
        _uow = uow;
        InitializeComponent();
        Animator.Start();

    }


    private void buttonui1_Click(object sender, EventArgs e)
    {
        FormHelper.OpenMainForm(this, _uow);
    }

    private void allDishesListbox_SelectedIndexChanged(object sender, EventArgs e)
    {
        Dish? dish = (Dish?)allDishesListbox.SelectedItem;

        selectedDishLabel.Text = dish?.Name;
        RefreshDishCard(dish);
    }

    private void RefreshDishCard(Dish? dish)
    {
        //IEnumerable<Product> products = _uow.Products.GetProductsOfDish(dish);
    }

    private void DishesForm_Load(object sender, EventArgs e)
    {
        RefreshDishes();
    }

    private async void RefreshDishes()
    {
        allDishesListbox.Items.Clear();
        allDishesListbox.DisplayMember = "Name";
        IEnumerable<Dish> dishes = await _uow.DishesRepository.GetAll();
        foreach (Dish dish in dishes)
            allDishesListbox.Items.Add(dish);
    }
}
