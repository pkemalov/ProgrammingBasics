using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032016_5butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n - 1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }

                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
            }
            Console.WriteLine("{0} @ {0}", new string(' ', n-2));

            for (int i = 1; i < n - 1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                }

                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }
            }

        }
    }
}
