using Newtonsoft.Json;
using ConsoleTask1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PratikConsoleAPP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<RegDetail> dlist = new List<RegDetail>();
            var httpclient = new HttpClient();
            var response = await httpclient.GetAsync("https://localhost:7133/api/Regdetails");
            string result = await response.Content.ReadAsStringAsync();
            dlist = JsonConvert.DeserializeObject<List<RegDetail>>(result);

            foreach (var i in dlist)
            {
                Console.WriteLine(i.Rid+","+i.Firstname+","+i.Mailid+","+i.Contactno+","+i.Experience);
            }
        }
    }
}