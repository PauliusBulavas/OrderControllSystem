using System;
using System.Collections.Generic;
using System.Text;

namespace OrderControll.Repos.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Created { get; set; }
    }
}