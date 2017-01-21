using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28082016_5Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSymbols = 3 * n;
            int innerSymbols = 0;
            int rightSymbols = 5 * n - 3 * n - 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftSymbols), new string('-', innerSymbols), new string('-', rightSymbols));
                innerSymbols += 1;
                rightSymbols -= 1;
            }

            leftSymbols = 3 * n;
            innerSymbols = n - 1;
            rightSymbols = n - 1;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftSymbols), new string('-', innerSymbols), new string('-', rightSymbols));
            }

            leftSymbols = 3 * n;
            innerSymbols = n - 1;
            rightSymbols = n - 1;

            for (int i = 1; i <= n / 2 - 1; i++)
            {
                if (n >= 4)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftSymbols), new string('-', innerSymbols), new string('-', rightSymbols));
                    leftSymbols -= 1;
                    innerSymbols += 2;
                    rightSymbols -= 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftSymbols), new string('*', innerSymbols), new string('-', rightSymbols));

        }
    }
}
