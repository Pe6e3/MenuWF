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


        // Добавляем продукт в рецепт, если его там нет. Если есть - прибавляем вес к этому продукту
        internal async Task AddProductToRecipe(Recipe recipe)
        {
            Recipe oldRecipe = await db.Recipes.FirstOrDefaultAsync(x => x.ProductId == recipe.ProductId && x.DishId == recipe.DishId);
            if (oldRecipe != null)
            {
                oldRecipe.ProductWeight += recipe.ProductWeight;
                db.Entry(oldRecipe).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            else
            {
                await db.Recipes.AddAsync(recipe);
                await db.SaveChangesAsync();
            }
        }

        internal async Task DeleteProdFromRecipeByDishId(int dishId, string productName)
        {
            Product? product = await db.Products.FirstOrDefaultAsync(x => x.Name == productName);
            if (product != null)
            {
                Recipe? recipe = await db.Recipes.FirstOrDefaultAsync(x => x.DishId == dishId && x.ProductId == product.Id);
                if (recipe != null)
                {
                    db.Recipes.Remove(recipe);
                    await db.SaveChangesAsync();
                }
            }
        }

        internal async Task<Recipe> GetRecipeByDish(Dish? dish) => await db.Recipes.FirstOrDefaultAsync(x => x.DishId == dish.Id);

        internal async Task<IEnumerable<Recipe>> GetRecipesOfDayMeal(DateTime date, Journal.Meal meal) => await
            (
                from r in db.Recipes
                join j in db.Journals on r.DishId equals j.DishId
                where j.Date == date && j.meal == meal
                select r
            )
            .Include(x => x.Dish)
            .Include(x => x.Product)
            .ToListAsync();


    }
}
