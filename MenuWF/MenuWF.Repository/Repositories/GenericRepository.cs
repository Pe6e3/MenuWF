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


        public async Task<T> Insert(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
        }



        public async Task<IReadOnlyList<T>> GetAll()
        {
            IReadOnlyList<T> entities = await _db.Set<T>().ToListAsync();
            _db.Dispose();
            return entities;
        }


        public async Task<IReadOnlyList<T>> GetAllDesc() => await
        _db.Set<T>()
        .OrderByDescending(x => x.Id)
        .ToListAsync();

        public async Task<IReadOnlyList<T>> GetAllDesc(string include) => await
        _db.Set<T>()
        .Include(include)
        .OrderByDescending(x => x.Id)
        .ToListAsync();


        public async Task<IReadOnlyList<T>> GetAll(int count, string include) => await
            _db.Set<T>()
            .Include(include)
            .Take(count)
            .ToListAsync();

        public async Task<IReadOnlyList<T>> GetAll(int count, string include, string include2) => await
            _db.Set<T>()
            .Include(include)
            .Include(include2)
            .Take(count)
            .ToListAsync();

        public async Task<IReadOnlyList<T>> GetAll(string include) => await
        _db.Set<T>()
        .Include(include)
        .ToListAsync();

        public async Task<IReadOnlyList<T>> GetAll(string include, string include2) => await
        _db.Set<T>()
        .Include(include)
        .Include(include2)
        .ToListAsync();


    }
}
