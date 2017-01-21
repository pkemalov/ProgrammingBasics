using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.halfSumElementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            var min = -1000000;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;

                if (number > min)
                {
                    min = number;
                }
            }

            if (sum-min==min)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", min);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(min-sum+min));
            }

        }
    }
}
