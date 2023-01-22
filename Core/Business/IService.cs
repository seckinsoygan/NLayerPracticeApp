using System.Linq.Expressions;

namespace Core.Business
{
    public interface IService<T> where T : class
    {
        Task<T> GetById(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> filter);
        Task<T> AnyAsync(Expression<Func<T, bool>> filter);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
