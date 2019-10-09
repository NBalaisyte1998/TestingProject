﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WeatherProject.Weather_App_Service.HTTPS_Manager;
using WeatherProject.Weather_App_Service.Data_Handling;

namespace WeatherProject.Weather_App_Service
{
    class WeatherAppService
    {
        public WeatherAppDTO weatherAppDTO = new WeatherAppDTO();
        //public WeatherAppService weatherAppService = new WeatherAppService();
        public JObject WeatherJSon;

        public WeatherManager weatherAppManager = new WeatherManager();


        public WeatherAppService()  
        {
            weatherAppDTO.DeserializeWeatherApp(weatherAppManager.GetWeather());
            WeatherJSon = JObject.Parse(weatherAppManager.GetWeather());
        }
    
    }
}
