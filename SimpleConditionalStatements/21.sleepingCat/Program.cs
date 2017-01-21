using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.sleepingCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            var minutesGame = (365 - holidays) * 63 + holidays * 127;

            if (minutesGame > 30000)
            {
                Console.WriteLine("Tom will run away");
                var differenceHours = (minutesGame - 30000) / 60;
                var differenceMinutes = (minutesGame - 30000) % 60;
                Console.WriteLine($"{differenceHours} hours and {differenceMinutes} minutes more for play");
            } 
            else
            {
                Console.WriteLine("Tom sleeps well");
                var differenceHours = (30000 - minutesGame) / 60;
                var differenceMinutes = (30000 - minutesGame) % 60;
                Console.WriteLine($"{differenceHours} hours and {differenceMinutes} minutes less for play");
            }
        }
    }
}
