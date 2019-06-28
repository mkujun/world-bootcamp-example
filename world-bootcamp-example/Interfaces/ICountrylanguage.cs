using System;
using System.Collections.Generic;
using System.Text;
using world_bootcamp_example.world;

namespace world_bootcamp_example.Interfaces
{
    public interface ICountrylanguage
    {
        List<Countrylanguage> GetAllCountrylanguages();
        List<Countrylanguage> GetAllCountrylanguagesByContinent(string continet);
        List<Countrylanguage> GetAllCountrylanguagesByCountry(string countryName);
    }
}
