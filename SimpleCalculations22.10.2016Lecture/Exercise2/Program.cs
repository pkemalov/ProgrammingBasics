using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var kgTomatoesToBuy = double.Parse(Console.ReadLine());
            var pricePerKg = double.Parse(Console.ReadLine());
            var priceToPay = kgTomatoesToBuy * pricePerKg;
            Console.WriteLine(priceToPay);

        }
    }
}
