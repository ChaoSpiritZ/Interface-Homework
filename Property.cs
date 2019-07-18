using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Homework
{
    public class Property
    {
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public int Value { get; set; }

        public Property(string streetName, string cityName, int value)
        {
            StreetName = streetName;
            CityName = cityName;
            Value = value;
        }

    }
}
