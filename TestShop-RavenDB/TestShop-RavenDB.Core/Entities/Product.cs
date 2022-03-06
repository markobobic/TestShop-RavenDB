using TestShop_RavenDB.Core.ValueObjects;

namespace TestShop_RavenDB.Core.Entities
{
    public class Product : Entity
    {
        public ProductName Name { get; set; }
        public Price Price { get; set; }
    }
}
