﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double wight = Math.Max(x1, x2) - Math.Min(x1, x2);
            double height = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine(wight*height);
            Console.WriteLine((wight + height)*2);
        }
    }
}
