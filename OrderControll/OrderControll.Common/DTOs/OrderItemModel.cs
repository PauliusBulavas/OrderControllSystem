using System;

namespace OrderControll.Common.DTOs
{
    public class OrderItemModel
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string ClientCompanyName { get; set; }
        public string ProductName { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Created { get; set; }
    }
}