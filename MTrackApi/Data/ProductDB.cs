using MTrackApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Data
{
    public static class ProductDB
    {
        public static List<Product> Products()  {

            List<Product> products = new List<Product>();
            products.Add(new Product(1, "0001", "ASA RESFRIADA"));
            products.Add(new Product(2, "0101", "PEITO CONGELADO"));
            products.Add(new Product(3, "0005", "FRANGO INTEIRO"));
            products.Add(new Product(4, "0012", "PE CONGELADO"));
            products.Add(new Product(5, "0031", "MEIO DA ASA"));
            products.Add(new Product(6, "1122", "CORACAO RESFRIADO"));

            return products;        
        }
    }
}