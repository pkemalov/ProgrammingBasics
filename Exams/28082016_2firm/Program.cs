using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28082016_2firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysForTheFirm = int.Parse(Console.ReadLine());
            int numberOfWorkersOvertime = int.Parse(Console.ReadLine());

            var firmCalculation = Math.Floor(daysForTheFirm * 8 -0.1*daysForTheFirm*8+numberOfWorkersOvertime*daysForTheFirm*2);

            if (hoursNeeded<=firmCalculation)
            {
                Console.WriteLine("Yes!{0} hours left.", firmCalculation-hoursNeeded);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNeeded - firmCalculation);
            } 
        }
    }
}
