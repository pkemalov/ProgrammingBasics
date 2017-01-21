using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (char k = 'a'; k < 'a'+l; k++)
                    {
                        for (char s = 'a'; s < 'a'+ l; s++)
                        {
                            for (int t = Math.Max(i,j) + 1; t <= n; t++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, k, s, t);
                            }
                        }
                    }
                }
            }

        }
    }
}
