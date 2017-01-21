using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.squareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");

                for (int s = 1; s < n; s++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
    }
}
