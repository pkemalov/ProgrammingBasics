using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17072016_5diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wight = 5 * n;
            var outerDots = n - 1;
            var innerDots = 3 * n;

            Console.WriteLine("{0}{1}{0}", new string('.', outerDots + 1), new string('*', innerDots));

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
                outerDots -= 1;
                innerDots += 2;
            }
            Console.WriteLine("{0}", new string('*', wight));

            outerDots += 1;
            innerDots -= 2;
            var rows = 2 * n + 1;


            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
                outerDots += 1;
                innerDots -= 2;
            }
            outerDots = 2*n+1;
            innerDots = 5*n-4*n-2;

            Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('*', innerDots));
        }
    }
}
