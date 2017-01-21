using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var gender = char.Parse(Console.ReadLine());

            switch (gender)
            {
                case 'F':
                case 'f':
                    Console.WriteLine("female");
                    break;
                case 'M':
                case 'm':
                    Console.WriteLine("male");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
