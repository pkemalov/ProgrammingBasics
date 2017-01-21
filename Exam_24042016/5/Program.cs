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

            var wight = 4 * n + 3;
            var outerSymbols = n + 1;
            var innerSymbols = 2 * n + 1;

            Console.WriteLine("{0}{1}{0}", new string('.', outerSymbols), new string('_', innerSymbols));
            outerSymbols -= 1;
            innerSymbols -= 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', outerSymbols), new string('_', innerSymbols));
                outerSymbols -= 1;
                innerSymbols += 2;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', 2*n-3));
            Console.WriteLine("\\\\{0}//", new string('_', 4 * n - 1));

            outerSymbols += 1;
            innerSymbols -= 2;
            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', outerSymbols), new string('_', innerSymbols));
                outerSymbols += 1;
                innerSymbols -= 2;
            }
        }
    }
}
