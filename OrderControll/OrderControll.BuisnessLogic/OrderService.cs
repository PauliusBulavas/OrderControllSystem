using OrderControll.Common.DTOs;
using OrderControll.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderControll.BuisnessLogic
{
    public class OrderService
    {
        private readonly OrderRepo _orderRepo;
        private readonly OrderItemRepo _orderItemRepo;

        public OrderService(OrderRepo orderRepo, OrderItemRepo orderItemRepo)
        { _orderRepo = orderRepo; _orderItemRepo = orderItemRepo; }

        public void SubmitOrder(OrderModel model)
        {
            var orderEntity = _orderRepo.Add(model);

            foreach (var orderItem in model.Items)
            {
                var orderItemEntity = _orderItemRepo.Add(orderItem, orderEntity.Id); // client and product needed still fak
            }
        }
    }
}