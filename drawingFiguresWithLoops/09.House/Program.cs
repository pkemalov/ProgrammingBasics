using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var outerSymbol1 = (n - 2) / 2;
            var innerSymbol1 = 2;
            var outerSymbol2 = (n - 1) / 2;
            var innerSymbol2 = 1;


            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', outerSymbol1), new string('*', innerSymbol1));
                    outerSymbol1 -= 1;
                    innerSymbol1 += 2;
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', outerSymbol2), new string('*', innerSymbol2));
                    outerSymbol2 -= 1;
                    innerSymbol2 += 2;
                }
            }

            var innerSymbol = n - 2;

            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', innerSymbol));
            }
        }
    }
}
