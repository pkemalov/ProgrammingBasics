using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double juan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            var sumInEUR = bitcoin * 1168 / 1.95 + juan * 0.15 * 1.76 / 1.95;
            var sumCommission = sumInEUR * commission/100;
            var sumInEURFinal = sumInEUR - sumCommission;
            Console.WriteLine(sumInEURFinal);
        }
    }
}
