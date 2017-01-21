using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence1K_1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 1; i <= n; i++)
            {
                if (num<=n)
                {
                    Console.WriteLine(num);
                    num = 2 * num + 1;
                }

                else
                {
                    break;
                }
                
            }
        }
    }
}
