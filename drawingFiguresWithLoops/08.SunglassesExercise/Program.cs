﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SunglassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wight = 5 * n;
            var leftHalf = 2 * n;
            var innerSymbols = 2 * n - 2;


            Console.WriteLine("{0}{1}{0}", new string('*', leftHalf), new string(' ', n));

            for (int i = 1; i <= n-2; i++)
            {
                if (i==(n-1)/2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', innerSymbols), new string('|', n));
                }

                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', innerSymbols), new string(' ', n));
                }

            }

            Console.WriteLine("{0}{1}{0}", new string('*', leftHalf), new string(' ', n));
        }
    }
}
