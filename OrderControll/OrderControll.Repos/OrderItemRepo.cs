using OrderControll.Common;
using OrderControll.Common.DTOs;
using OrderControll.Repos.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OrderControll.Repos
{
    public class OrderItemRepo
    {
        private List<OrderItem> OrderItems { get; set; }

        public OrderItemRepo()
        {
            string fileName = FileReaderService.GetPathToResource("OrdersRepository.txt");
            OrderItems = new FileReaderService().Import<OrderItem>(fileName);
        }

        public List<OrderItem> GetOrderItems() => OrderItems;

        public OrderItem Add(OrderItemModel orderItem, Client client, Product product, int orderId)
        {
            if (orderItem != null)
            {
                var entity = new OrderItem
                {
                    Id = OrderItems.Count() + 1,
                    Name = orderItem.Name,
                    ClientId = client.Id,
                    ProductId = product.Id,
                    OrderId = orderId,
                    Quantity = orderItem.Quantity
                };

                OrderItems.Add(entity);

                return entity;
            }

            return null;
        }
    }
}