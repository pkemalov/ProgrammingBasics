using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17072016_4backToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double receivedMoney = double.Parse(Console.ReadLine());
            int wantedYear = int.Parse(Console.ReadLine());
            var expenses = 0;

            for (int i = 1800; i <= wantedYear; i++)
            {
                if (i%2==0)
                {
                    expenses = expenses + 12000;
                }
                else
                {
                    expenses = expenses + 12000 + (50 * (i - 1800 + 18));
                }
            }

            if (receivedMoney-expenses>=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", receivedMoney-expenses);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", expenses-receivedMoney);
            }

        }
    }
}
