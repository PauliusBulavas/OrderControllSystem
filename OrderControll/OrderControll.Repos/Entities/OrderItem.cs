using System;

namespace OrderControll.Repos.Entities
{
    public class OrderItem : Entity
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public string ClientCompanyName { get; set; }
        public string ProductName { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Created { get; set; }
    }
}