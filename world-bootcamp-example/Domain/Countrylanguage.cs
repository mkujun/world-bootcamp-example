using System;
using System.Collections.Generic;

namespace world_bootcamp_example.world
{
    public partial class Countrylanguage
    {
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public string IsOfficial { get; set; }
        public float Percentage { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
    }
}
