using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.oddEvenSumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i%2==0)
                {
                    sum2 = sum2 + number;
                }

                else
                {
                    sum1 = sum1 + number;
                }
            }

            if (sum1==sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum1);
            }

            else 
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sum1-sum2));
            }
        }
    }
}
