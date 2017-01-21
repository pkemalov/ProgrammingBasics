using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06032016_5fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("/{0}\\{1}/{0}\\", new string ('^', n/2), new string('_', 2*n-n/2-n/2-4));

            for (int i = 1; i <= n-3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2*n-2));
            }
            Console.WriteLine("|{0}{1}{0}|", new string(' ', n/2+1), new string('_', 2 * n - n / 2 - n / 2 - 4));
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', 2 * n - n / 2 - n / 2 - 4));
        }
    }
}
