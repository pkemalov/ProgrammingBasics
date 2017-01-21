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

            var wight = 5 * n;
            var outerSymbol = n - 1;
            var innerSymbol = 3 * n;

            Console.WriteLine("{0}{1}{0}", new string('.', outerSymbol + 1), new string('*', innerSymbol));

            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerSymbol), new string('.', innerSymbol));
                outerSymbol -= 1;
                innerSymbol += 2;
            }

            Console.WriteLine("{0}", new string('*', wight));

            outerSymbol += 1;
            innerSymbol -= 2;

            for (int i = 1; i <= 2*n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerSymbol), new string('.', innerSymbol));
                outerSymbol += 1;
                innerSymbol -= 2;
            }

            outerSymbol = 2 * n + 1;
            innerSymbol = 5 * n - 4 * n - 2;

            Console.WriteLine("{0}{1}{0}", new string('.', outerSymbol), new string('*', innerSymbol));
        }
    }
}
