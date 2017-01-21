using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Morning1Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            int midiKG = int.Parse(Console.ReadLine());

            var palamudPrice = skumriaPrice * 1.6;
            var safridPrice = cacaPrice * 1.8;
            var midiPrice = 7.50;

            var total = palamudKG * palamudPrice + safridKG * safridPrice + midiKG * midiPrice;

            Console.WriteLine("{0:f2}", total);
        }
    }
}
