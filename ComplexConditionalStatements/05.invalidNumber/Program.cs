﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.invalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            var inRange = (a >= 100 && a <= 200) || a == 0;

            if (!inRange)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
