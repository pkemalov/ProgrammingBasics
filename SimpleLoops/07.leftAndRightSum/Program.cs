﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.leftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int leftSum = int.Parse(Console.ReadLine());
                sum1 += leftSum;
            }
            for (int i = 0; i < n; i++)
            {
                int rightSum = int.Parse(Console.ReadLine());
                sum2 += rightSum;
            }
            if (sum1==sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }   
        }
    }
}
