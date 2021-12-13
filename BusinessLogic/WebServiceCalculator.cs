using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class WebServiceCalculator
    {
        private static readonly string BaseUri = "https://localhost:7274/api/";

        public async Task<string> GetCalculation(double weight, double distance, int duration, string pace)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(BaseUri + "CalorieCalculator/" + weight + "/" + distance + "/" + duration + "/" + pace))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return string.Empty;
        }

        public async Task<string> GetNeededCalculation(double Weight, double Height, string Gender, int Age)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(BaseUri + "CalorieNeededCalculator/" + Weight + "/" + Height + "/" + Gender + "/" + Age))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return string.Empty;
        }
    }
}
