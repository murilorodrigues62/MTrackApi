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
    public class SalesOrderController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("order")]
        public List<SalesOrder> FindAll()
        {
            return SalesOrderDB.findAll();
        }

        [AcceptVerbs("GET")]
        [Route("order/{id}")]
        public SalesOrder FindById(int id)
        {
            return SalesOrderDB.findById(id);
        }

        [AcceptVerbs("GET")]
        [Route("transporter/{id}/order")]
        public List<SalesOrder> FindTransporter(string id)
        {
            return SalesOrderDB.findByTransporter(id);
        }
    }
}
