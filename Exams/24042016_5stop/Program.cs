using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24042016_5stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var outerDots = n;
            var innerDashes = 2 * n -1;

            Console.WriteLine("{0}{1}{0}", new string('.', n+1), new string('_', 2*n+1));
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', outerDots), new string('_', innerDashes));
                outerDots--;
                innerDashes += 2;

            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (4 * n - 6)/2));
            Console.WriteLine("\\\\{0}//", new string('_', 4*n-1));

            outerDots = 1;
            innerDashes = 4 * n - 3;
            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', outerDots), new string('_', innerDashes));
                outerDots += 1;
                innerDashes -= 2;
            }



        }
    }
}
