using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = n - 1;
            int stars = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}", new string(' ', dots), new string('*', stars));
                dots--;
                stars += 1;
            }
        }
    }
}
