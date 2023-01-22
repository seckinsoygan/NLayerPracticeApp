using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
