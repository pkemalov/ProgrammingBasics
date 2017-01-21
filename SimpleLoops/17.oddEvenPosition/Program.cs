using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.oddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double EvenSum = 0;
            double EvenMin = -100000000.0;
            double EvenMax = 100000000.0;
            double OddMin = -10000000.0;
            double OddMax = 10000000.0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    OddSum = OddSum + num;

                    if (OddMin < num)
                    {
                        OddMin = num;
                    }

                    if (OddMax > num)
                    {
                        OddMax = num;
                    }

                }

                else
                {
                    EvenSum = EvenSum + num;

                    if (EvenMin < num)
                    {
                        EvenMin = num;
                    }

                    if (EvenMax > num)
                    {
                        EvenMax = num;
                    }

                }
            }
            Console.WriteLine($"OddSum= {OddSum},");

            if (OddMax == 10000000.0)
            {
                Console.WriteLine("OddMin= No,");
            }
            else
            {
                Console.WriteLine($"OddMin= {OddMax},");
            }
            if (OddMin == -10000000.0)
            {
                Console.WriteLine("OddMax= No,");
            }
            else
            {
                Console.WriteLine($"OddMax= {OddMin},");
            }
            Console.WriteLine($"EvenSum= {EvenSum},");

            if (EvenMax == 100000000.0)
            {
                Console.WriteLine("EvenMin= No,");
            }
            else
            {
                Console.WriteLine($"EvenMin= {EvenMax},");
            }
            if (EvenMin == -100000000.0)
            {
                Console.WriteLine("EvenMax= No");
            }
            else
            {
                Console.WriteLine($"EvenMax= {EvenMin}");
            }
            
        }
    }
}
