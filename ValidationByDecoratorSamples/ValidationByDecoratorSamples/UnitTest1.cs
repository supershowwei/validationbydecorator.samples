using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidationByDecoratorSamples
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddOrder_with_Decorator()
        {
            var orderService = new OrderServiceWithValidation(new OrderService());
            var order = new Order() { CustomerName = "" };

            var result = orderService.AddOrder(order);

            Assert.IsTrue(result.IsSuccess);
        }
    }
}
