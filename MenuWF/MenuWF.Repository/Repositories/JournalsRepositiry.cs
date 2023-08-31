using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class JournalsRepository : GenericRepository<Journal>, IJournalsRepository
    {
        private readonly AppDbContext db;

        public JournalsRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        // проверяем, если в журнале есть уже подобное блюдо, то прибавляем вес к нему. Если нет - создаем новую запись
        internal async Task AddJournal(Journal journal)
        {
            Journal? oldJournal = await db.Journals.FirstOrDefaultAsync(x => x.RecipeId == journal.RecipeId && x.Date == journal.Date && x.meal == journal.meal);
            if (oldJournal == null)
            {
                await db.Journals.AddAsync(journal);
                await db.SaveChangesAsync();
            }
            else
            {
                oldJournal.DishWeight += journal.DishWeight;
                db.Entry(oldJournal).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }
    }
}
