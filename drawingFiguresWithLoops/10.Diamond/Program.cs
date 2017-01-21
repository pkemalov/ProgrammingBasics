using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wight = n;
            var outerSymbol = (n - 1) / 2;
            var mid = n - 2 * outerSymbol - 2;

            if (n%2==0 && mid>0)
            {
                for (int i = 1; i <= n-1; i++)
                {
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
