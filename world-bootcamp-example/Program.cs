using System;
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
        }
    }
}
