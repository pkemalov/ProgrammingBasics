using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam20112016Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = from; i <= to; i++)
            {
                for (int j = from; j <= to; j++)
                {
                    count += 1;
                    Console.Write("<{0}-{1}>", i, j);
                    if (max==count)
                    {
                        break;
                    }

                    
                }
                if (max == count)
                {
                    break;
                }
            }
        }
    }
}
