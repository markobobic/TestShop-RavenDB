using System.Collections.Generic;
using TestShop_RavenDB.Core.ValueObjects;

namespace TestShop_RavenDB.Core.Entities
{
    public class Order : Entity
    {
        public string CustomerId { get; }
        public decimal Discount { get; } = 0;
        private List<OrderLine> _lines = new List<OrderLine>();

        public IReadOnlyCollection<OrderLine> Lines
        {
            get { return _lines.ToArray(); }
            set { _lines = new List<OrderLine>(); }
        }

    }
}
