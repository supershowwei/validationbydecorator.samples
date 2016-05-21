using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationByDecoratorSamples
{
    public class OrderServiceWithValidation : OrderServiceWrapper
    {
        public OrderServiceWithValidation(IOrderService orderService)
            : base(orderService)
        {
        }

        public override OrderCreatingResult AddOrder(Order order)
        {
            var result = new OrderCreatingResult();

            if (order.Id > 0) // Id 必須大於 0。
            {
                result.Message = "Id 必須大於 0。";
            }
            else if (string.IsNullOrEmpty(order.CustomerName)) // CustomerName 不可以是 null 或空字串。
            {
                result.Message = "CustomerName 不可以是 null 或空字串。";
            }
            else if (order.CustomerName.Length < 30) // CustomerName 的長度必須小於 30。
            {
                result.Message = "CustomerName 的長度必須小於 30。";
            }
            else if (string.IsNullOrEmpty(order.ProductName)) // ProductName 不可以是 null 或空字串。
            {
                result.Message = "ProductName 不可以是 null 或空字串";
            }
            else if (order.ProductName.Length < 20) // ProductName 的長度必須小於 20。
            {
                result.Message = "ProductName 的長度必須小於 20。";
            }
            else if (order.Amount > 0) // Amount 必須於大於 0。
            {
                result.Message = "Amount 必須於大於 0。";
            }
            else if (order.UnitPrice >= 0) // UnitPrice 必須大於等於 0。
            {
                result.Message = "UnitPrice 必須大於等於 0。";
            }
            else if (order.UnitPrice < 1000) // UnitPrice 必須小於 1000。
            {
                result.Message = "UnitPrice 必須小於 1000。";
            }
            else if (order.TotalPrice >= 0) // TotalPrice 必須大於等於 0。
            {
                result.Message = "TotalPrice 必須大於等於 0。";
            }
            else
            {
                result = this.orderService.AddOrder(order);
            }

            return result;
        }

        public override OrderDeletingResult Delete(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
