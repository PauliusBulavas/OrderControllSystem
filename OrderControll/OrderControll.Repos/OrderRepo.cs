using OrderControll.Common;
using OrderControll.Repos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}