﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.FibonacciExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var f0 = 1;
            var f1 = 1;
            var sum = 0;

            if (n < 2)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    sum = f0 + f1;
                    f0 = sum + f1;
                    f1 = f0+sum;
                }

            }
            Console.WriteLine(f1);
        }
    }
}
