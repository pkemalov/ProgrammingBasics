using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032016_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKgVegetables = double.Parse(Console.ReadLine());
            double pricePerKgFruits = double.Parse(Console.ReadLine());
            double KgVegetables = double.Parse(Console.ReadLine());
            double KgFruits = double.Parse(Console.ReadLine());

            var result = (pricePerKgFruits * KgFruits + pricePerKgVegetables * KgVegetables) / 1.94;
            Console.WriteLine(result);
        }
    }
}
