﻿using MenuWF.Data;
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



        internal async Task<IEnumerable<Recipe>> GetRecipesOfDayMeal(DateTime date, Journal.Meal meal)
        {
            var recipes = await
            (
                from r in db.Recipes
                join j in db.Journals on r.DishId equals j.DishId
                where j.Date == date && j.meal == meal
                select r
            )
            //db.Recipes
            .Include(x => x.Dish)
            .Include(x=>x.Product)
            .ToListAsync();

            return recipes;
        }

    }
}
