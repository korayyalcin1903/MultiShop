using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApiWebUI.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MultiShop.RapidApiWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public async Task<IActionResult> WeatherDetail()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/current.json?q=istanbul"),
                Headers =
                {
                    { "x-rapidapi-key", "881537dd82mshd68169eaddb0a3ap15a452jsnc747b5eeeaf4" },
                    { "x-rapidapi-host", "weatherapi-com.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<WeatherViewModel.Rootobject>(body);
                ViewBag.cityTemp = values.current.temp_c;
                return View(values);
            }
        }
    
        public async Task<IActionResult> Exhange()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-finance-data.p.rapidapi.com/currency-exchange-rate?from_symbol=USD&to_symbol=TRY&language=en"),
                Headers =
                {
                    { "x-rapidapi-key", "881537dd82mshd68169eaddb0a3ap15a452jsnc747b5eeeaf4" },
                    { "x-rapidapi-host", "real-time-finance-data.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ExchangeViewModel.Rootobject>(body);
                ViewBag.exchange_rate = values.data.exchange_rate;
                return View();
            }

        }
    }
}
