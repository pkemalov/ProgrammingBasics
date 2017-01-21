using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ProblemFirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write your first number: ");
            var a = decimal.Parse(Console.ReadLine());
            Console.Write("Please write your second number: ");
            var b = decimal.Parse(Console.ReadLine());
            var area = a * b;
            Console.Write("Your area is: ");
            Console.WriteLine(area);
        }
    }
}
