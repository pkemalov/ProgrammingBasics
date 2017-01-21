using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06032016transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string condition = Console.ReadLine().ToLower();
            double answer = 0;

            if (n<20)
            {
                if (condition=="day")
                {
                    answer = 0.70 + n * 0.79;
                }
                else if (condition == "night")
                {
                    answer = 0.70 + n * 0.90;
                }
            }
            else if (n >= 20 && n<100)
            {
                if (condition == "day")
                {
                    answer = n * 0.09;
                }
                else if (condition == "night")
                {
                    answer = n * 0.09;
                }
            }
            else if (n >= 100)
            {
                if (condition == "day")
                {
                    answer = n * 0.06;
                }
                else if (condition == "night")
                {
                    answer = n * 0.06;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
