using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_28082016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var thirdDigit = n % 10;
            var secondDigit = n / 10 % 10;
            var firstDigit = n / 100;
            var rows = firstDigit + secondDigit;
            var col = firstDigit + thirdDigit;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - firstDigit;
                        Console.Write("{0} ", n);
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - secondDigit;
                        Console.Write("{0} ", n);
                    }
                    else if (n % 5 != 0 && n % 3 != 0)
                    {
                        n = n + thirdDigit;
                        Console.Write("{0} ", n);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
