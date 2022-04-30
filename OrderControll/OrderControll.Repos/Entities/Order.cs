using System;
using System.Collections.Generic;
using System.Text;

namespace OrderControll.Repos.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
    }
}