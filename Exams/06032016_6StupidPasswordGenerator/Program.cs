using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06032016_6StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    for (var s1 = 'a'; s1 < 'a' + l ; s1++)
                    {
                        for (var s2 = 'a'; s2 < 'a' + l; s2++)
                        {
                            for (var t = Math.Max(i, j)+1; t <= n; t++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, s1, s2, t);
                            }
                        }                    
                    } 
                }
            }
        }
    }
}
