using System;
using System.Collections.Generic;
using System.Text;

namespace StockAPICall.DomainEntities
{
    public class StockItem
    {
        public int ItemId { get; private set; }
        public string Symbol { get; private set; }
        public DateTime LastRefreshed { get; private set; }
        public string interval { get; private set; }
        public string OutputSize { get; private set; }
        public string TimeZone { get; private set; }

    }

    //"Meta Data": {
    //    "1. Information": "Intraday (5min) open, high, low, close prices and volume",
    //    "2. Symbol": "IBM",
    //    "3. Last Refreshed": "2021-01-22 20:00:00",
    //    "4. Interval": "5min",
    //    "5. Output Size": "Compact",
    //    "6. Time Zone": "US/Eastern"
    //},
    //"Time Series (5min)": {
    //"2021-01-22 20:00:00": {
    //    "1. open": "118.8900",
    //        "2. high": "118.8900",
    //        "3. low": "118.8000",
    //        "4. close": "118.8000",
    //        "5. volume": "2731"
    //    },
    //    "2021-01-22 19:55:00": {
    }
