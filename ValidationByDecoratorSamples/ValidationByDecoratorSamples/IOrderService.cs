using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationByDecoratorSamples
{
    public interface IOrderService
    {
        OrderCreatingResult AddOrder(Order order);

        OrderDeletingResult Delete(Order order);
    }
}
