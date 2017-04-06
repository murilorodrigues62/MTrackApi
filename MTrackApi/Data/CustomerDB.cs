using MTrackApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Data
{
    public static class CustomerDB
    {
        public static List<Customer> Customers()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer(2036, "123456789", "SHOPPING FRUTAS GUARANY"));
            customers.Add(new Customer(2037, "111111111", "SUPERMERCADO LIDER LTDA"));
            customers.Add(new Customer(2038, "112233445","CASA DE CARNES POPULAR"));
            customers.Add(new Customer(2039, "998877665","AA COMERCIO DE CARNES DE SANTA BARBARA LTDA"));

            return customers;

        }
    }
}