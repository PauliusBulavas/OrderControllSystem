namespace OrderControll.Repos.Entities
{
    public class OrderItem : Entity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
    }
}