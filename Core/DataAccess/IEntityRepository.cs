using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class
    {
        Task<T> GetById(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> filter);
        Task<T> AnyAsync(Expression<Func<T, bool>> filter);
        Task<T> AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
