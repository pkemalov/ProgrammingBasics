using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.bonusPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (points<=100)
            {
                bonusPoints = 5;
            }
            else if (points > 100 && points<=1000)
            {
                bonusPoints = 0.20 * points;
            }
            else if (points > 1000)
            {
                bonusPoints = 0.10 * points;
            }

            if (points % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (points % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints+points);
        }
    }
}
