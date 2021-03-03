using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Data
{
    public class StockService
    {
        public static HttpClient ApiClient = new HttpClient();
       // Client.BaseAddress = new Uri("https://www.alphavantage.co/query");
        //request to api
        
        public void Request()
        {
            
        }
        public static void initializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //roepen naar json file

            //data lezen 

            //data omzetten naar een model

            //model door sturen naar front end
        }

    }
}
