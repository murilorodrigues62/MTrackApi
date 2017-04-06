using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public Customer(int id, string code, string name)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
        }
    }
}