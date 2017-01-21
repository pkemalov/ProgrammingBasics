using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17072016_2harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int numberWorkers = int.Parse(Console.ReadLine());

            var totalGrozde = x * y;
            var totalWine = 0.40 * totalGrozde/2.5;

            if (totalWine >= z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(totalWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(totalWine - z), Math.Ceiling((totalWine- z)/numberWorkers));
            }

            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(z-totalWine));
            }
        }
    }
}
