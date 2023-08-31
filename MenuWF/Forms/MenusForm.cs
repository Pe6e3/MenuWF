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
            RefreshAllDishesLV();
            RefreshAllProdsLV();
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
                var dishesB = await uow.DishesRepository.GetAll();
                breakfastDishCB.DataSource = dishesB;
            }
            using (var uow = new UnitOfWork())
            {
                var dishesD = await uow.DishesRepository.GetAll();
                dinnerDishCB.DataSource = dishesD;
            }
            using (var uow = new UnitOfWork())
            {
                var dishesS = await uow.DishesRepository.GetAll();
                supperDishCB.DataSource = dishesS;
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
                    journal.DishId = dish.Id;
                    journal.meal = meal;
                    journal.Date = dateJournal;
                    await uow.JournalsRepository.AddJournal(journal);
                }
            }
            RefreshAllDishesLV();
            RefreshAllProdsLV();
        }

        private async void RefreshDishesListViews(Meal meal)
        {
            ListView someDishesLV = new ListView();
            switch (meal)
            {
                case Meal.Breakfast:
                    someDishesLV = breakfastDishesLV;
                    break;
                case Meal.Dinner:
                    someDishesLV = dinnerDishesLV;
                    break;
                case Meal.Supper:
                    someDishesLV = supperDishesLV;
                    break;
                default: return; // если ничего не выбрано - завершаем метод
            }

            someDishesLV.Items.Clear();
            DateTime date = dateOfJournal.Value.Date;

            IEnumerable<Journal> someJournals = new List<Journal>();

            someDishesLV.View = View.Details;
            someDishesLV.Columns.Clear();

            someDishesLV.Columns.Add("Блюдо").Width = 160;
            someDishesLV.Columns.Add("Вес").Width = 50;

            using (var uow = new UnitOfWork())
            {
                someJournals = await uow.JournalsRepository.GetJournalsByDayAndMeal(date, meal);
            }

            decimal sumWeight = 0;
            if (someJournals.Any())
                foreach (var journal in someJournals)
                {
                    ListViewItem item = new ListViewItem(journal.Dish.Name.ToString());
                    item.SubItems.Add(journal.DishWeight.ToString("0"));
                    item.Tag = journal;
                    someDishesLV.Items.Add(item);
                    sumWeight += journal.DishWeight;
                }

            var sumLine = new ListViewItem("Вес всех блюд");
            sumLine.SubItems.Add(sumWeight.ToString("0"));
            someDishesLV.Items.Add(sumLine);
            sumLine.Font = new Font(someDishesLV.Font, FontStyle.Bold);
            sumLine.ForeColor = Color.Red;
        }

        private void RefreshAllDishesLV()
        {
            RefreshDishesListViews(Meal.Breakfast);
            RefreshDishesListViews(Meal.Dinner);
            RefreshDishesListViews(Meal.Supper);

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

        private void deleteBreakfastDishBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedJournal(Meal.Breakfast);
        }

        private void deleteDinnerDishBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedJournal(Meal.Dinner);
        }

        private void deleteSupperDishBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedJournal(Meal.Supper);
        }


        private async void DeleteSelectedJournal(Meal meal)
        {
            ListView someDishesLV = new ListView();
            switch (meal)
            {
                case Meal.Breakfast:
                    someDishesLV = breakfastDishesLV;
                    break;
                case Meal.Dinner:
                    someDishesLV = dinnerDishesLV;
                    break;
                case Meal.Supper:
                    someDishesLV = supperDishesLV;
                    break;
                default: return; // если ничего не выбрано - завершаем метод
            }

            if (someDishesLV.SelectedItems.Count > 0)
            {
                ListViewItem selectedListViewItem = someDishesLV.SelectedItems[0];
                if (selectedListViewItem.Tag is Journal journal)
                {
                    using (var uow = new UnitOfWork())
                    {
                        await uow.JournalsRepository.Delete(journal);
                    }
                    // После удаления обновите список
                    RefreshDishesListViews(meal);
                    RefreshProdsLV(meal);
                }
            }
        }

        private void RefreshAllProdsLV()
        {
            RefreshProdsLV(Meal.Breakfast);
            RefreshProdsLV(Meal.Dinner);
            RefreshProdsLV(Meal.Supper);
        }
        private async void RefreshProdsLV(Meal meal)
        {
            ListView someProductsLV = new ListView();
            switch (meal)
            {
                case Meal.Breakfast:
                    someProductsLV = breakfastProductsLV;
                    break;
                case Meal.Dinner:
                    someProductsLV = dinnerProductsLV;
                    break;
                case Meal.Supper:
                    someProductsLV = supperProductsLV;
                    break;
                default: return; // если ничего не выбрано - завершаем метод
            }
            IEnumerable<Recipe> recipes = new List<Recipe>();
            IEnumerable<Product> productsLV = new List<Product>();
            DateTime date = dateOfJournal.Value.Date;
            using (var uow = new UnitOfWork())
            {
                recipes = await uow.RecipesRepository.GetRecipesOfDayMeal(date, meal);
            }
            someProductsLV.Items.Clear();
            someProductsLV.View = View.Details;
            someProductsLV.Columns.Clear();

            someProductsLV.Columns.Add("Продукт").Width = 150;
            someProductsLV.Columns.Add("Вес").Width = 50;

            decimal sumWeight = 0;
            foreach (var recipe in recipes)
            {
                Journal journal = new Journal();
                using (var uow = new UnitOfWork())
                {
                    journal = await uow.JournalsRepository.GetJournalByDayMealAndDishId(date, meal, recipe.DishId);
                }
                decimal recipeWeight = recipes.Where(x => x.DishId == recipe.DishId).Sum(x => x.ProductWeight);
                decimal dishWeight = journal.DishWeight;
                decimal productMenuWeight = dishWeight/recipeWeight*recipe.ProductWeight; // здесь мы получили вес продукта в блюде относительно веса блюда в меню
                ListViewItem lineLV = new ListViewItem(recipe.Product.Name.ToString());
                lineLV.SubItems.Add(productMenuWeight.ToString("0"));
                someProductsLV.Items.Add(lineLV);
                sumWeight += productMenuWeight;
            }
            var sumLine = new ListViewItem("Вес всех продуктов");
            sumLine.SubItems.Add(sumWeight.ToString("0"));
            someProductsLV.Items.Add(sumLine);
            sumLine.Font = new Font(someProductsLV.Font, FontStyle.Bold);
            sumLine.ForeColor = Color.Red;
        }
    }
}
