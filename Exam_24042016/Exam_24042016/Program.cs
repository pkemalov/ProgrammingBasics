using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_24042016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());

            var areaToBeCovered = n * n - m * o;
            var plochkiNeeded = areaToBeCovered / (w * l);
            var timeNeeded = plochkiNeeded * 0.2;

            Console.WriteLine(plochkiNeeded);
            Console.WriteLine(timeNeeded);
        }
    }
}
