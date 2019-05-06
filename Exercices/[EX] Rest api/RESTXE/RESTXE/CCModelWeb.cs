using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTXE
{
    class CCModelWeb
    {
        const string DEFAULT_URL = "https://xecdapi.xe.com/v1/convert_from.json/?from=CHF&to=EUR&amount=110.23";

        private string _urlCurrencyConverter;
        private double _rate;
        private double _source;

        public String UrlCurrencyConverter
        {
            get { return _urlCurrencyConverter; }
            set { _urlCurrencyConverter = value; }
        }
        public double Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        public double Source
        {
            get { return _source; }
            set { _source = value; }
        }
        public CCModelWeb() :this(DEFAULT_URL){
            // No code
        }

        public CCModelWeb(string paramUrl)
        {
            this.UrlCurrencyConverter = paramUrl;

        }

        // Not implemented yet 
        // ---------------------------------------------------------

        //static void Main(string[] args)
        //{
        //    Request().Wait();
        //}
        //static async Task Request()
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://xecdapi.xe.com/v1/account_info/"))
        //        {
        //            var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("asd179647310:64ouil0isl3qijt1pdukrtkpr4"));
        //            request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

        //            var response = await httpClient.SendAsync(request);
        //            var responseText = await response.Content.ReadAsStringAsync();
        //            Console.WriteLine(responseText);
        //        }
        //    }
        //}






    }
}
