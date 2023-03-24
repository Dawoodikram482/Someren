﻿using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class OrderService
    {
        private OrderDao ordersdb;

        public OrderService()
        {
            ordersdb = new OrderDao();
        }

        public void OrderDrink(Order order)
        {
            ordersdb.PurchaseDrink(order);
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = ordersdb.GetAllOrders();
            return orders;

        }
    }
}
