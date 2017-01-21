using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17072016._03.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleNumber = int.Parse(Console.ReadLine());
            
            if (category == "VIP")
            {
                if (peopleNumber >=1 && peopleNumber<=4)
                {
                    if (budget-budget*0.75-499.99* peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.75 - 499.99 * peopleNumber);
                    }
                    else 
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.75 + 499.99 * peopleNumber - budget);
                    }
                }
                else if (peopleNumber >= 5 && peopleNumber <= 9)
                {
                    if (budget - budget * 0.60 - 499.99 * peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.60 - 499.99 * peopleNumber);
                    }
                    else 
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.60 + 499.99 * peopleNumber - budget);
                    }
                }
                else if (peopleNumber >= 10 && peopleNumber <= 24)
                {
                    if (budget - budget * 0.50 - 499.99 * peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.50 - 499.99 * peopleNumber);
                    }
                    else 
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.50 + 499.99 * peopleNumber - budget);
                    }
                }
                else if (peopleNumber >= 25 && peopleNumber <= 49)
                {
                    if (budget - budget * 0.40 - 499.99 * peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.40 - 499.99 * peopleNumber);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.40 + 499.99 * peopleNumber - budget);
                    }
                }
                else if (peopleNumber >= 50)
                {
                    if (budget - budget * 0.25 - 499.99 * peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.25 - 499.99 * peopleNumber);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.25 + 499.99 * peopleNumber - budget);
                    }
                }
            }
            else if (category == "Normal")
            {
                if (peopleNumber >= 1 && peopleNumber <= 4)
                {
                    if (budget - budget * 0.75 - 249.99 * peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.75 - 249.99 * peopleNumber);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.75 + 499.99 * peopleNumber - budget);
                    }
                }
                else if (peopleNumber >= 5 && peopleNumber <= 9)
                {
                    if (budget - budget * 0.60 - 249.99 * peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.60 - 249.99 * peopleNumber);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.60 + 499.99 * peopleNumber - budget);
                    }
                }
                else if (peopleNumber >= 10 && peopleNumber <= 24)
                {
                    if (budget - budget * 0.50 - 249.99 * peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.50 - 249.99 * peopleNumber);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.50 + 499.99 * peopleNumber - budget);
                    }
                }
                else if (peopleNumber >= 25 && peopleNumber <= 49)
                {
                    if (budget - budget * 0.40 - 249.99 * peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.40 - 249.99 * peopleNumber);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.40 + 499.99 * peopleNumber - budget);
                    }
                }
                else if (peopleNumber >= 50)
                {
                    if (budget - budget * 0.25 - 249.99 * peopleNumber >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:F2} leva left.", budget - budget * 0.25 - 249.99 * peopleNumber);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", budget * 0.25 + 249.99 * peopleNumber - budget);
                    }
                }
            }
        }
    }
}
