using System.Collections.Generic;

namespace Beispiel.Demo.Backend.Orders
{
    public class Order
    {
        public string Customer { get; set; } = string.Empty;

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }

    public class OrderItem
    {
        public string Product { get; set; } = string.Empty;

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
