using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.numberInRange1to100Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = -10000; i <= n; i++)
            {
                if (n < 1 || n > 100)
                {
                    Console.WriteLine("Invalid number!");
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(n);
                    break;
                }
            }
            

            
        }
    }
}
