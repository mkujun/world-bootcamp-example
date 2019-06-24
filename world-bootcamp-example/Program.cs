using System;
using System.Collections.Generic;
using world_bootcamp_example.Services;
using world_bootcamp_example.world;

namespace world_bootcamp_example
{
    class Program
    {
        static void Main(string[] args)
        {
            worldContext context = new worldContext();
            CityService cityService = new CityService(context);

            // cityService.AddCity(new City(5000, "markov grad", "markovija", 2, "PSE"));
            // cityService.UpdateCity(5001, "markov promijenjeni grad", "markovija", 5, "PSE");
            // cityService.DeleteCity(5001);
            // List<City> cities = cityService.FindCities("", "", 12000, "");
        }
    }
}
