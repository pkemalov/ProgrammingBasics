using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HarvestExam17072016
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int numberWorkers = int.Parse(Console.ReadLine());

            if (X * 0.4 * Y / 2.5 < Z) 
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(Z - (X * 0.4 * Y / 2.5)));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(X * 0.4 * Y / 2.5));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(X * 0.4 * Y / 2.5 - Z), Math.Ceiling(((X * 0.4 * Y / 2.5) - Z) / numberWorkers));
                         
            }
                
        }
    }
}
