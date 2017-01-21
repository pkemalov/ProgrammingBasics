using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Morning4lSoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;
            var p4 = 0.00;
            var p5 = 0.00;

            for (int i = 0; i < numberOfGroups; i++)
            {
                int peopleInaGroup = int.Parse(Console.ReadLine());

                if (peopleInaGroup <= 5)
                {
                    p1 = p1 + peopleInaGroup;
                }
                else if (peopleInaGroup > 5 && peopleInaGroup <= 12)
                {
                    p2 = p2 + peopleInaGroup;
                }
                else if (peopleInaGroup > 12 && peopleInaGroup <= 25)
                {
                    p3 = p3 + peopleInaGroup;
                }
                else if (peopleInaGroup > 25 && peopleInaGroup <= 40)
                {
                    p4 = p4 + peopleInaGroup;
                }
                else if (peopleInaGroup > 40)
                {
                    p5 = p5 + peopleInaGroup;
                }
            }
            Console.WriteLine("{0:f2}%", p1 / (p1 + p2 + p3 + p4 + p5) * 100);
            Console.WriteLine("{0:f2}%", p2 / (p1 + p2 + p3 + p4 + p5) * 100);
            Console.WriteLine("{0:f2}%", p3 / (p1 + p2 + p3 + p4 + p5) * 100);
            Console.WriteLine("{0:f2}%", p4 / (p1 + p2 + p3 + p4 + p5) * 100);
            Console.WriteLine("{0:f2}%", p5 / (p1 + p2 + p3 + p4 + p5) * 100);
        }
    }
}
