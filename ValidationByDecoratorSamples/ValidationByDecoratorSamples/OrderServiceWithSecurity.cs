using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationByDecoratorSamples
{
    public class OrderServiceWithSecurity : OrderServiceWrapper
    {
        public OrderServiceWithSecurity(IOrderService orderService)
            : base(orderService)
        {
        }

        public override OrderCreatingResult AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public override OrderDeletingResult Delete(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
