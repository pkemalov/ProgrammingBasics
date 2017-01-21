using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            var expenses = 0.0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    expenses = 0.3 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2}", expenses);
                }
                else if (season == "winter")
                {
                    expenses = 0.7 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2}", expenses);
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    expenses = 0.4 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:F2}", expenses);
                }
                else if (season == "winter")
                {
                    expenses = 0.8 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:F2}", expenses);
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer")
                {
                    expenses = 0.9 * budget;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", expenses);
                }
                else if (season == "winter")
                {
                    expenses = 0.9 * budget;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", expenses);
                }
            }

        }
    }
}

