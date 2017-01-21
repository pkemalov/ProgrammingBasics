using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.enterEvenNumberExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            for (int i = -10000; i <= n; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine("The number is not even.");
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
        }
    }
}
