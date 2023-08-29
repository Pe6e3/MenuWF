namespace MenuWF.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAll();
        Task<T> GetById(int id);
        Task<T> InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
