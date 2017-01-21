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
            string time = Console.ReadLine();

            var result = 0.00;

            if (n < 20 && time == "day")
            {
                result = 0.7 + 0.79 * n;
            }
            else if (n < 20 && time == "night")
            {
                result = 0.7 + 0.90 * n;
            }
            else if (n >= 20 && n < 100)
            {
                result = 0.09 * n;
            }
            else if (n >= 100)
            {
                result = 0.06 * n;
            }
            Console.WriteLine(result);
        }
    }
}
