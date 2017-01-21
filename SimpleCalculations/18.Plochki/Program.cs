using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtWholeArea = int.Parse(Console.ReadLine());
            double widthPlochka = double.Parse(Console.ReadLine());
            double lenghtPlochka = double.Parse(Console.ReadLine());
            int lenghtPeika = int.Parse(Console.ReadLine());
            int widthPeika = int.Parse(Console.ReadLine());

            var plochkiNeeded = (lenghtWholeArea * lenghtWholeArea - (lenghtPeika * widthPeika)) / (lenghtPlochka * widthPlochka);
            var timeNeeded = plochkiNeeded * 0.2;
            Console.WriteLine(plochkiNeeded);
            Console.WriteLine(timeNeeded);
        }
    }
}
