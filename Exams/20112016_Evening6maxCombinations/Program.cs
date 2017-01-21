using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Evening6maxCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            var counter = 0;
            bool readyToBreak = false;

            for (int i = beginInterval; i <= endInterval; i++)
            {
                for (int j = beginInterval; j <= endInterval; j++)
                {
                    Console.Write("<{0}-{1}>", i, j);
                    counter = counter + 1;
                    if (counter == max)
                    {
                        readyToBreak = true;
                        break;
                    }
                        
                }
                if (readyToBreak)
                {
                    break;
                }
            }
        }
    }
}
