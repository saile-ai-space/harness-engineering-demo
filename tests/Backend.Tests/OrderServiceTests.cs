using Beispiel.Demo.Backend.Orders;
using Xunit;

namespace Beispiel.Demo.Backend.Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public void GetTotal_OrderWithoutItems_ReturnsZero()
        {
            // Arrange
            var service = new OrderService();
            var order = new Order { Customer = "Muster GmbH" };

            // Act
            var total = service.GetTotal(order);

            // Assert
            Assert.Equal(0, total);
        }
    }
}
