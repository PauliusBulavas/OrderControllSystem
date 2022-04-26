using OrderControll.Common.DTOs;
using OrderControll.Repos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderControll.Repos
{
    public class OrderRepo
    {
        private List<Order> Orders { get; set; }

        public OrderRepo()
        {
            //string fileName = FileReaderService.GetPathToResource("OrdersRepository.txt");
            //Orders = new FileReaderService().Import<Order>(fileName);
        }

        public List<Order> GetOrders() => Orders;

        public Order Add(OrderModel order)
        {
            if (order != null)
            {
                var entity = new Order
                {
                    Id = Orders.Count() + 1,
                    TotalPrice = order.TotalPrice,
                    Created = DateTime.Now
                };

                Orders.Add(entity);

                return entity;
            }

            return null;
        }
    }
}