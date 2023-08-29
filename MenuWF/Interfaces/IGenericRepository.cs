using System.Collections.Generic;

namespace MenuWF.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAllDesc();
        Task<T> GetById(int id);
        Task<T> Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
