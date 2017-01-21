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
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());

            for (char i = first; i <= last; i++)
            {
                Console.Write("{i}", i);

            }
        }
    }
}
