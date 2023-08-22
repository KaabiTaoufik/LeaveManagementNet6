namespace LeaveManagement.web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<bool> Exists(int id);
    }
}
