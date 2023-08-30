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
            RefreshDishesListBoxes();
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
                    journal.RecipeId = recipe.Id;
                    journal.meal = meal;
                    journal.Date = dateJournal;
                    await uow.JournalsRepository.Insert(journal);
                }
            }
            RefreshDishesListBoxes();
        }

        private async void RefreshDishesListBoxes()
        {
            breakfastDishesLW.Items.Clear();
            dinnerDishesLW.Items.Clear();
            supperDishesLW.Items.Clear();
            DateTime date = dateOfJournal.Value.Date;

            IEnumerable<Journal> breakfastJournals = new List<Journal>();
            IEnumerable<Journal> dinnerJournals = new List<Journal>();
            IEnumerable<Journal> supperJournals = new List<Journal>();


            breakfastDishesLW.View = View.Details;
            dinnerDishesLW.View = View.Details;
            supperDishesLW.View = View.Details;

            breakfastDishesLW.Columns.Clear();
            dinnerDishesLW.Columns.Clear();
            supperDishesLW.Columns.Clear();

            breakfastDishesLW.Columns.Add("Блюдо").Width = 160;
            breakfastDishesLW.Columns.Add("Вес").Width = 50;

            dinnerDishesLW.Columns.Add("Блюдо").Width = 160;
            dinnerDishesLW.Columns.Add("Вес").Width = 50;

            supperDishesLW.Columns.Add("Блюдо").Width = 160;
            supperDishesLW.Columns.Add("Вес").Width = 50;

            using (var uow = new UnitOfWork())
            {
                breakfastJournals = await uow.RecipesRepository.GetJournalsByDayAndMeal(date, Meal.Breakfast);
                dinnerJournals = await uow.RecipesRepository.GetJournalsByDayAndMeal(date, Meal.Dinner);
                supperJournals = await uow.RecipesRepository.GetJournalsByDayAndMeal(date, Meal.Supper);
            }

            // Суммы весов блюд по Завтраку, Обеду и Ужину
            decimal sumB = 0;
            decimal sumD = 0;
            decimal sumS = 0;
            foreach (var journalB in breakfastJournals)
            {
                ListViewItem item = new ListViewItem(journalB.Recipe.Dish.Name.ToString());
                item.SubItems.Add(journalB.DishWeight.ToString("0.0"));
                breakfastDishesLW.Items.Add(item);
                sumB += journalB.DishWeight;
            }

            foreach (var journalD in dinnerJournals)
            {
                ListViewItem item = new ListViewItem(journalD.Recipe.Dish.Name.ToString());
                item.SubItems.Add(journalD.DishWeight.ToString("0.0"));
                dinnerDishesLW.Items.Add(item);
                sumD += journalD.DishWeight;
            }

            foreach (var journalS in supperJournals)
            {
                ListViewItem item = new ListViewItem(journalS.Recipe.Dish.Name.ToString());
                item.SubItems.Add(journalS.DishWeight.ToString("0.0"));
                supperDishesLW.Items.Add(item);
                sumS += journalS.DishWeight;
            }
            var sumLineB = new ListViewItem("Вес всех блюд");
            var sumLineD = new ListViewItem("Вес всех блюд");
            var sumLineS = new ListViewItem("Вес всех блюд");
            sumLineB.SubItems.Add(sumB.ToString("0.0"));
            sumLineD.SubItems.Add(sumD.ToString("0.0"));
            sumLineS.SubItems.Add(sumS.ToString("0.0"));

            breakfastDishesLW.Items.Add(sumLineB);
            dinnerDishesLW.Items.Add(sumLineD);
            supperDishesLW.Items.Add(sumLineS);

            sumLineB.Font = new Font(breakfastDishesLW.Font, FontStyle.Bold);
            sumLineD.Font = new Font(dinnerDishesLW.Font, FontStyle.Bold);
            sumLineS.Font = new Font(supperDishesLW.Font, FontStyle.Bold);

            sumLineB.ForeColor = Color.Red;
            sumLineD.ForeColor = Color.Red;
            sumLineS.ForeColor = Color.Red;

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
