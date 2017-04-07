using MTrackApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Data
{
    public static class SalesOrderDB
    {
        // Incluir Itens do pedido
        private static readonly List<SalesOrder> salesOrders = new List<SalesOrder>(new[]
        {new SalesOrder(279728, 29797, CustomerDB.findById(2036), false),
         new SalesOrder(279729, 29797, CustomerDB.findById(2037), false),
         new SalesOrder(279730, 29797, CustomerDB.findById(2038), false),
         new SalesOrder(279731, 29797, CustomerDB.findById(2039), false),
         new SalesOrder(279732, 29797, CustomerDB.findById(2036), false) });
            
        public static List<SalesOrder> findAll() {
            return salesOrders;                   

        }

        public static SalesOrder findById(int id)
        {
            return salesOrders.Find(item => item.Id == id);
        }
    }
}