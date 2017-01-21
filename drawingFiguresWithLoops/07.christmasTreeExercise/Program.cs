using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.christmasTreeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var innerSpaces = n - 1;
            var stars = 1;
            
            Console.WriteLine("{0}|", new string(' ', n+1));

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1} | {1}", new string(' ', innerSpaces), new string('*', stars));
                innerSpaces -= 1;
                stars += 1;
            }
        }
    }
}
