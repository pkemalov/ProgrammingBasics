using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Evening3bikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorBikers = int.Parse(Console.ReadLine());
            int seniorBikers = int.Parse(Console.ReadLine());
            string race = Console.ReadLine().ToLower();
            var totalSum = 0.00;

            if (race == "trail")
            {
                totalSum = 0.95 * (juniorBikers * 5.50 + seniorBikers * 7);
            }
            else if (race == "cross-country" && juniorBikers+seniorBikers<50)
            {
                totalSum = 0.95 * (juniorBikers * 8 + seniorBikers * 9.50);
            }
            else if (race == "cross-country" && juniorBikers + seniorBikers >= 50)
            {
                totalSum = 0.95 * (juniorBikers * 8 + seniorBikers * 9.50)*0.75;
            }
            else if (race == "downhill")
            {
                totalSum = 0.95 * (juniorBikers * 12.25 + seniorBikers * 13.75);
            }
            else if (race == "road")
            {
                totalSum = 0.95 * (juniorBikers * 20 + seniorBikers * 21.50);
            }
            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
