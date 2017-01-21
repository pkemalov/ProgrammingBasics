using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24042016_3operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            if (operation == '+' && (N1 + N2) % 2 == 0)
            {
                Console.WriteLine("{0} + {1} = {2} - even", N1, N2, N1 + N2);
            }
            else if (operation == '+' && (N1 + N2) % 2 != 0)
            {
                Console.WriteLine("{0} + {1} = {2} - odd", N1, N2, N1 + N2);
            }
            else if (operation == '-' && (N1 - N2) % 2 == 0)
            {
                Console.WriteLine("{0} - {1} = {2} - even", N1, N2, N1 - N2);
            }
            else if (operation == '-' && (N1 - N2) % 2 != 0)
            {
                Console.WriteLine("{0} - {1} = {2} - odd", N1, N2, N1 - N2);
            }
            else if (operation == '*' && (N1 * N2) % 2 == 0)
            {
                Console.WriteLine("{0} * {1} = {2} - even", N1, N2, N1 * N2);
            }
            else if (operation == '*' && (N1 * N2) % 2 != 0)
            {
                Console.WriteLine("{0} * {1} = {2} - odd", N1, N2, N1 * N2);
            }

            else if (operation == '/')
            {
                if (N2 != 0)
                {
                    Console.WriteLine("{0} / {1} = {2:f2}", N1, N2, N1 / N2);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
            }

            else if (operation == '%')
            {
                if (N2 != 0)
                {
                    Console.WriteLine("{0} % {1} = {2}", N1, N2, N1 % N2);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
            }


        }
    }
}
