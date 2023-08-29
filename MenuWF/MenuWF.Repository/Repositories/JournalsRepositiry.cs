using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class JournalsRepository : GenericRepository<Journal>, IJournalsRepository
    {
        private readonly AppDbContext db;

        public JournalsRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
