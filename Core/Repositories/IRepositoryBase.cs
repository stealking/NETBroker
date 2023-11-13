using System.Linq.Expressions;

namespace Core.Repositories
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> FindAllAsync();
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expressionparams, params Expression<Func<T, object>>[] includes);
        Task<T?> FindById(object id);

    }
}
