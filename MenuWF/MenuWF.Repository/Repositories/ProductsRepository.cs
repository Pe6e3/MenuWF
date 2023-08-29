using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        private readonly AppDbContext db;

        public ProductsRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
