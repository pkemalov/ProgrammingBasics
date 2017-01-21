using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double placesByH = Math.Floor((h * 100 - 100)/70);
            double placesByW = Math.Floor((w * 100) / 120);

            double places = placesByH * placesByW - 3;
            Console.WriteLine(places);
        }
    }
}
