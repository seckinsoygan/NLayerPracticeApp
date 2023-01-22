using Entities.Abstract;

namespace Entities.Concrete
{
    public class Category : BaseEntity
    {
        public ICollection<Product> Products { get; set; }
    }
}
