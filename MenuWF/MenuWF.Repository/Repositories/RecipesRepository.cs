using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class RecipesRepository : GenericRepository<Recipe>, IRecipesRepository
    {
        private readonly AppDbContext db;

        public RecipesRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        internal async Task<Recipe> GetRecipeByDish(Dish? dish)
        {
            Recipe? recipe = await db.Recipes.FirstOrDefaultAsync(x => x.DishId == dish.Id);
            return recipe;
        }

        // получаем все строки журнала, которые соответстуют выбранной дате и типу приема пищи
        internal async Task<IEnumerable<Journal>> GetJournalsByDayAndMeal(DateTime date, Journal.Meal meal)
        {
            IEnumerable<Journal> journals = new List<Journal>();
            journals = await db.Journals
                .Where(x => x.Date == date && x.meal == meal)
                .Include(x=>x.Recipe)
                .ThenInclude(x=>x.Dish)
                .ToListAsync();

            return journals;
        }
    }
}
