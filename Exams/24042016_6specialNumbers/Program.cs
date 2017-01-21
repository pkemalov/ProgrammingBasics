using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24042016_6specialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a1 = 1; a1 <= 9; a1++)
            {
                for (int b1 = 1; b1 <= 9; b1++)
                {
                    for (int c1 = 1; c1 <= 9; c1++)
                    {
                        for (int d1 = 1; d1 <= 9; d1++)
                        {
                            if (n % a1==0 && n % b1 == 0 && n % c1 == 0 && n % d1 == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", a1, b1, c1, d1);
                            }
                        }
                    }
                }
            }
        }
    }
}
