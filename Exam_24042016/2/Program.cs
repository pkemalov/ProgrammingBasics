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
            int n = int.Parse(Console.ReadLine());

            var gameVacationDays = n * 127;
            var gameWorkingDays = (365 - n) * 63;
            var totalGame = gameVacationDays + gameWorkingDays;

            if (30000-totalGame>=0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", (30000-totalGame)/60, (30000 - totalGame) % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", (totalGame- 30000) / 60, (totalGame- 30000) % 60);
            }
        }
    }
}
