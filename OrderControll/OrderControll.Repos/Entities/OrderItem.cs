using System;
using System.Collections.Generic;
using System.Text;

namespace OrderControll.Repos.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
    }
}