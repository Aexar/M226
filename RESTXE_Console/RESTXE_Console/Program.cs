using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace RESTXE_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Request().Wait();
        }
        static async Task Request()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://xecdapi.xe.com/v1/account_info/"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("asd179647310:64ouil0isl3qijt1pdukrtkpr4"));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    var response = await httpClient.SendAsync(request);
                    var responseText = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseText);
                }
            }
        }
    }
}
