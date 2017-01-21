using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            var numberOfToys = 0;
            var moneyPerEvenYear = 0;
            var bonus = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyPerEvenYear += bonus - 1;
                    bonus += 10;
                }
                else
                {
                    numberOfToys += 1;
                }
            }
            var moneySaved = moneyPerEvenYear + numberOfToys * priceToy;
            var result = moneySaved - priceWashingMachine;

            if (result >= 0)
            {
                Console.WriteLine("Yes! {0:f2}", result);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", Math.Abs(result));
            }
        }
    }
}
