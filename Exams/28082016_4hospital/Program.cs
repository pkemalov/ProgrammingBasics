using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28082016_4hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            var treatedPatients = 0;
            var untreatedPatients = 0;
            var numberDoctors = 7;

            for (int i = 1; i <= day; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i%3==0 && untreatedPatients>treatedPatients)
                {
                    numberDoctors = numberDoctors + 1;
                }

                if (patients>numberDoctors)
                {
                    treatedPatients = treatedPatients + numberDoctors;
                    untreatedPatients = untreatedPatients + patients - numberDoctors;
                }
                else
                {
                    treatedPatients = treatedPatients + patients;
                }

            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);

        }
    }
}
