using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();

            var sumInBGN = sum;
            if (inputCurrency == "EUR")
            {
                sumInBGN = sum* 1.95583;
            }
            else if (inputCurrency == "USD")
            {
                sumInBGN = sum * 1.79549;
            }
            else if (inputCurrency == "GBP")
            {
                sumInBGN = sum * 2.53405;
            }

            var sumInOuptputCurrency = sumInBGN;
            
            if (outputCurrency == "EUR")
            {
                sumInOuptputCurrency = sumInBGN / 1.95583;
            }
            else if (outputCurrency == "USD")
            {
                sumInOuptputCurrency = sumInBGN / 1.79549;
            }
            else if (outputCurrency == "GBP")
            {
                sumInOuptputCurrency = sumInBGN / 2.53405;
            }
            Console.WriteLine(Math.Round(sumInOuptputCurrency, 2));
        }
    }
}
