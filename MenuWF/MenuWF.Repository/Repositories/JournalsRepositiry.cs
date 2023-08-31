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
            Journal? oldJournal = await db.Journals.FirstOrDefaultAsync(x => x.DishId == journal.DishId && x.Date == journal.Date && x.meal == journal.meal);
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

        // получаем все строки журнала, которые соответстуют выбранной дате и типу приема пищи
        internal async Task<IEnumerable<Journal>> GetJournalsByDayAndMeal(DateTime date, Journal.Meal meal)
        {
            IEnumerable<Journal> journals = new List<Journal>();
            journals = await db.Journals
                .Where(x => x.Date == date && x.meal == meal)
                .Include(x => x.Dish)
                .ToListAsync();

            return journals;
        }

        // Находим конкретный пункт в меню в конкретный день и прием пищи
        internal async Task<Journal> GetJournalByDayMealAndDishId(DateTime date, Journal.Meal meal, int dishId)
        {
            Journal? journal = new Journal();
            journal = await db.Journals
                .Include(x => x.Dish)
                .FirstOrDefaultAsync(x => x.Date == date && x.meal == meal && x.DishId == dishId);

            return journal;
        }
    }
}
