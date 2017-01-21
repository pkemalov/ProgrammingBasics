using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17072016_6StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i > s; i--)
            {
                if (i % 2 == 0 & i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            for (int i = s; i >= n; i--)
            {
                if (i % 2 == 0 & i % 3 == 0)
                {
                    if (s%2==0 && s%3==0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
        }
    }
}
