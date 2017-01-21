using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_17072016
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double juans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            var euro = (bitcoins*1168 + juans * 0.15 * 1.76) / 1.95;
            var final = (100 - commission)/100 * euro;

            Console.WriteLine(final);
        }
    }
}
