using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28082016_1DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysPerMonth = int.Parse(Console.ReadLine());
            double grossMoneyPerDay = double.Parse(Console.ReadLine());
            double exchangeRate = double.Parse(Console.ReadLine());

            var grossMoneyPerYear = grossMoneyPerDay * workingDaysPerMonth * 12+(grossMoneyPerDay * workingDaysPerMonth)*2.5;
            var netMoneyPerYear = grossMoneyPerYear - 0.25 * grossMoneyPerYear;
            var result = netMoneyPerYear / 365*exchangeRate;

            Console.WriteLine("{0:f2}", result);

        }
    }
}
