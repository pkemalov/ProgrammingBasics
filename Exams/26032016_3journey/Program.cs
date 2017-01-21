using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032016_3journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            var expenses = 0.00;

            if (budget<=100)
            {
                if (season=="summer")
                {
                    expenses = 0.30 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", expenses);
                }
                else if (season == "winter")
                {
                    expenses = 0.70 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", expenses);
                }
            }

            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    expenses = 0.40 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", expenses);
                }
                else if (season == "winter")
                {
                    expenses = 0.80 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", expenses);
                }
            }

            else if (budget > 1000)
            {
                if (season == "summer")
                {
                    expenses = 0.90 * budget;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", expenses);
                }
                else if (season == "winter")
                {
                    expenses = 0.90 * budget;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", expenses);
                }
            }
        }
    }
}
