using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            height = height * 100;
            width = width * 100;
            var rows = Math.Floor(height / 120);
            var column = Math.Floor((width - 100) / 70);
            Console.WriteLine(rows * column - 3);
        }
    }
}
