using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var min = -1000000000;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;

                if (min <= num)
                {
                    min = num;

                }
                                
            }
            if (min == sum - min)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {min}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(min - sum + min)}");
            }

        }
    }
}
