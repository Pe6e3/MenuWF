﻿using MenuWF.DTO;
using MenuWF.Entities;
using MenuWF.Properties;
using MenuWF.Repository;
using MenuWF.UIElements;
using System.Media;
using static Azure.Core.HttpHeader;
using static MenuWF.Entities.Journal;

namespace MenuWF.Forms
{
    public partial class MenusForm : ShadowedForm
    {
        IEnumerable<ProductsInMenuDTO> breakfastDTOs;
        IEnumerable<ProductsInMenuDTO> dinnerDTOs;
        IEnumerable<ProductsInMenuDTO> supperDTOs;
        IEnumerable<ProductsInMenuDTO> allProductsDTO;

        private const int PROT_NORM = 54;
        private const int FAT_NORM = 60;
        private const int CARB_NORM = 261;
        private const int CAL_NORM = 1800;





        public MenusForm()
        {
            InitializeComponent();
            printBtn.MouseEnter += (s, e) => FormHelper.PlaySound(Resources.hover_);

        }

        private void MenusForm_Load(object sender, EventArgs e)
        {
            dateOfJournal.CustomFormat = " d.MM.yyyy"; // Задаю отступ даты от левого края поля
            dateOfJournal.Format = DateTimePickerFormat.Custom; // Применяю этот формат
            dateOfJournal.Value = DateTime.Now;

            RefreshDishesComboBoxes();
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

            IEnumerable<Dish> breakDishes;
            IEnumerable<Dish> dinnerDishes;
            IEnumerable<Dish> supperDishes;

            using (var uow = new UnitOfWork())
            {
                breakDishes = await uow.DishesRepository.GetAll();
            }
            using (var uow = new UnitOfWork())
            {
                dinnerDishes = await uow.DishesRepository.GetAll();
            }
            using (var uow = new UnitOfWork())
            {
                supperDishes = await uow.DishesRepository.GetAll();
            }
            foreach (Dish dish in breakDishes)
                breakfastDishCB.Items.Add(dish);
            foreach (Dish dish in dinnerDishes)
                dinnerDishCB.Items.Add(dish);
            foreach (Dish dish in supperDishes)
                supperDishCB.Items.Add(dish);


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
                    sumLabel.Text = "0";
                    break;
                case Meal.Dinner:
                    someDishesLV = dinnerDishesLV;
                    sumLabel = dinnerSumWeightDishesLabel;
                    sumLabel.Text = "0";
                    break;
                case Meal.Supper:
                    someDishesLV = supperDishesLV;
                    sumLabel = supperSumWeightDishesLabel;
                    sumLabel.Text = "0";
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

            sumLabel.Text = (Convert.ToDecimal(sumLabel.Text) + Convert.ToDecimal(sumWeight)).ToString("0");
        }

        private void RefreshAllDishesLV()
        {
            RefreshDishesListViews(Meal.Breakfast);
            RefreshDishesListViews(Meal.Dinner);
            RefreshDishesListViews(Meal.Supper);

        }

        private async void RefreshAllProdsLV()
        {
            breakfastDTOs = await RefreshProdsLV(Meal.Breakfast);
            dinnerDTOs = await RefreshProdsLV(Meal.Dinner);
            supperDTOs = await RefreshProdsLV(Meal.Supper);

            // Объединяю списки продуктов из разных приемов пищи в один
            allProductsDTO = breakfastDTOs
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


            RefreshCPFC(allProductsDTO);
            RefreshDayProdsLV(allProductsDTO);
        }

