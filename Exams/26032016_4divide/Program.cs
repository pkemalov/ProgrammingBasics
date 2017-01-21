using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032016_4divide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number%2==0)
                {
                    p1=p1+1;
                }
                if (number % 3 == 0)
                {
                    p2 = p2+1;
                }
                if (number % 4 == 0)
                {
                    p3 = p3+1;
                }
            }
            Console.WriteLine("{0:f2}%", p1/n*100);
            Console.WriteLine("{0:f2}%", p2 / n * 100);
            Console.WriteLine("{0:f2}%", p3 / n * 100);
        }
    }
}
