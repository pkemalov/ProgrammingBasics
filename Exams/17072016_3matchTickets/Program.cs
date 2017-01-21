using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17072016_3matchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int groupNumber = int.Parse(Console.ReadLine());
            var transportCost = 0.00;

            if (groupNumber >=1 && groupNumber<=4)
            {
                transportCost = 0.75 * budget;
            }

            else if (groupNumber >= 5 && groupNumber <= 9)
            {
                transportCost = 0.60 * budget;
            }

            else if (groupNumber >= 10 && groupNumber <= 24)
            {
                transportCost = 0.50 * budget;
            }

            else if (groupNumber >= 25 && groupNumber <= 49)
            {
                transportCost = 0.40 * budget;
            }

            else if (groupNumber >= 50 )
            {
                transportCost = 0.25 * budget;
            }

            if (ticketType== "VIP" && budget-(transportCost+groupNumber*499.99)>=0)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - (transportCost + groupNumber * 499.99));
            }

            else if (ticketType == "VIP" && budget - (transportCost + groupNumber * 499.99) < 0)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", (transportCost + groupNumber * 499.99) - budget);
            }

            else if (ticketType == "Normal" && budget - (transportCost + groupNumber * 249.99) >= 0)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - (transportCost + groupNumber * 249.99));
            }

            else if (ticketType == "Normal" && budget - (transportCost + groupNumber * 249.99) < 0)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", (transportCost + groupNumber * 249.99) - budget);
            }
        }
    }
}
