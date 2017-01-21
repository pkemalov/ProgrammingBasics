using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Evening4logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLoads = int.Parse(Console.ReadLine());
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;
            var average = 0.00;

            for (int i = 0; i < numberLoads; i++)
            {
                int loadTons = int.Parse(Console.ReadLine());

                if (loadTons <= 3)
                {
                    p1 = p1 + loadTons;
                }
                else if (loadTons >= 4 && loadTons <= 11)
                {
                    p2 = p2 + loadTons;
                }
                else if (loadTons >= 12)
                {
                    p3 = p3 + loadTons;
                }
                average = (p1 * 200 + p2 * 175 + p3 * 120) / (p1 + p2 + p3);
            }
            Console.WriteLine("{0:f2}", average);
            Console.WriteLine("{0:f2}%", p1 * 100 / (p1 + p2 + p3));
            Console.WriteLine("{0:f2}%", p2 * 100 / (p1 + p2 + p3));
            Console.WriteLine("{0:f2}%", p3 * 100 / (p1 + p2 + p3));
        }
    }
}
