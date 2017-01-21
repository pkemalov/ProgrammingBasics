using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_18122016
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialSpeed = int.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            var firstTimeHours = firstTime / 60;
            var secondTimeHours = secondTime / 60;
            var thirdTimeHours = thirdTime / 60;

            var result = initialSpeed * firstTimeHours + 1.1 * initialSpeed * secondTimeHours + 1.1 * 0.95 * initialSpeed * thirdTimeHours;

            Console.WriteLine("{0:f2}", result);
        }
    }
}
