using MTrackApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTrackApi.Data
{
    public class SalesOrderPackageDB
    {
        private static readonly List<SalesOrderPackage> packages = new List<SalesOrderPackage>(new[]
        {
            new SalesOrderPackage(279728, 29797, 1, "00011"),
            new SalesOrderPackage(279728, 29797, 1, "00012"),
            new SalesOrderPackage(279731, 29797, 1, "00013"),
            new SalesOrderPackage(279731, 29797, 1, "00014"),
            new SalesOrderPackage(279731, 29797, 1, "00015"),
            new SalesOrderPackage(279731, 29797, 1, "00016"),
            new SalesOrderPackage(279731, 29797, 1, "00017"),
            new SalesOrderPackage(279728, 29797, 2, "01011"),
            new SalesOrderPackage(279728, 29797, 2, "01012"),
            new SalesOrderPackage(279728, 29797, 3, "00051"),
            new SalesOrderPackage(279728, 29797, 3, "00052"),
            new SalesOrderPackage(279728, 29797, 4, "00121"),
            new SalesOrderPackage(279728, 29797, 5, "00311") });
        
        public static List<SalesOrderPackage> findAll()
        {
            return packages;
        }

        public static List<SalesOrderPackage> findByDelivery(int id)
        {
            /*
            List<SalesOrderPackage> deliveryPackages = new List<SalesOrderPackage>();

            foreach (SalesOrderPackage item in packages)
            {
                if (item.IdDelivery == id)
                {
                    deliveryPackages.Add(item);
                }
            }
            return deliveryPackages;
            */
            return packages.FindAll(item => item.IdDelivery == id);
        }        
    }
}