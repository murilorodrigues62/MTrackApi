using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Models
{
    public class SalesOrderPackage
    {
        public int IdSalesOrder { get; set; }
        public int IdDelivery { get; set; }
        public int IdProduct { get; set; }
        public string Barcode { get; set; }
        public int IdSalesOrderReal { get; set; }

        public SalesOrderPackage(int idSalesOrder, int idDelivery, int idProduct, string barcode)
        {
            IdSalesOrder = idSalesOrder;
            IdDelivery = idDelivery;
            IdProduct = idProduct;
            Barcode = barcode;              
        }
    }
}