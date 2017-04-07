using MTrackApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Data
{
    public static class CustomerDB
    {
        private static readonly List<Customer> customers = new List<Customer>(new[]
        {new Customer(2036, "123456789", "SHOPPING FRUTAS GUARANY"),
         new Customer(2037, "111111111", "SUPERMERCADO LIDER LTDA"),
         new Customer(2038, "112233445", "CASA DE CARNES POPULAR"),
         new Customer(2039, "998877665", "AA COMERCIO DE CARNES DE SANTA BARBARA LTDA")
        }); 

        public static List<Customer> findAll()
        {
            return customers;
        }

        public static Customer findById(int id)
        {
            return customers.Find(item => item.Id == id);
        }
    }
}