using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void KanyeWestQuote()
        {
            var client = new HttpClient();

            var kanyeWestURL = "https://api.kanye.rest/";

            var kanyeWestResponse = client.GetStringAsync(kanyeWestURL).Result;

            var kanyeWestObject = JObject.Parse(kanyeWestResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye: {kanyeWestObject}");

        }

        public static void RonSwansonQuote()
        {
            var client = new HttpClient();

            var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronSwansonResponse = client.GetStringAsync(ronSwansonURL).Result;

            var ronSwansonArray = JArray.Parse(ronSwansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim(); ;
            
            Console.WriteLine($"Ron: {ronSwansonArray}");
                    
        }
    }
}
