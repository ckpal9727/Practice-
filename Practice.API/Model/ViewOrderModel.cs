﻿using Practice.API.Entities;
using Practice.API.Enums;

namespace Practice.API.Model
{
    public class ViewOrderModel
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public int TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
