using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24042016_1tilesReconstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());

            var result = ((N * N) - (M * O)) / (W * L);
            var time = result * 0.2;
            Console.WriteLine(result);
            Console.WriteLine(time);
        }
    }
}
