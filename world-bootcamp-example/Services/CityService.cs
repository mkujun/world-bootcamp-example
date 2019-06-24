using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using world_bootcamp_example.Interfaces;
using world_bootcamp_example.world;

namespace world_bootcamp_example.Services
{
    public class CityService : ICity
    {
        private worldContext context;

        public CityService(worldContext ctx)
        {
            context = ctx;
        }

        public List<City> GetAllCities()
        {
            return context.Cities.ToList();
        }

        // public IEnumerable<City> GetAllCities => context.Cities;

        public void AddCity(City city)
        {
            // todo : provjeri postoji li taj city u bazi
            context.Cities.Add(city);

            context.SaveChanges();
        }
    }
}
