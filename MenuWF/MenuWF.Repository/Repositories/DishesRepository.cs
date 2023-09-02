using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class DishesRepository : GenericRepository<Dish>, IDishesRepository
    {
        private readonly AppDbContext db = new AppDbContext();

        public DishesRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        internal async Task<IEnumerable<Dish>> FilterDishes(string dishFilter)
        {
            IEnumerable<Dish> dishes;
            if (dishFilter != "")
            {
                dishes = await db.Dishes
                        .Where(x => x.Name.ToLower().Contains(dishFilter.ToLower()) || x.Name == dishFilter)
                        .ToListAsync();
            }
            else
                dishes = await db.Dishes.ToListAsync();

            return dishes;
        }
    }
}
