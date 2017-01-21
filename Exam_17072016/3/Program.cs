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
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int numberOfPersons = int.Parse(Console.ReadLine());

            var result = 0.00;

            if (numberOfPersons>=1 &numberOfPersons<5 & ticketType=="Normal")
            {
                var budgetTransport = 0.75 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 249.99;
            }
            else if (numberOfPersons >= 1 & numberOfPersons < 5 & ticketType == "VIP")
            {
                var budgetTransport = 0.75 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 499.99;
            }
            else if (numberOfPersons >= 5 & numberOfPersons < 10 & ticketType == "Normal")
            {
                var budgetTransport = 0.60 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 249.99;
            }
            else if (numberOfPersons >= 5 & numberOfPersons < 10 & ticketType == "VIP")
            {
                var budgetTransport = 0.60 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 499.99;
            }
            else if (numberOfPersons >= 10 & numberOfPersons < 25 & ticketType == "Normal")
            {
                var budgetTransport = 0.50 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 249.99;
            }
            else if (numberOfPersons >= 10 & numberOfPersons < 25 & ticketType == "VIP")
            {
                var budgetTransport = 0.50 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 499.99;
            }
            else if (numberOfPersons >= 25 & numberOfPersons < 50 & ticketType == "Normal")
            {
                var budgetTransport = 0.40 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 249.99;
            }
            else if (numberOfPersons >= 25 & numberOfPersons < 50 & ticketType == "VIP")
            {
                var budgetTransport = 0.40 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 499.99;
            }
            else if (numberOfPersons >= 50 && ticketType == "Normal")
            {
                var budgetTransport = 0.25 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 249.99;
            }
            else if (numberOfPersons >= 50 & ticketType == "VIP")
            {
                var budgetTransport = 0.25 * budget;
                result = (budget - budgetTransport) - numberOfPersons * 499.99;
            }

            if (result>=0)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", result);

            }

            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(result));
            }
        }
    }
}
