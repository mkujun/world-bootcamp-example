using System;
using System.Collections.Generic;

namespace world_bootcamp_example.world
{
    public partial class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string District { get; set; }
        public int Population { get; set; }

        public City(int id, string name, string district, int population, string countryCode)
        {
            Id = id;
            Name = name;
            District = district;
            Population = population;
            CountryCode = countryCode;
        }

        public void UpdateCity(int id, string name, string district, int population, string countryCode)
        {
            Name = name;
            District = district;
            Population = population;
            CountryCode = countryCode;
        }

        public virtual Country CountryCodeNavigation { get; set; }
    }
}
