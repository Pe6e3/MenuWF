using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class RecipesRepository : GenericRepository<Recipe>, IRecipesRepository
    {
        private readonly AppDbContext db;

        public RecipesRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
