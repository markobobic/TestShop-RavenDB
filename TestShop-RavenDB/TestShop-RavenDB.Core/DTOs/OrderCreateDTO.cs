using System.Collections.Generic;
using TestShop_RavenDB.Core.ValueObjects;

namespace TestShop_RavenDB.Core.DTOs
{
    public class OrderCreateDTO
    {
        public string CustomerId { get; set; }
        public decimal Discount { get; set; }
        public List<OrderLineCreateDTO> OrderLines { get; set; } = new();
       
    }
}
