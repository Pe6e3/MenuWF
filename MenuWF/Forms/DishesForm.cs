using MenuWF.DTO;
using MenuWF.Entities;
using MenuWF.Repository;
using MenuWF.UIElements;

namespace MenuWF.Forms;

public partial class DishesForm : ShadowedForm
{
    private UnitOfWork _uow = new UnitOfWork();

    public DishesForm()
    {
        InitializeComponent();
        Animator.Start();
    }


    private void buttonui1_Click(object sender, EventArgs e)
    {
        FormHelper.OpenMainForm(this);
    }

    private void allDishesListbox_SelectedIndexChanged(object sender, EventArgs e)
    {
        Dish? dish = (Dish?)allDishesListbox.SelectedItem;

        selectedDishLabel.Text = dish?.Name;
        RefreshRecipeList(dish);
    }


    private async void RefreshRecipeList(Dish? dish)
    {
        nutritionList.Items.Clear();
        nutritionList.View = System.Windows.Forms.View.Details; // Установка режима просмотра в Details
        nutritionList.Columns.Clear();

        // Добавляем столбцы и задаем им ширину
        nutritionList.Columns.Add("Продукт").Width = 150; // Ширина первого столбца
        nutritionList.Columns.Add("Вес").Width = 50; // Ширина второго столбца

        if (dish != null)
        {
            IEnumerable<Recipe> nutrients = await _uow.ProductsRepository.GetProductsOfDish(dish.Id);

            foreach (Recipe nutrient in nutrients)
            {
                ListViewItem item = new ListViewItem(nutrient.Product.Name);
                item.SubItems.Add(nutrient.ProductWeight.ToString());
                nutritionList.Items.Add(item);
            }
        }
    }




    private void DishesForm_Load(object sender, EventArgs e)
    {
        FillProductComboBox();
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

    private async void FillProductComboBox()
    {
        var products = await _uow.ProductsRepository.GetAll();
        productsComboBox.Items.Clear();
        productsComboBox.DisplayMember = "Name";
        productsComboBox.DataSource = products;
    }
}
