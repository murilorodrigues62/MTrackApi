using MTrackApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Data
{
    public class SalesOrderItemDB
    {
        private static readonly List<SalesOrderItem> salesOrderItems = new List<SalesOrderItem>(new[]
        {   new SalesOrderItem( 1, ProductDB.findById(1), 2),
            new SalesOrderItem( 2, ProductDB.findById(2), 2),
            new SalesOrderItem( 3, ProductDB.findById(3), 4),
            new SalesOrderItem( 4, ProductDB.findById(4), 2),
            new SalesOrderItem( 5, ProductDB.findById(5), 1),
            new SalesOrderItem( 6, ProductDB.findById(6), 2),
            new SalesOrderItem( 7, ProductDB.findById(2), 2),
            new SalesOrderItem( 8, ProductDB.findById(4), 10),
            new SalesOrderItem( 9, ProductDB.findById(1), 2),
            new SalesOrderItem(10, ProductDB.findById(6), 2),
            new SalesOrderItem(11, ProductDB.findById(5), 2),
            new SalesOrderItem(12, ProductDB.findById(1), 5),
            new SalesOrderItem(13, ProductDB.findById(3), 20)
        });

        public static List<SalesOrderItem> findAll()
        {
            return salesOrderItems;
        }

        public static SalesOrderItem findById(int id)
        {
            return salesOrderItems.Find(item => item.Id == id);
        }
    }
}