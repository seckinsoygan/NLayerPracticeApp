using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public Task<Category> AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> AnyAsync(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> Where(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
