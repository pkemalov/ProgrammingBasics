using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Celcius
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var far = celsius * 9 / 5 + 32;
            Console.WriteLine(Math.Round(far, 2));
        }
    }
}
