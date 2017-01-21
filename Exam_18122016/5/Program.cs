using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wight = 4 * n + 1;
            var outerSymbol = 2*n-1;

            Console.WriteLine("{0}/|\\{0}", new string('.', outerSymbol));
            Console.WriteLine("{0}\\|/{0}", new string('.', outerSymbol));
            Console.WriteLine("{0}***{0}", new string('.', outerSymbol));

            outerSymbol = 2 * n - 2;
            var innerSymbol = 1;

            for (int i = 1; i < 2*n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerSymbol), new string('-', innerSymbol));

                outerSymbol -= 1;
                innerSymbol += 1;
            }
            outerSymbol = 4 * n + 1;
            innerSymbol = 4 * n + 1;

            Console.WriteLine("{0}", new string('*', outerSymbol));

            Console.Write("*");
            for (int i = 1; i <= 2*n; i++)
            {
                Console.Write(".");
                Console.Write("*");
            }
            Console.WriteLine();

            Console.WriteLine("{0}", new string('*', outerSymbol));

        }
    }
}
