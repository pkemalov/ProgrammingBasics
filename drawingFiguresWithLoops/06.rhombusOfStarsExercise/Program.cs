using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.rhombusOfStarsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var spaces = n - 1;

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', spaces));
                spaces -= 1;

                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            spaces = 1;
            for (int row = 1; row <= n-1; row++)
            {
                Console.Write(new string(' ', spaces));
                spaces += 1;

                for (int col = 1; col <= n-row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
