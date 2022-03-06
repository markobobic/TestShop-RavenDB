using TestShop_RavenDB.Core.ValueObjects;

namespace TestShop_RavenDB.Core.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public Email Email { get; set; }

    }
}
