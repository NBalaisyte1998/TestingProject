using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WeatherProject;

namespace WeatherProject.Weather_App_Service.HTTPS_Manager
{
    public class WeatherManager

    {
        readonly IRestClient client;
        public WeatherManager()
        {
            client = new RestClient(WeatherAppConfig.BaseUrl);
        }
        public string GetWeather()
        {
            string testUrl = WeatherAppConfig.BaseUrl + "/forecast?" + WeatherAppConfig.ApiUrlMod +"&"+ WeatherAppConfig.ApiKey;
            Console.WriteLine(testUrl);
            var request = new RestRequest(testUrl);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

    }
}
