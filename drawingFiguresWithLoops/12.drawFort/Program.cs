using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.drawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("/");
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("^");
            }
            Console.Write("\\");
            Console.Write(new string('_', 2 * n - 4 - n / 2 - n / 2));

            Console.Write("/");
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("^");
            }
            Console.WriteLine("\\");

            for (int i = 0; i < n - 3; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("|");
            }

            Console.Write("|");
            for (int i = 0; i < n / 2+1; i++)
            {
                Console.Write(" ");
            }
            Console.Write(new string('_', 2 * n - 4 - n / 2 - n / 2));
            for (int i = 0; i < n / 2+1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");


            Console.Write("\\");
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("_");
            }
            Console.Write("/");
            if (2 * n - 4 - n / 2 - n / 2 > 0)
            {
                Console.Write(new string(' ', 2 * n - 4 - n / 2 - n / 2));
            }
            else
            {

            }

            Console.Write("\\");
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("_");
            }
            Console.Write("/");

        }
    }
}
