using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        private readonly AppDbContext _db;

        public ProductsRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Recipe>> GetProductsOfDish(int dishId)
        {
            IEnumerable<Recipe> nutrients = await _db.Recipes
                .Include(x => x.Product)
                .Include(x => x.Dish)
                .Where(dish=>dish.Dish.Id == dishId)
                .ToListAsync();

            return nutrients;
        }
    }
}
