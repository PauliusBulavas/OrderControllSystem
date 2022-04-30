using OrderControll.Common;
using OrderControll.Common.DTOs;
using OrderControll.Repos.Entities;
using System;
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

        public OrderItem Add(OrderItemModel orderItem, Client client, Product product)
        {
            if (orderItem != null)
            {
                var entity = new OrderItem
                {
                    Id = OrderItems.Count() + 1,
                    Name = orderItem.Name,
                    ClientId = client.Id,
                    ClientCompanyName = client.CompanyName,
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Quantity = orderItem.Quantity,
                    TotalPrice = product.Price * orderItem.Quantity,
                    Created = DateTime.Now,
                };

                OrderItems.Add(entity);

                return entity;
            }

            return null;
        }
    }
}