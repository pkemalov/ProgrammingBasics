using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam06032016
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double wight = double.Parse(Console.ReadLine());

            var numberOfDeskPerRow = Math.Truncate((wight * 100 - 100) / 70);
            var numberOfRows = Math.Truncate(height * 100 / 120);
            var result = numberOfDeskPerRow * numberOfRows - 3;

            Console.WriteLine(result);

        }
    }
}
