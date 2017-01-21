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

            var wight = 2 * n;
            var left = n / 2;
            var innerSymbol = 2 * n - n / 2 - n / 2 - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', left), new string('_', innerSymbol));

            for (int i = 1; i < n - 2; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2*n-2));
            }

            Console.WriteLine("|{0}{1}{0}|", new string(' ', left + 1), new string('_', innerSymbol));

            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', left), new string(' ', innerSymbol));
        }
    }
}
