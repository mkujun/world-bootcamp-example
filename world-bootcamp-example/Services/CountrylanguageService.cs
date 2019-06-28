using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using world_bootcamp_example.Interfaces;
using world_bootcamp_example.world;

namespace world_bootcamp_example.Services
{
    public class CountrylanguageService : ICountrylanguage
    {
        private worldContext context;

        public CountrylanguageService(worldContext ctx)
        {
            context = ctx;
        }

        public List<Countrylanguage> GetAllCountrylanguages()
        {
            return context.Countrylanguages.ToList();
        }

        public List<Countrylanguage> GetAllCountrylanguagesByContinent(string continet)
        {
            return context.Countrylanguages.Where(c => c.CountryCodeNavigation.Continent == continet).ToList();
        }

        public List<Countrylanguage> GetAllCountrylanguagesByCountry(string countryName)
        {
            return context.Countrylanguages.Where(c => c.CountryCodeNavigation.Name == countryName).ToList();
        }
    }
}
