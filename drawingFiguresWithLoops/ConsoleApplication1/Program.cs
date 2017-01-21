using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = rows;
            string plusSign = "+";
            string dashes = new string('-', rows - 2);
            string linia = "|";
            string emptySpaces = new string(' ', rows - 2);

            Console.WriteLine("{0}{1}{0}", plusSign, dashes);

            for (int i = 0; i < rows-2; i++)
            {
                Console.WriteLine("{0}{1}{0}", linia, dashes);
            }

            Console.WriteLine("{0}{1}{0}", plusSign, dashes);

        }
    }
}
