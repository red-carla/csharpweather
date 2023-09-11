using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string URLString = "http://api.openweathermap.org/data/2.5/weather?q=Amsterdam&appid=d26ac9920bb71bc7ebe78c5956ede339&units=metric&lang=nl&mode=JSON";

            JsonTextReader reader = new JsonTextReader(new StringReader(URLString));
            while (reader.Value != null)
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }
    }
}
