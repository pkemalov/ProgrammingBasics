using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyReceived = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            var expensesPerYear = 0;


            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    expensesPerYear = expensesPerYear + 12000;
                }
                else
                {
                    expensesPerYear = expensesPerYear + 12000 + 50 * (18 + i - 1800);
                }
            }

            var result = moneyReceived - expensesPerYear;

            if (result >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", result);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(result));
            }
        }
    }
}
