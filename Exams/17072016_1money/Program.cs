using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17072016_1money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chineseYans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            var euro = ((bitcoins * 1168) + (chineseYans * 0.15 * 1.76)) / 1.95;
            var result = euro - commission / 100 * euro;

            Console.WriteLine(result);
        }
    }
}
