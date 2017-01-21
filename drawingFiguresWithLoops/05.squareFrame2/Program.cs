using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.squareFrame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int column = 0; column < n-2; column++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");

            
            for (int s = 0; s < n-2; s++)
            {
                Console.Write("| ");
                for (int row = 0; row < n-2; row++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("| ");
            }

            Console.Write("+ ");
            for (int column = 0; column < n - 2; column++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");

        }
    }
}
