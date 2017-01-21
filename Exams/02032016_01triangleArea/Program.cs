﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02032016_01triangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            var a = Math.Max(x2, x3) - Math.Min(x2, x3);
            var h = Math.Abs(y2) + Math.Abs(y1);
            var area = a * h / 2.0;

            Console.WriteLine(area);

        }
    }
}
