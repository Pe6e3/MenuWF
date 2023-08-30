using MenuWF.Entities;
using MenuWF.Repository;
using MenuWF.UIElements;
using static MenuWF.Entities.Journal;

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
            RefreshDishesComboBoxes();
        }

        public async void RefreshDishesComboBoxes()
        {
            breakfastDishCB.Items.Clear();
            dinnerDishCB.Items.Clear();
            supperDishCB.Items.Clear();

            breakfastDishCB.DisplayMember = "Name";
            dinnerDishCB.DisplayMember = "Name";
            supperDishCB.DisplayMember = "Name";

            using (var uow = new UnitOfWork())
            {
                var dishes = await uow.DishesRepository.GetAll();
                breakfastDishCB.DataSource = dishes;
                dinnerDishCB.DataSource = dishes;
                supperDishCB.DataSource = dishes;
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormHelper.OpenMainForm(this);
        }


        private async void AddDishToMenu(Meal meal)
        {
            Dish? dish = new Dish();
            decimal dishWeight = 0;
            switch (meal)
            {
                case Meal.Breakfast:
                    dish = breakfastDishCB.SelectedItem as Dish;
                    dishWeight = Convert.ToDecimal(breakfastDishWeightField.Text);
                    break;
                case Meal.Dinner:
                    dish = dinnerDishCB.SelectedItem as Dish;
                    dishWeight = Convert.ToDecimal(dinnerDishWeightField.Text);
                    break;
                case Meal.Supper:
                    dish = supperDishCB.SelectedItem as Dish;
                    dishWeight = Convert.ToDecimal(supperDishWeightField.Text);
                    break;
                default: break;
            }
            using (var uow = new UnitOfWork())
            {
                Recipe? recipe = await uow.RecipesRepository.GetRecipeByDish(dish);
                Journal journal = new Journal();
                DateTime dateJournal = dateOfJournal.Value.Date;
                if (recipe != null && dishWeight > 0)
                {
                    journal.DishWeight = dishWeight;
                    journal.RecipeId = recipe.Id;
                    journal.meal = meal;
                    journal.Date = dateJournal;
                    await uow.JournalsRepository.Insert(journal);
                }
            }
        }

        private void addBreakfastDishBtn_Click(object sender, EventArgs e)
        {
            AddDishToMenu(Meal.Breakfast);
        }

        private void addDinnerDishBtn_Click(object sender, EventArgs e)
        {
            AddDishToMenu(Meal.Dinner);
        }

        private void addSupperDishBtn_Click(object sender, EventArgs e)
        {
            AddDishToMenu(Meal.Supper);
        }
    }
}
