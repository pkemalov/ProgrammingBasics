using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var BGN = int.Parse(Console.ReadLine());
            var USD = BGN / 1.79549;
            var EUR = BGN / 1.95583;
            var GBP = BGN / 2.53405;

        }
    }
}