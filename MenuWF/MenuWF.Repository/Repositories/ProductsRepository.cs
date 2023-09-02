using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        private readonly AppDbContext db;

        public ProductsRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Recipe>> GetProductsOfDish(int dishId)
        {
            IEnumerable<Recipe> nutrients = await db.Recipes
                .Include(x => x.Product)
                .Include(x => x.Dish)
                .Where(dish => dish.Dish.Id == dishId)
                .ToListAsync();

            return nutrients;
        }

        internal async Task<IEnumerable<Product>> FilterProducts(string productFilter)
        {
            IEnumerable<Product> products;
            if (productFilter != "")
            {
                products = await db.Products
                        .Where(x => x.Name.ToLower().Contains(productFilter.ToLower()) || x.Name == productFilter)
                        .ToListAsync();
            }
            else
                products = await db.Products.ToListAsync();

            return products;
        }

        internal async Task<Product> GetByProdName(string prodName) =>
         await db.Products.FirstOrDefaultAsync(x => x.Name == prodName);
    }
}
