using OrderControll.Common.DTOs;
using System.Collections.Generic;

namespace OrderControll.Common
{
    public class Validator
    {
        public static bool isQuantity(List<OrderItemModel> orderItems)
        {
            return orderItems.TrueForAll(x => x.Quantity > 0);
        }

        public static bool IsTotalProject(decimal price)
        {
            return price > 0;
        }
    }
}