using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Morning5Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wight = 2 * n + 3;
            var innerSymbols = 2 * n - 1;
            var outerSymbols = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', outerSymbols), new string('-', innerSymbols));
                outerSymbols += 1;
                innerSymbols -= 2;
            }

            wight = 2 * n + 3;
            innerSymbols = n;
            outerSymbols = (n+3-4)/2;

            for (int i = 1; i <= n/3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', outerSymbols), new string('*', innerSymbols));
                outerSymbols += 1;
                innerSymbols -= 2;
            }
            
            wight = 2 * n + 3;
            innerSymbols = 2 * n - 1;
            outerSymbols = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', outerSymbols), new string('*', innerSymbols));
                outerSymbols += 1;
                innerSymbols -= 2;
            }
        }
    }
}
