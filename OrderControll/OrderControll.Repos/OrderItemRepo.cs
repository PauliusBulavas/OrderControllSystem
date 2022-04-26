using OrderControll.Common;
using OrderControll.Repos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public OrderItem GetOrdersById(int orderId)
        {
            var actualOrder = OrderItems.FirstOrDefault(x => x.Id == orderId);

            return actualOrder;
        }

        public void AddOrder(OrderItem orderItem)
        {
            orderItem.Id = OrderItems.LastOrDefault().Id + 1;
            OrderItems.Add(orderItem);
        }

        public bool RemoveOrder(int id)
        {
            return OrderItems.Remove(GetOrdersById(id));
        }
    }
}