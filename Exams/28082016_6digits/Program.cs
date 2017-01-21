using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28082016_6digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var thirdDigit = n % 10;
            var secondDigit = n / 10 % 10;
            var firstDigit = n / 100;

            for (int i = 1; i <= firstDigit + secondDigit; i++)
            {
                for (int j = 1; j <= firstDigit + thirdDigit; j++)
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
                    else
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
