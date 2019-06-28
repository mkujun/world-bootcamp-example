using System;
using System.Collections.Generic;
using System.Text;
using world_bootcamp_example.world;

namespace world_bootcamp_example.Interfaces
{
    public interface ICountry
    {
        List<Country> GetAllCountries();
        List<Country> GetAllCountriesByContinent(string continent);
        List<Country> GetAllCountriesWithPopulationOver(int population);
        void AddCountry(Country country);
        void DeleteCountry(int countryId);
    }
}
