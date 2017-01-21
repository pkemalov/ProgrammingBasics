using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;
            var p4 = 0.00;
            var sum = 0.00;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                sum = sum + grade;
                if (grade >=2.00 && grade<3.00)
                {
                    p1 += 1;
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    p2 += 1;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    p3 += 1;
                }
                else if (grade >= 5.00)
                {
                    p4 += 1;
                }
            }

            Console.WriteLine("Top students: {0:f2}%", p4*100/students);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", p3 * 100/ students);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", p2 * 100/ students);
            Console.WriteLine("Fail: {0:f2}%", p1 * 100/ students);
            Console.WriteLine("Average: {0:f2}", sum/students);
        }
    }
}
