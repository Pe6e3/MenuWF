using MenuWF.DTO;
using MenuWF.Entities;
using MenuWF.Repository;
using MenuWF.UIElements;

namespace MenuWF.Forms;

public partial class DishesForm : ShadowedForm
{
    public DishesForm()
    {
        InitializeComponent();
        Animator.Start();
    }


    private void DishesForm_Load(object sender, EventArgs e)
    {
        FillProductComboBox();
        RefreshDishes();
    }

    private void allDishesListbox_SelectedIndexChanged(object sender, EventArgs e)
    {
        Dish? dish = (Dish?)allDishesListbox.SelectedItem;

        selectedDishLabel.Text = dish?.Name;
        RefreshRecipeList(dish);
        FormHelper.ButtonEnableByFieldAndListBox(addProdToDishBtn, prodWeightField, allDishesListbox);
    }


    private async void RefreshRecipeList(Dish? dish)
    {
        nutritionList.Items.Clear();
        nutritionList.View = View.Details; // Установка режима просмотра в Details
        nutritionList.Columns.Clear();

        // Добавляем столбцы и задаем им ширину
        nutritionList.Columns.Add("Продукт").Width = 150; // Ширина первого столбца
        nutritionList.Columns.Add("Вес").Width = 50; // Ширина второго столбца

        using (var uow = new UnitOfWork())
        {
            if (dish != null)
            {
                IEnumerable<Recipe> nutrients = await uow.ProductsRepository.GetProductsOfDish(dish.Id);

                decimal sum = 0;
                foreach (Recipe nutrient in nutrients)
                {
                    ListViewItem item = new ListViewItem(nutrient.Product.Name);
                    item.SubItems.Add(nutrient.ProductWeight.ToString());
                    nutritionList.Items.Add(item);
                    sum += nutrient.ProductWeight;
                }
                var sumLine = new ListViewItem("Общий вес:");
                sumLine.SubItems.Add(sum.ToString());
                nutritionList.Items.Add(sumLine);
                sumLine.Font = new Font(nutritionList.Font, FontStyle.Bold);
                sumLine.ForeColor = Color.Red;
            }
        }
    }

    private async void RefreshDishes()
    {
        allDishesListbox.Items.Clear();
        allDishesListbox.DisplayMember = "Name";

        using (var uow = new UnitOfWork())
        {
            IEnumerable<Dish> dishes = await uow.DishesRepository.GetAll();
            foreach (Dish dish in dishes)
                allDishesListbox.Items.Add(dish);
        }
    }

    private async void FillProductComboBox()
    {
        productsComboBox.Items.Clear();
        productsComboBox.DisplayMember = "Name";

        using (var uow = new UnitOfWork())
        {
            var products = await uow.ProductsRepository.GetAll();
            productsComboBox.DataSource = products;
        }
    }


    private async void addDishBtn_Click(object sender, EventArgs e)
    {
        using (var uow = new UnitOfWork())
        {
            Dish dish = new Dish();
            dish.Name = newDishField.Text;
            await uow.DishesRepository.Insert(dish);
        }
        RefreshDishes();
        newDishField.Text = "";
    }


    private async void addProdToDishBtn_Click(object sender, EventArgs e)
    {

        Product? product = productsComboBox.SelectedItem as Product;
        Dish? dish = allDishesListbox.SelectedItem as Dish;

        if (product != null && dish != null)
        {
            using (var uow = new UnitOfWork())
            {
                Recipe recipe = new Recipe();
                recipe.ProductId = product.Id;
                recipe.DishId = dish.Id;
                recipe.ProductWeight = Convert.ToInt32(prodWeightField.Text);
                await uow.RecipesRepository.AddProductToRecipe(recipe);
            }
            FormHelper.ClearFields(this);
            RefreshRecipeList(dish);
            this.ActiveControl = null;
        }
    }

    private void backBtn_Click(object sender, EventArgs e)
    {
        FormHelper.OpenMainForm(this);
    }

    private async void deleteProdFromDishBtn_Click(object sender, EventArgs e)
    {
        Dish? dish = allDishesListbox.SelectedItem as Dish;
        ListViewItem line = nutritionList.SelectedItems[0];

        if (line != null && dish != null)
            using (var uow = new UnitOfWork())
            {
                await uow.RecipesRepository.DeleteProdFromRecipeByDishId(dish.Id, line.Text.ToString());
            }

        RefreshRecipeList(dish);
    }

    private void prodWeightField_TextChanged(object sender, EventArgs e)
    {
        FormHelper.ButtonEnableByFieldAndListBox(addProdToDishBtn, prodWeightField, allDishesListbox);
    }

    private void newDishField_TextChanged(object sender, EventArgs e)
    {
        FormHelper.ButtonEnableByField(addDishBtn, newDishField);
        FormHelper.CheckTextFieldLength(newDishField, 25);

    }
}
