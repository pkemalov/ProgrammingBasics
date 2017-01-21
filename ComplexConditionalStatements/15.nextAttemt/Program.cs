using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.nextAttemt
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hoursActual = int.Parse(Console.ReadLine());
            int minutesActual = int.Parse(Console.ReadLine());

            var examMinutes = hoursExam * 60 + minutesExam;
            var actualMinutes = hoursActual * 60 + minutesActual;

            if (actualMinutes > examMinutes)
            {
                if (actualMinutes - examMinutes< 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", minutesActual - minutesExam);
                }
                else if (actualMinutes - examMinutes >= 60 && actualMinutes - examMinutes< 70)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:0{1} minutes after the start", hoursActual - hoursExam, minutesActual - minutesExam);
                }
                else if (actualMinutes - examMinutes > 70)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1} minutes after the start", hoursActual - hoursExam, minutesActual - minutesExam);
                }

            }
        }
    }
}
