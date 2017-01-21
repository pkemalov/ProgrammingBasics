using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.oddEvenPositionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = 10000000;
            double OddMax = -1000000;
            double EvenSum = 0;
            double EvenMin = 10000000;
            double EvenMax = -1000000;


            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum = EvenSum + number;
                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }

                    if (number > EvenMax)
                    {
                        EvenMax = number;
                    }
                }

                else if (i % 2 != 0)
                {
                    OddSum = OddSum + number;
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }

                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                }

            }
            if (n == 0)
            {
                Console.WriteLine("OddSum={0},", OddSum);
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum={0},", EvenSum);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n != 0 && n != 1)
            {
                Console.WriteLine("OddSum={0},", OddSum);
                Console.WriteLine("OddMin={0},", OddMin);
                Console.WriteLine("OddMax={0},", OddMax);
                Console.WriteLine("EvenSum={0},", EvenSum);
                Console.WriteLine("EvenMin={0},", EvenMin);
                Console.WriteLine("EvenMax={0},", EvenMax);
            }

            else if (n == 1)
            {
                Console.WriteLine("OddSum={0},", OddSum);
                Console.WriteLine("OddMin={0},", OddMin);
                Console.WriteLine("OddMax={0},", OddMax);
                Console.WriteLine("EvenSum={0},", EvenSum);
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }


        }
    }
}
