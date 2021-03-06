﻿using MTrackApi.Data;
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
    public class SalesOrderPackageController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("package")]
        public List<SalesOrderPackage> FindAll()
        {
            return SalesOrderPackageDB.findAll();
        }

        [AcceptVerbs("GET")]
        [Route("package/{id}")]
        public List<SalesOrderPackage> FindByDelivery(int id)
        {
            return SalesOrderPackageDB.findByDelivery(id);
        }

        [AcceptVerbs("POST")]
        [Route("package")]
        public bool UpdateSalesOrderReal(List<SalesOrderPackage> salesOrderPackages)
        {
            return SalesOrderPackageDB.updateSalesOrderReal(salesOrderPackages);
        }
        
        [AcceptVerbs("GET")]
        [Route("transporter/{id}/package")]
        public List<SalesOrderPackage> FindByTransporter(string id)
        {
            return SalesOrderPackageDB.findByTransporter(id);
        }

    }

}
