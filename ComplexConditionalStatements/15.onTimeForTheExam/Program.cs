using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.onTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hoursActual = int.Parse(Console.ReadLine());
            int minutesActual = int.Parse(Console.ReadLine());

            if (hoursExam == hoursActual)
            {
                if (minutesActual > minutesExam)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutesActual - minutesExam} minutes after the start");
                }
                else if (minutesExam - minutesActual <= 30 && minutesExam - minutesActual>0)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutesExam - minutesActual} minutes before the start");
                }
                else if (minutesExam == minutesActual)
                {
                    Console.WriteLine("On time");
                }
                else if (minutesExam - minutesActual > 30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minutesExam - minutesActual} minutes before the start");
                }
            }

            else if (hoursExam - hoursActual == 1)
            {
                if (minutesExam - minutesActual +60 <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutesExam - minutesActual + 60} minutes before the start");
                }
                else if(minutesExam==minutesActual)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"1:00 hours before the start");
                }
                else if (minutesExam - minutesActual >0 && minutesExam - minutesActual <10)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"1:0{minutesExam - minutesActual} hours before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minutesExam - minutesActual + 60} minutes before the start");
                }
            }

            else if (hoursExam - hoursActual > 1)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1} hours before the start", hoursExam - hoursActual, minutesExam - minutesActual);
            }

            else if (hoursActual - hoursExam == 1)
            {
                if (minutesActual < minutesExam)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", minutesActual - minutesExam + 60);
                }
                else if (minutesActual == minutesExam)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("1:00 hours after the start");
                }
                else if (minutesActual > minutesExam && minutesActual - minutesExam <10)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:0{1} hours after the start", hoursActual - hoursExam, minutesActual - minutesExam);
                }

                else 
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1} hours after the start", hoursActual - hoursExam, minutesActual - minutesExam);
                }
            }
            else if (hoursActual - hoursExam> 1 && minutesActual<minutesExam)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1} hours after the start", hoursActual - hoursExam-1, minutesActual-minutesExam+60);
            }
            else if (hoursActual - hoursExam > 1 && minutesActual == minutesExam)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:00 hours after the start", hoursActual - hoursExam);
            }
            else if (hoursActual - hoursExam > 1 && minutesActual > minutesExam && minutesActual - minutesExam < 10)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:0{1} hours after the start", hoursActual - hoursExam, minutesActual - minutesExam);
            }
            else if (hoursActual - hoursExam > 1 && minutesActual > minutesExam)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:0{1} hours after the start", hoursActual - hoursExam, minutesActual - minutesExam);
            }
        }
    }
}


