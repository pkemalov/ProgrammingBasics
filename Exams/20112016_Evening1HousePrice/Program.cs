using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Evening1HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double pricePerSM = double.Parse(Console.ReadLine());

            var bathroom = smallestRoom / 2;
            var secondRoom = smallestRoom * 1.1;
            var thirdRoom = secondRoom * 1.1;
            var totalArea = (smallestRoom + bathroom + secondRoom + thirdRoom+kitchen) * 1.05;
            var totalPrice = totalArea * pricePerSM;

            Console.WriteLine("{0:f2}", totalPrice);

        }
    }
}
