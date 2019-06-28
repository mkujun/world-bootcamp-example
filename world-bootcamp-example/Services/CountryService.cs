using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using world_bootcamp_example.Interfaces;
using world_bootcamp_example.world;

namespace world_bootcamp_example.Services
{
    public class CountryService : ICountry
    {
        private worldContext context;

        public CountryService(worldContext ctx)
        {
            context = ctx;
        }

        public void AddCountry(Country country)
        {
            Country countryToAdd = context.Countries.Find(country.Code);

            if (countryToAdd == null)
            {
                context.Countries.Add(country);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Country with that Code doesn't exist");
            }
        }

        public void DeleteCountry(int countryCode)
        {
            Country countryToDelete = context.Countries.Find(countryCode);

            if (countryToDelete != null)
            {
                context.Countries.Remove(countryToDelete);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Country with that Code doesn't exist");
            }
        }

        public List<Country> GetAllCountries()
        {
            return context.Countries.ToList();
        }

        public List<Country> GetAllCountriesByContinent(string continent)
        {
            return context.Countries.Where(c => c.Continent == continent).ToList();
        }

        public List<Country> GetAllCountriesWithPopulationOver(int population)
        {
            return context.Countries.Where(c => c.Population > population).ToList();
        }
    }
}
