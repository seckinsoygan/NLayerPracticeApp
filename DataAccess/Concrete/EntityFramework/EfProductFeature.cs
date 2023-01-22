using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductFeature : IProductFeatureDal
    {
        public Task<ProductFeature> AddAsync(ProductFeature entity)
        {
            throw new NotImplementedException();
        }

        public Task<ProductFeature> AnyAsync(Expression<Func<ProductFeature, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductFeature entity)
        {
            throw new NotImplementedException();
        }

        public Task<ProductFeature> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductFeature entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductFeature> Where(Expression<Func<ProductFeature, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
