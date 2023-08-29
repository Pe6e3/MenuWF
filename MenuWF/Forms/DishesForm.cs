using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.UIElements;
using Microsoft.EntityFrameworkCore;

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


    private void buttonui1_Click(object sender, EventArgs e)
    {
        FormHelper.OpenMainForm(this, _db);
    }

    private void allDishesListbox_SelectedIndexChanged(object sender, EventArgs e)
    {
        Dish? dish = (Dish?)allDishesListbox.SelectedItem;

        selectedDishLabel.Text = dish?.Name;
        RefreshDishCard(dish);
    }

    private void RefreshDishCard(Dish? dish)
    {
        //IEnumerable<Product> products = _db.Products.GetProductsOfDish(dish);
    }

    private void DishesForm_Load(object sender, EventArgs e)
    {
        RefreshDishes();
    }

    private async void RefreshDishes()
    {
        allDishesListbox.Items.Clear();
        allDishesListbox.DisplayMember = "Name";
        IEnumerable<Dish> dishes = await _db.Dishes.ToListAsync();
        foreach (Dish dish in dishes)
            allDishesListbox.Items.Add(dish);
    }
}
