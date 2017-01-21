using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Evening5rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var outerDots = ((3 * n) - 2) / 2;
            var innerSpaces = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', outerDots), new string(' ', innerSpaces));
                innerSpaces += 2;
                outerDots--;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n/2), new string('*', 3*n-n / 2-n/2));   

            for (int i = 1; i <= 2*n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n/2), new string('\\', 3*n-n/2-n/2-2));
            }

            outerDots = n / 2;
            innerSpaces = 2 * n - 2;
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', outerDots), new string('*', innerSpaces));
                outerDots = outerDots - 1;
                innerSpaces = innerSpaces + 2;
            }
            
        }
    }
}
