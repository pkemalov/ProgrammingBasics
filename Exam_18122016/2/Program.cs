using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double wightPod = double.Parse(Console.ReadLine());
            double lenghtPod = double.Parse(Console.ReadLine());
            double aTriangle = double.Parse(Console.ReadLine());
            double hTriagle = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double moneyMaster = double.Parse(Console.ReadLine());

            var areaPod = wightPod * lenghtPod;
            var areaTile = aTriangle * hTriagle / 2;
            var tilesNeeded = Math.Ceiling(areaPod / areaTile) + 5;
            var totalSum = tilesNeeded * pricePerTile + moneyMaster;
            var result = money - totalSum;

            if (result>=0)
            {
                Console.WriteLine("{0:f2} lv left.", result);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", Math.Abs(result));
            }

        }
    }
}
