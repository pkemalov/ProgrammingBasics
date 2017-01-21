using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06032016onTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hArrival = int.Parse(Console.ReadLine());
            int minArival = int.Parse(Console.ReadLine());

            var timeExam = hExam * 60 + minExam;
            var timeArrival = hArrival * 60 + minArival;
            var differenceLate = timeArrival - timeExam;

            if (differenceLate > 0 && differenceLate < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", differenceLate);
            }
            else if (differenceLate >= 60)
            {
                Console.WriteLine("Late");

                if (differenceLate % 60 < 10)
                {
                    Console.WriteLine("{0}:0{1} hours after the start", differenceLate / 60, differenceLate % 60);
                }
                else
                {
                    Console.WriteLine("{0}:{1} hours after the start", differenceLate / 60, differenceLate % 60);
                }
            }
            else if (differenceLate <= 0 && differenceLate >= -30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", Math.Abs(differenceLate));
            }
            else if (differenceLate <= 0 && differenceLate >= -30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", Math.Abs(differenceLate));
            }
            else if (differenceLate < -30 && differenceLate > -60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", Math.Abs(differenceLate));
            }
            else if (differenceLate <= -60)
            {
                Console.WriteLine("Early");

                if (Math.Abs(differenceLate)%60<10)
                {
                    Console.WriteLine("{0}:0{1} hours before the start", Math.Abs(differenceLate) / 60, Math.Abs(differenceLate) % 60);
                }
                else
                {
                    Console.WriteLine("{0}:{1} hours before the start", Math.Abs(differenceLate) / 60, Math.Abs(differenceLate) % 60);
                }
                
            }
        }



    }
}

