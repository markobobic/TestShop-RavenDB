using System.Collections.Generic;

namespace TestShop_RavenDB.Core.ValueObjects
{
    public class OrderLine : ValueObject
    {
        public string ProductId { get; }
        public int Quantity { get; }
        public decimal Price { get; set; }
        public decimal Total => Price * Quantity;
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return ProductId;
            yield return Price;
        }
    }
}
