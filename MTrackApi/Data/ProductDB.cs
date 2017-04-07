using MTrackApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Data
{
    public static class ProductDB
    {
        private static readonly List<Product> products = new List<Product> (new[] 
            {new Product(1, "0001", "ASA RESFRIADA"),
             new Product(2, "0101", "PEITO CONGELADO"),
             new Product(3, "0005", "FRANGO INTEIRO"),
             new Product(4, "0012", "PE CONGELADO"),
             new Product(5, "0031", "MEIO DA ASA"),
             new Product(6, "1122", "CORACAO RESFRIADO")
            });

        public static List<Product> findAll()
        {
            return products;
        }

        public static Product findById(int id)
        {
            return products.Find(item => item.Id == id);
        }

    }
}