using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int loze = int.Parse(Console.ReadLine());
            double grozdePerSqM = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            var totalGrozde = loze * grozdePerSqM;
            var wineTotal = 0.4 * totalGrozde / 2.5;
            var result = wineTotal - neededWine;

            if (result >= 0)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineTotal));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(result), Math.Ceiling(result / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededWine - wineTotal));
            }
        }
    }
}
