using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConditionalStatements29102016_Lec
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture); //ctrl+. за добаване на globalization
            var h = birthdate.AddDays(999);

            Console.WriteLine(h.ToString("dd-MM-yyyy"));

        }
    }
}
