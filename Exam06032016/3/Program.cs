using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourStudent = int.Parse(Console.ReadLine());
            int minutesStudent = int.Parse(Console.ReadLine());

            var totalminutesExam = hourExam * 60 + minutesExam;
            var totalminutesStudent = hourStudent * 60 + minutesStudent;
            var result = totalminutesStudent - totalminutesExam;

            if (result > 0)
            {
                Console.WriteLine("Late");
                if (result < 60)
                {
                    Console.WriteLine("{0} minutes after the start", result);
                }
                else if (result >= 60 && result % 60 >= 10)
                {
                    Console.WriteLine("{0}:{1} hours after the start", result / 60, result % 60);
                }
                else if (result >= 60 && result % 60 < 10)
                {
                    Console.WriteLine("{0}:0{1} hours after the start", result / 60, result % 60);
                }
            }

            if (result <= 0 && result >= -30)
            {
                Console.WriteLine("On time");
                if (result < 0)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(result));
                }
            }

            if (result < -30)
            {
                Console.WriteLine("Early");
                if (result > -60)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(result));
                }
                else if (result <= -60 && Math.Abs(result) % 60 >= 10)
                {
                    Console.WriteLine("{0}:{1} hours before the start", Math.Abs(result) / 60, Math.Abs(result) % 60);
                }
                else if (result <= -60 && Math.Abs(result) % 60 < 10)
                {
                    Console.WriteLine("{0}:0{1} hours before the start", Math.Abs(result) / 60, Math.Abs(result) % 60);
                }
            }


        }
    }
}
