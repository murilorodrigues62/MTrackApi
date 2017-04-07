using MTrackApi.Data;
using MTrackApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MTrackApi.Controllers
{
    [RoutePrefix("api")]
    public class CustomerController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("customer")]
        public List<Customer> FindAll()
        {
            return CustomerDB.findAll();
        }

        [AcceptVerbs("GET")]
        [Route("customer/{id}")]
        public Customer FindById(int id)
        {
            return CustomerDB.findById(id);
        }
    }
}