        private async void RefreshCPFC(IEnumerable<ProductsInMenuDTO> allProductsDTO) // Обновить КБЖУ
        {
            decimal prots = 0;
            decimal fats = 0;
            decimal carbs = 0;
            decimal calories = 0;
            decimal weight = 0;

            foreach (var productDTO in allProductsDTO)
            {
                Product product;
                using (var uow = new UnitOfWork())
                {
                    product = await uow.ProductsRepository.GetByProdName(productDTO.ProdName);
                }
                prots += product.Prots * productDTO.ProdWeight / 100;
                fats += product.Fats * productDTO.ProdWeight / 100;
                carbs += product.Carbs * productDTO.ProdWeight / 100;
                calories += product.Calories * productDTO.ProdWeight / 100;
                weight += productDTO.ProdWeight;
            }
            decimal coeff = 0;  // Если в поле Количество персон есть текст (а там только число по валидации) то ниже будем на него делить. Если нет - умножим на 0
            if (personCountField.Text.Length > 0 && personCountField.Text != "0")
            {
                coeff = 1 / decimal.Parse(personCountField.Text);
                prodPerPersonLabel.Text = (weight / decimal.Parse(personCountField.Text)).ToString("0г");
            }
            else
            {
                coeff = 0;
                prodPerPersonLabel.Text = "";
            }

            protsLabel.Text = (prots * coeff).ToString("0");
            fatsLabel.Text = (fats * coeff).ToString("0");
            carbsLabel.Text = (carbs * coeff).ToString("0");
            caloriesLabel.Text = (calories * coeff).ToString("0");

            int protsPercent = (int)((prots * coeff / PROT_NORM) * 100);
            int fatsPercent = (int)((fats * coeff / FAT_NORM) * 100);
            int carbsPercent = (int)((carbs * coeff / CARB_NORM) * 100);
            int caloriesPercent = (int)((calories * coeff / CAL_NORM) * 100);

            protsPercentLabel.Text = (protsPercent).ToString("0") + "%";
            fatsPercentLabel.Text = (fatsPercent).ToString("0") + "%";
            carbsPercentLabel.Text = (carbsPercent).ToString("0") + "%";
            caloriesPercentLabel.Text = (caloriesPercent).ToString("0") + "%";

            protsProgressBar.Value = protsPercent < 100 ? protsPercent : 100;
            fatsProgressBar.Value = fatsPercent < 100 ? fatsPercent : 100;
            carbsProgressBar.Value = carbsPercent < 100 ? carbsPercent : 100;
            caloriesProgressBar.Value = caloriesPercent < 100 ? caloriesPercent : 100;


            prodWeightSumLabel.Text = weight.ToString("0г");

        }



        private Brush textBrush = new SolidBrush(Color.FromArgb(220, 110, 110, 110));




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

        private void addBreakfastDishBtn_Click(object sender, EventArgs e)
        {
            FormHelper.PlaySound(Resources.done_2, Resources.done_1);
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

        private void dateOfJournal_ValueChanged(object sender, EventArgs e)
        {
            RefreshAllDishesLV();
            RefreshAllProdsLV();
        }

        private void personCountField_TextChanged(object sender, EventArgs e)
        {
            FormHelper.ValidateDecimal(personCountField, maxValue: 100);
            RefreshCPFC(allProductsDTO);
        }

        private void bfDecreaseBtn_Click(object sender, EventArgs e)
        {
            FormHelper.DecreaseField(breakfastDishWeightField, 50);
            FormHelper.PlaySound(Resources.hover_);
        }

        private void bfIncreaseBtn_Click(object sender, EventArgs e)
        {
            FormHelper.IncreaseField(breakfastDishWeightField, 50);
            FormHelper.PlaySound(Resources.hover_);

        }


        private void dinnerDecreaseBtn_Click(object sender, EventArgs e)
        {
            FormHelper.DecreaseField(dinnerDishWeightField, 50);
            FormHelper.PlaySound(Resources.hover_);

        }
        private void dinnerIncreaseBtn_Click(object sender, EventArgs e)
        {
            FormHelper.IncreaseField(dinnerDishWeightField, 50);
            FormHelper.PlaySound(Resources.hover_);
        }

        private void supperDecreaseBtn_Click(object sender, EventArgs e)
        {
            FormHelper.DecreaseField(supperDishWeightField, 50);
            FormHelper.PlaySound(Resources.hover_);
        }

        private void supperIncreaseBtn_Click(object sender, EventArgs e)
        {
            FormHelper.IncreaseField(supperDishWeightField, 50);
            FormHelper.PlaySound(Resources.hover_);
        }





        private void breakfastDishCB_TextUpdate(object sender, EventArgs e)
        {
            FormHelper.FilterDishComboBox(sender: sender);

        }



        private void dinnerDishCB_TextUpdate(object sender, EventArgs e)
        {
            FormHelper.FilterDishComboBox(sender: sender);
        }

        private void supperDishCB_TextUpdate(object sender, EventArgs e)
        {
            FormHelper.FilterDishComboBox(sender: sender);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            FormHelper.PlaySound(Resources.click);
            PrintHelper printHelper = new PrintHelper(this);

            printHelper.printDocument.DefaultPageSettings.Landscape = true; // Задаем альбомный формат
            printHelper.Print();
        }
    }
}
