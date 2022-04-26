using System;
using System.Collections.Generic;
using System.Text;

namespace OrderControll.Common.DTOs
{
    public class OrderModel
    {
        public decimal TotalPrice { get; set; }
        public List<OrderItemModel> Items { get; set; }
    }
}