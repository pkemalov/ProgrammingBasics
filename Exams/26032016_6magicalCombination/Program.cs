using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032016_6magicalCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            for (int s = 1; s <= 9; s++)
                            {
                                for (int p = 1; p <= 9; p++)
                                {
                                    if (i*j*k*l*s*p == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", i, j, k, l, s, p);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
