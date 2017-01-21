using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double revenue = 0;

            if (type == "Premiere")
            {
                revenue = r * c * 12;
            }
            else if (type == "Normal")
            {
                revenue = r * c * 7.50;
            }
            if (type == "Discount")
            {
                revenue = r * c * 5;
            }
            Console.WriteLine("{0:F2} leva", revenue);
        }
    }
}
