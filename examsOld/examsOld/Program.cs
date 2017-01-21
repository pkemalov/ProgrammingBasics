using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examsOld
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal rate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
            decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
            decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

            var totalExpenses = (pizzaPrice * pizzaQuantity + lasagnaPrice * lasagnaQuantity + sandwichPrice*sandwichQuantity) / rate;
            var result = money - totalExpenses;

            if (result>=0)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", result);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", Math.Abs(result));
            }

        }
    }
}
