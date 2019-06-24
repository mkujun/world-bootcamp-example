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

        public void AddCity(City city)
        {
            City cityToAdd = context.Cities.Find(city.Id);

            if (cityToAdd == null)
            {
                context.Cities.Add(city);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("City with that Id doesn't exist");
            }
        }

        public void DeleteCity(int cityId)
        {
            City cityToDelete = context.Cities.Find(cityId);

            if (cityToDelete != null)
            {
                context.Cities.Remove(cityToDelete);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("City with that Id doesn't exist");
            }
        }

        public void UpdateCity(int id, string name, string district, int population, string countryCode)
        {
            City cityToUpdate = context.Cities.Find(id);

            if (cityToUpdate != null)
            {
                cityToUpdate.Name = name;
                cityToUpdate.District = district;
                cityToUpdate.Population = population;
                cityToUpdate.CountryCode = countryCode;

                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("City with that Id doesn't exist");
            }
        }

        public List<City> FindCities(string name, string district, int? population, string countryCode)
        {
            var query = context.Cities.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(c => c.Name == name);
            }
            if (!string.IsNullOrEmpty(district))
            {
                query = query.Where(c => c.District == district);
            }
            if (!string.IsNullOrEmpty(countryCode))
            {
                query = query.Where(c => c.CountryCode == countryCode);
            }
            if (population != null)
            {
                query = query.Where(c => c.Population == population);
            }

            return query.ToList();
        }
    }
}
