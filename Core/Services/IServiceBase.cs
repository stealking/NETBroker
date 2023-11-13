namespace Core.Services
{
    public interface IServiceBase<T, T1, T2>
    {
        Task<List<T>> GetAll(T2 parameter);
        Task<T?> GetById(object id);
        Task<bool> Create(T1 entity);
        Task Update(T1 entity);
        Task<bool> Delete(int id);
    }
}
