using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 15 < 60)
            {
                Console.WriteLine($"{hours}:{minutes+15}");
            }
            else if (minutes + 15 >= 60 && hours<23)
            {
                if (minutes + 15 - 60 < 10)
                {
                    Console.WriteLine($"{hours + 1}:0{minutes + 15 - 60}");
                }
                else
                {
                    Console.WriteLine($"{hours + 1}:{minutes + 15 - 60}");
                }
            }
            else if (minutes + 15 >= 60 && hours >= 23)
            {
                if (minutes + 15 - 60 < 10)
                {
                    Console.WriteLine($"{0}:0{minutes + 15 - 60}");
                }    
                else
                {
                    Console.WriteLine($"{0}:{minutes + 15 - 60}");
                }    
            }
        }
    }
}
