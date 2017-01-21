using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.CleverLillyExam26042016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            var sumLeva = 0;
            var moneyFromPresents = 0;
            var bonus = 10;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    sumLeva += bonus;
                    sumLeva -= 1;
                    bonus += 10;
                }
                else
                {
                    moneyFromPresents = moneyFromPresents + priceToy;
                }

            }
            var allMoney = sumLeva + moneyFromPresents;
            if (priceWashingMachine <= allMoney)
            {
                Console.WriteLine("Yes! {0:F2}", allMoney - priceWashingMachine);
            }

            else
            {
                Console.WriteLine("No! {0:F2}", priceWashingMachine - allMoney);
            }
        }
    }
}
