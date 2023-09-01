using MenuWF.DTO;
using MenuWF.Entities;
using MenuWF.Repository;
using MenuWF.UIElements;
using static MenuWF.Entities.Journal;

namespace MenuWF.Forms
{
    public partial class MenusForm : ShadowedForm
    {
        IEnumerable<ProductsInMenuDTO> breakfastDTOs;
        IEnumerable<ProductsInMenuDTO> dinnerDTOs;
        IEnumerable<ProductsInMenuDTO> supperDTOs;
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
            Label sumLabel = new Label();
            switch (meal)
            {
                case Meal.Breakfast:
                    someDishesLV = breakfastDishesLV;
                    sumLabel = breakfastSumWeightDishesLabel;
                    sumLabel.Text = "Общий вес блюд на завтрак: ";
                    break;
                case Meal.Dinner:
                    someDishesLV = dinnerDishesLV;
                    sumLabel = dinnerSumWeightDishesLabel;
                    sumLabel.Text = "Общий вес блюд на обед: ";
                    break;
                case Meal.Supper:
                    someDishesLV = supperDishesLV;
                    sumLabel = supperSumWeightDishesLabel;
                    sumLabel.Text = "Общий вес блюд на ужин: ";
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

            sumLabel.Text += sumWeight.ToString("0");
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
            deleteBreakfastDishBtn.Enabled = false;
        }

        private void deleteDinnerDishBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedJournal(Meal.Dinner);
            deleteDinnerDishBtn.Enabled = false;
        }

        private void deleteSupperDishBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedJournal(Meal.Supper);
            deleteSupperDishBtn.Enabled = false;
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
                    RefreshAllProdsLV();
                }
            }
        }

        private async void RefreshAllProdsLV()
        {
            breakfastDTOs = await RefreshProdsLV(Meal.Breakfast);
            dinnerDTOs = await RefreshProdsLV(Meal.Dinner);
            supperDTOs = await RefreshProdsLV(Meal.Supper);

            // Объединяю списки продуктов из разных приемов пищи в один
            IEnumerable<ProductsInMenuDTO> allProductsDTO = breakfastDTOs
                .Concat(dinnerDTOs)
                .Concat(supperDTOs);

            // Объединяю повторяющиеся продукты в полученном списке
            allProductsDTO = allProductsDTO
                .GroupBy(prod => prod.ProdName)
                .Select(group => new ProductsInMenuDTO
                {
                    ProdName = group.Key,
                    ProdWeight = group.Sum(x => x.ProdWeight)
                }).ToList();





            RefreshDayProdsLV(allProductsDTO);
        }

        private void RefreshDayProdsLV(IEnumerable<ProductsInMenuDTO> allProductsDTO)
        {
            dayProdsLV.Items.Clear();
            dayProdsLV.View = View.Details;
            dayProdsLV.Columns.Clear();
            dayProdsLV.Columns.Add("Продукт").Width = 150;
            dayProdsLV.Columns.Add("Вес").Width = 50;
            foreach (var product in allProductsDTO)
            {
                ListViewItem lineLV = new ListViewItem(product.ProdName.ToString());
                lineLV.SubItems.Add(product.ProdWeight.ToString("0"));
                dayProdsLV.Items.Add(lineLV);
            }
        }

        private async Task<IEnumerable<ProductsInMenuDTO>> RefreshProdsLV(Meal meal)
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
                default: return null;
            }
            IEnumerable<Recipe> recipes = new List<Recipe>();
            IEnumerable<Product> productsLV = new List<Product>();
            DateTime date = dateOfJournal.Value.Date;
            using (var uow = new UnitOfWork())
            {
                recipes = await uow.RecipesRepository.GetRecipesOfDayMeal(date, meal);
            }
            IEnumerable<ProductsInMenuDTO> productsDTO = recipes
                .Select(recipe => new ProductsInMenuDTO
                {
                    ProdName = recipe.Product.Name,
                    ProdWeight = recipe.ProductWeight,
                    DishId = recipe.DishId,
                    RecipeWeight = recipes.Where(x => x.DishId == recipe.DishId).Sum(x => x.ProductWeight)
                })
                .ToList();

            foreach (var productDTO in productsDTO)
                productDTO.ProdWeight /= productDTO.RecipeWeight;

            someProductsLV.Items.Clear();
            someProductsLV.View = View.Details;
            someProductsLV.Columns.Clear();
            someProductsLV.Columns.Add("Продукт").Width = 150;
            someProductsLV.Columns.Add("Вес").Width = 50;

            // Здесь только заполняем список productDTO (в слелдующем цикле будем переносить его в ListView)
            foreach (var product in productsDTO)
            {
                Journal journal = new Journal();
                using (var uow = new UnitOfWork())
                {
                    journal = await uow.JournalsRepository.GetJournalByDayMealAndDishId(date, meal, product.DishId);
                }
                product.ProdWeight *= journal.DishWeight;
            }
            productsDTO = productsDTO
                .GroupBy(prod => prod.ProdName)
                .Select(group => new ProductsInMenuDTO
                {
                    ProdName = group.Key,
                    ProdWeight = group.Sum(x => x.ProdWeight)
                }).ToList();

            foreach (var product in productsDTO)
            {
                ListViewItem lineLV = new ListViewItem(product.ProdName.ToString());
                lineLV.SubItems.Add(product.ProdWeight.ToString("0"));
                someProductsLV.Items.Add(lineLV);
            }
            return productsDTO;
        }


        private void breakfastDishWeightField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.ValidateDecimal(breakfastDishWeightField, maxValue: 10000);
            FormHelper.ButtonEnableByField(addBreakfastDishBtn, breakfastDishWeightField);

        }

        private void dinnerDishWeightField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.ValidateDecimal(dinnerDishWeightField, maxValue: 10000);
            FormHelper.ButtonEnableByField(addDinnerDishBtn, dinnerDishWeightField);

        }

        private void supperDishWeightField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.ValidateDecimal(supperDishWeightField, maxValue: 10000);
            FormHelper.ButtonEnableByField(addSupperDishBtn, supperDishWeightField);
        }

        private void breakfastDishesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormHelper.ButtonEnableByListView(deleteBreakfastDishBtn, breakfastDishesLV);
        }

        private void dinnerDishesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormHelper.ButtonEnableByListView(deleteDinnerDishBtn, dinnerDishesLV);

        }

        private void supperDishesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormHelper.ButtonEnableByListView(deleteSupperDishBtn, supperDishesLV);
        }



    }
}
