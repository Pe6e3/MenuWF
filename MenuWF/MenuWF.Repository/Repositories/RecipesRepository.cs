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
    }
}
