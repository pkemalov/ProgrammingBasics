using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.leftAndRightSumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var firstSum = 0;
            var secondSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i >= 0 && i < n)
                {
                    firstSum = firstSum + number;
                }

                else if ((i >= n && i < 2 * n))
                {
                    secondSum = secondSum + number;
                }
            }
            if (firstSum==secondSum)
            {
                Console.WriteLine("Yes, sum = {0}", firstSum);
            }

            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(firstSum-secondSum));
            }
        }
    }
}
