﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var sum = 0;
            do
            {
                sum = sum + num % 10;
                num = num / 10;

            } while (num>0);
            Console.WriteLine(sum);
        }
    }
}
