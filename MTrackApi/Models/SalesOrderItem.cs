using System;
using System.Collections.Generic;

namespace MTrackApi.Models
{
    public class SalesOrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public SalesOrderItem(int id, Product product, int quantity)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
        }      
    }
}