using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Homework
{
    public class House : Property, ITaxable
    {
        public int HouseArea { get; set; }
        public int GardenArea { get; set; }

        public House(int houseArea, int gardenArea) : base("ha-shalom", "tel-aviv", 1000000)
        {
            HouseArea = houseArea;
            GardenArea = gardenArea;
        }

        public double CalculateTax()
        {
            return Value * 0.00001 * (HouseArea + (GardenArea * 0.5));
        }

    }
}
