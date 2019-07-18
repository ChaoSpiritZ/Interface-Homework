using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Homework
{
    public class Vehicle
    {
        public int LicencePlate { get; set; }
        public int MaxSpeed { get; set; }
        public int Value { get; set; }

        public Vehicle(int licencePlate, int maxSpeed, int value)
        {
            LicencePlate = licencePlate;
            MaxSpeed = maxSpeed;
            Value = value;
        }

    }
}
