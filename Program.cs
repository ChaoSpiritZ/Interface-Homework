using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaxable[] myAssets = new ITaxable[6];
            myAssets[0] = new Bus(25);
            myAssets[1] = new Bus(23);
            myAssets[2] = new Bus(27);
            myAssets[3] = new House(200, 90);
            myAssets[4] = new House(300, 100);
            myAssets[5] = new House(100, 0);
            double sum = 0;

            for(int i = 0;i < myAssets.Length;i++)
            {
                Console.WriteLine("The tax is worth: {0:c}", myAssets[i].CalculateTax());
                sum += myAssets[i].CalculateTax();
            }
            Console.WriteLine();
            Console.WriteLine("Total cost is: {0:c}", sum);
        }
    }
}
