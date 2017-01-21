using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var countp1 = 0.00;
            var countp2 = 0.00;
            var countp3 = 0.00;
            var countp4 = 0.00;
            var countp5 = 0.00;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    countp1 += 1;
                }
                else if (num >= 200 && num<400)
                {
                    countp2 += 1;
                }
                else if (num >= 400 && num < 600)
                {
                    countp3 += 1;
                }
                else if (num >= 600 && num < 800)
                {
                    countp4 += 1;
                }
                else if (num >= 800)
                {
                    countp5 += 1;
                }
            }

            Console.WriteLine("{0:f2}%", countp1/n*100);
            Console.WriteLine("{0:f2}%", countp2 / n * 100);
            Console.WriteLine("{0:f2}%", countp3 / n * 100);
            Console.WriteLine("{0:f2}%", countp4 / n * 100);
            Console.WriteLine("{0:f2}%", countp5 / n * 100);
        }
    }
}
