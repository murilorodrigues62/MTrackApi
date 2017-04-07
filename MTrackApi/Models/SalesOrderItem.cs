using System;
using System.Collections.Generic;

namespace MTrackApi.Models
{
    public class SalesOrderItem
    {
        public static implicit operator List<object>(SalesOrderItem v)
        {
            throw new NotImplementedException();
        }
    }
}