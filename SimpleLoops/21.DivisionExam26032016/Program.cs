using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.DivisionExam26032016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p2 = 0.00;
            double p3 = 0.00;
            double p4 = 0.00;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    p2++;
                }
                if (currentNumber % 3 == 0)
                {
                    p3++;
                }
                if (currentNumber % 4 == 0)
                {
                    p4++;
                }
            }
            Console.WriteLine("{0:f2}%", p2 / n * 100);
            Console.WriteLine("{0:f2}%", p3 / n * 100);
            Console.WriteLine("{0:f2}%", p4 / n * 100);
        }
    }
}
