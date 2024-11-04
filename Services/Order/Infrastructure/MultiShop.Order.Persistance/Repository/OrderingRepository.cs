﻿using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using MultiShop.Order.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Persistance.Repository
{
    public class OrderingRepository : IOrderingRepository
    {
        private readonly OrderContext _orderContext;

        public OrderingRepository(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        public List<Ordering> GetOrderingByUserId(string id)
        {
            var values = _orderContext.Orderings.Where(x => x.UserId == id).ToList();
            return values;
        }
    }
}
