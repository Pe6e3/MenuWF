using System.Collections.Generic;

namespace MenuWF.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllDesc();
        Task<T> GetById(int id);
        Task<T> Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
