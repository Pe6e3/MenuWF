using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _db;
        public GenericRepository(AppDbContext db)
        {
            _db = db;
        }


        public Task<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<T?> GetById(int id) => await
       _db.Set<T>().FindAsync(id);
        public async Task<T?> GetById(int id, string include1) => await
            _db.Set<T>()
            .Include(include1)
            .FirstOrDefaultAsync(x => x.Id == id);
        public async Task<T?> GetById(int id, string include1, string include2) => await
            _db.Set<T>()
            .Include(include1)
            .Include(include2)
            .FirstOrDefaultAsync(x => x.Id == id);


        public async Task<T> InsertAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}
