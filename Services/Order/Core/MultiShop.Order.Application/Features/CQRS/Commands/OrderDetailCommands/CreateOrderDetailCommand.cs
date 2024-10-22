﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands
{
    public class CreateOrderDetailCommand
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public decimal ProductAmount { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public int OrderingId { get; set; }
    }
}
