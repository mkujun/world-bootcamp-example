﻿using System;
using System.Collections.Generic;
using System.Text;
using world_bootcamp_example.world;

namespace world_bootcamp_example.Interfaces
{
    public interface ICity
    {
        List<City> GetAllCities();
        void AddCity(City city);
        void DeleteCity(int cityId);
        void UpdateCity(int id, string name, string district, int population, string countryCode);
        List<City> FindCities(string name, string district, int? population, string countryCode);
    }
}
