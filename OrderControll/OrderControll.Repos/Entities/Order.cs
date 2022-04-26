using System;

namespace OrderControll.Repos.Entities
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Created { get; set; }
    }
}