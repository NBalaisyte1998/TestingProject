using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace WeatherProject.Weather_App_Service.Data_Handling
{
    public class WeatherAppDTO
    {
        public WeatherAppRoot weatherAppRoot { get; set; }
        public void DeserializeWeatherApp(String WeatherAppResponse)
        {
            weatherAppRoot = JsonConvert.DeserializeObject<WeatherAppRoot>(WeatherAppResponse);
        }

    }
}
