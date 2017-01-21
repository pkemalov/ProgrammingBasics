using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.DailyIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysInMonth = int.Parse(Console.ReadLine());
            double dollarsPerDay = double.Parse(Console.ReadLine());
            double currencyRate = double.Parse(Console.ReadLine());

            var monthlyPay = workingDaysInMonth * dollarsPerDay;
            var yearlyPay = monthlyPay * 12 + monthlyPay * 2.5;
            var taxes = 0.25 * yearlyPay;
            var final = Math.Round(((yearlyPay - taxes) / 365*currencyRate), 2);
            Console.WriteLine(final);
        }
    }
}
