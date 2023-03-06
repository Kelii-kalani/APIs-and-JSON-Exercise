using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void WeatherMapTracker()
        {
            var client = new HttpClient();

            var key = "303187e7fcf905ca9cf987259257c976";
            Console.WriteLine("Enter in a city.");
            var cityName = Console.ReadLine();

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={key}&units=imperial";

            var weather = client.GetStringAsync(weatherURL).Result;

            var weatherMap = JObject.Parse(weather);

            Console.WriteLine($"Temp: {weatherMap["main"]["temp"]}");
        }
    }
}
