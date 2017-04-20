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
            new SalesOrderPackage(279728, 29797, 1, "00011", "1"),
            new SalesOrderPackage(279728, 29797, 1, "00012", "1"),
            new SalesOrderPackage(279731, 29797, 1, "00013", "1"),
            new SalesOrderPackage(279731, 29797, 1, "00014", "1"),
            new SalesOrderPackage(279731, 29797, 1, "00015", "1"),
            new SalesOrderPackage(279731, 29797, 1, "00016", "1"),
            new SalesOrderPackage(279731, 29797, 1, "00017", "1"),
            new SalesOrderPackage(279728, 29797, 2, "01011", "1"),
            new SalesOrderPackage(279728, 29797, 2, "01012", "1"),
            new SalesOrderPackage(279728, 29797, 3, "00051", "1"),
            new SalesOrderPackage(279728, 29797, 3, "00052", "1"),
            new SalesOrderPackage(279728, 29797, 4, "00121", "1"),
            new SalesOrderPackage(279728, 29797, 5, "00311", "1"),
            new SalesOrderPackage(279999, 29799, 5, "00399", "2")});
        
        public static List<SalesOrderPackage> findAll()
        {
            return packages;
        }

        public static List<SalesOrderPackage> findByDelivery(int id)
        {           
            return packages.FindAll(item => item.IdDelivery == id);
        }

        public static List<SalesOrderPackage> findByTransporter(String code)
        {
            return packages.FindAll(item => item.TransporterCode.Equals(code));
        }

        public static bool updateSalesOrderReal(SalesOrderPackage package)
        {
            SalesOrderPackage packageUpdate =  packages.Find(item => item.IdDelivery == package.IdDelivery ||
                                                                     item.IdProduct == package.IdProduct ||
                                                                     item.Barcode == package.Barcode);
            packageUpdate.IdSalesOrderReal = package.IdSalesOrderReal;

            return true;
        }        
    }
}