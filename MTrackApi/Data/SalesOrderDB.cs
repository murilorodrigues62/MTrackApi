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
        {new SalesOrder(279728, 29797, "1", CustomerDB.findById(2036), false, 
            new List<SalesOrderItem>(new[] {SalesOrderItemDB.findById(1), SalesOrderItemDB.findById(2), SalesOrderItemDB.findById(3), SalesOrderItemDB.findById(4), SalesOrderItemDB.findById(5), SalesOrderItemDB.findById(6)})),
         new SalesOrder(279729, 29797, "1", CustomerDB.findById(2037), false,
             new List<SalesOrderItem>(new[] {SalesOrderItemDB.findById(7), SalesOrderItemDB.findById(8)})),
         new SalesOrder(279730, 29797, "1", CustomerDB.findById(2038), false,
             new List<SalesOrderItem>(new[] {SalesOrderItemDB.findById(9), SalesOrderItemDB.findById(10), SalesOrderItemDB.findById(11)})),
         new SalesOrder(279731, 29797, "1", CustomerDB.findById(2039), false,
             new List<SalesOrderItem>(new[] {SalesOrderItemDB.findById(12)})),
         new SalesOrder(279732, 29798, "2", CustomerDB.findById(2036), false,
             new List<SalesOrderItem>(new[] {SalesOrderItemDB.findById(13) }))});
            
        public static List<SalesOrder> findAll() {
            return salesOrders;               
        }

        public static SalesOrder findById(int id)
        {
            return salesOrders.Find(item => item.Id == id);
        }

        public static List<SalesOrder> findByTransporter(string id)
        {
            return salesOrders.FindAll(item => item.TransporterCode.Equals(id));
        }

    }
}