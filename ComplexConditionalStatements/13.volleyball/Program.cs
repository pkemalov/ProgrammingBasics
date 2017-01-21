using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double days = 0;

            if (typeYear =="normal")
            {
                days = ((48- h) * 3.0 / 4) + h + (p * 2.0 / 3);
            }
            else if (typeYear == "leap")
            {
                days = (((48- h) * 3.0 / 4) + h + (p * 2.0 / 3))*1.15;
            }
            Console.WriteLine(Math.Truncate(days));
        }
    }
}
