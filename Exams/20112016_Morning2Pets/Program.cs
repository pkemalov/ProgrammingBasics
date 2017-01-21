using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Morning2Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodDogPerDayKG = double.Parse(Console.ReadLine());
            double foodCatPerDayKG = double.Parse(Console.ReadLine());
            double foodTurtlePerDayGR = double.Parse(Console.ReadLine());

            var foodTurtlePerDayKG = foodTurtlePerDayGR / 1000;
            var neededFoodKG = days * (foodDogPerDayKG + foodCatPerDayKG + foodTurtlePerDayKG);

            if (food >= neededFoodKG)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - neededFoodKG));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(neededFoodKG - food));
            }
        }
    }
}
