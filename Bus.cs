using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Homework
{
    public class Bus : Vehicle, ITaxable
    {
        public int NumOfSeats { get; set; }

        public Bus(int numOfSeats) : base(1234567, 230, 5000)
        {
            NumOfSeats = numOfSeats;
        }

        public double CalculateTax()
        {
            return Value * 0.002 * NumOfSeats;
        }

    }
}
