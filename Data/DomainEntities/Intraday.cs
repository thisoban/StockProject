using System;
using System.Collections.Generic;
using System.Text;

namespace StockAPICall.DomainEntities
{
    public class Intraday
    {
        public string Information { get; set; }
        public string Symbol     { get; set; }
        public DateTime LastRefreshed { get; set; }
        public int Interval { get; set; }
       


    }
}
