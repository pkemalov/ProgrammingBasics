using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.pointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (y > 0 && y < h && x > 0 && x < 3 * h)
            {
                Console.WriteLine("inside");
            }
            else if (y >= h && y < 4 * h && x > h && x < 2 * h)
            {
                Console.WriteLine("inside");
            }
            else if (y > h && y < 4 * h && x >= 0 && x < h)
            {
                Console.WriteLine("outside");
            }
            else if (y > h && y < 4 * h && x > 2 * h && x < 3 * h)
            {
                Console.WriteLine("outside");
            }
            else if (y > 4 * h)
            {
                Console.WriteLine("outside");
            }
            else if (x < 0 || x > 3 * h)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
