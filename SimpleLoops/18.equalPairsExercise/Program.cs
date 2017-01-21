using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.equalPairsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var sum4 = 0;
            var diff1 = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i <= 2)
                {
                    sum1 = sum1 + number;
                }
                else if (i <= 4 && i > 2)
                {
                    sum2 = sum2 + number;

                    if (Math.Abs(sum2 - sum1) > diff1)
                    {
                        diff1 = Math.Abs(sum2 - sum1);
                    }

                }
                else if (i <= 6 && i > 4)
                {
                    sum3 = sum3 + number;

                    if (Math.Abs(sum3 - sum2) > diff1)
                    {
                        diff1 = Math.Abs(sum3 - sum2);
                    }
                }
                else if (i <= 8 && i > 6)
                {
                    sum4 = sum4 + number;

                    if (Math.Abs(sum4 - sum3) > diff1)
                    {
                        diff1 = Math.Abs(sum4 - sum3);
                    }
                }
            }

            if (diff1==0)
            {
                Console.WriteLine("Yes, value={0}", sum1);
            }

            else
            {
                Console.WriteLine("No, maxdiff={0}", diff1);
            }
        }
    }
}
