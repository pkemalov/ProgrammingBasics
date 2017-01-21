using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.christmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows <= n; rows++)
            {
                string stars = new string('*', rows);
                string emptySpaces = new string(' ', n - rows);
                Console.Write(emptySpaces);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(stars);
                Console.WriteLine(emptySpaces);
            }
            
            
        }
    }
}
