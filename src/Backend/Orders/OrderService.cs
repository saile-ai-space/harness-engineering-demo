using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Beispiel.Demo.Backend.Orders
{
    // Demo-Code: absichtlich mit Schwächen, damit das Review etwas findet.
    public class OrderService
    {
        public string connectionString = "Server=demo-sql;Database=Orders;User Id=sa;Password=Demo123!";

        public double GetTotal(Order order)
        {
            double total = 0;
            foreach (var item in order.Items)
            {
                total = total + item.Price * item.Quantity;
            }

            if (total > 1000)
            {
                total = total * 0.9;
            }

            return total;
        }

        public Order LoadOrder(string customerName)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(
                    "SELECT * FROM Orders WHERE Customer = '" + customerName + "'", connection);
                var reader = command.ExecuteReader();
                var order = new Order();
                while (reader.Read())
                {
                    order.Customer = reader["Customer"].ToString();
                }
                return order;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void SaveOrder(Order order)
        {
            SaveOrderAsync(order).Result.ToString();
            Console.WriteLine("Order saved: " + order.Customer);
        }

        private async Task<bool> SaveOrderAsync(Order order)
        {
            await Task.Delay(100);
            return true;
        }
    }
}
