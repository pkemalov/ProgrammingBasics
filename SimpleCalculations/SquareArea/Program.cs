    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SquareArea
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("The number is: ");
                var a = int.Parse(Console.ReadLine());
                Console.Write("Square is: ");
                var area = a * a;
                Console.WriteLine(area);
            }
        }
    }
