using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "+" && (n1 + n2) % 2 == 0)
            {
                Console.WriteLine("{0} + {1} = {2} - even", n1, n2, n1 + n2);
            }
            else if (operation == "+" && (n1 + n2) % 2 != 0)
            {
                Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, n1 + n2);
            }
            else if (operation == "-" && (n1 - n2) % 2 == 0)
            {
                Console.WriteLine("{0} - {1} = {2} - even", n1, n2, n1 - n2);
            }
            else if (operation == "-" && (n1 - n2) % 2 != 0)
            {
                Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, n1 - n2);
            }
            else if (operation == "*" && (n1 * n2) % 2 == 0)
            {
                Console.WriteLine("{0} * {1} = {2} - even", n1, n2, n1 * n2);
            }
            else if (operation == "*" && (n1 * n2) % 2 != 0)
            {
                Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, n1 * n2);
            }
            else if (operation == "/" && n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else if (operation == "/" && n2 != 0)
            {
                Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, n1/n2);
            }
            else if (operation == "%" && n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else if (operation == "%" && n2 != 0)
            {
                Console.WriteLine("{0} % {1} = {2}", n1, n2, n1 % n2);
            }
        }
    }
}
