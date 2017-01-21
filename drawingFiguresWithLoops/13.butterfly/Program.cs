using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("*");

            }
            Console.Write("\\ /");
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("@");
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("*");
            }
            Console.Write("/ \\");
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
