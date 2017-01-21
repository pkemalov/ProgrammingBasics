using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24042016_2sleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int publicHolidays = int.Parse(Console.ReadLine());

            int minutesPublicHolidays = publicHolidays * 127;
            int minutesWorkingDays = (365 - publicHolidays) * 63;
            int result = 30000 - (minutesPublicHolidays + minutesWorkingDays);

            if (result >= 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", result / 60, result % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(result) / 60, Math.Abs(result) % 60);
            }

        }
    }
}
