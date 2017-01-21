using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (time =="day" && km <20)
            {
                Console.WriteLine(0.70+0.79*km);
            }
            if (time == "night" && km < 20)
            {
                Console.WriteLine(0.70 + 0.90 * km);
            }
            else if (time == "day" && km >= 20 && km<100)
            {
                Console.WriteLine(0.09 * km);
            }
            else if (time == "night" && km >= 20 && km < 100)
            {
                Console.WriteLine(0.09 * km);
            }
            else if (km >= 100)
            {
                Console.WriteLine(0.06 * km);
            }
        }
    }
}
