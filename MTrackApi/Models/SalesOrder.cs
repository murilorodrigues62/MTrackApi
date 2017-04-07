using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Models
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public int IdDelivery { get; set; }
        public Customer Customer { get; set; }
        public bool Delivered { get; set; }
        public List<SalesOrderItem> SalesOrderItems { get; set; }

        public SalesOrder(int id, int idDelivery, Customer customer, bool delivered, List<SalesOrderItem> salesOrderItems)
        {
            Id = id;
            IdDelivery = idDelivery;
            Customer = customer;
            Delivered = delivered;
            SalesOrderItems = salesOrderItems;
        }

        public SalesOrder(int id, int idDelivery, Customer customer, bool delivered)
        {
            Id = id;
            IdDelivery = idDelivery;
            Customer = customer;
            Delivered = delivered;            
        }
    }
}