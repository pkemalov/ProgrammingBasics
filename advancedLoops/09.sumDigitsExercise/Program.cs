using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.sumDigitsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= 9; i++)
            {
                sum = sum + num % 10;
                num = num / 10;
                if (num < 0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
