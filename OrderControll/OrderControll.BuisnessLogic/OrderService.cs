using OrderControll.Common.DTOs;
using OrderControll.Repos;
using OrderControll.Repos.Entities;
using System.Collections.Generic;

namespace OrderControll.BuisnessLogic
{
    public class OrderService
    {
        private readonly OrderItemRepo _orderItemRepo;
        private readonly ClientRepo _clientRepo;
        private readonly ProductRepo _productRepo;
        private readonly Utility<Entity> utility;

        public OrderService(OrderItemRepo orderItemRepo, ClientRepo clientRepo, ProductRepo productRepo)
        {
            _orderItemRepo = orderItemRepo;
            _clientRepo = clientRepo;
            _productRepo = productRepo;
        }
    }
}