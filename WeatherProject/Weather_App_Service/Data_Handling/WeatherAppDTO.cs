using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProject.Weather_App_Service.Data_Handling
{
    public class WeatherAppDTO
    {
        public WeatherAppRoot weatherAppRoot { get; set; }
        public void DeserializeLatestRates(String LatestRatesResponse)
        {
            weatherAppRoot = JsonConvert.DeserializeObject<weatherAppRoot>(WeatherAppResponse);
        }

    }
}
