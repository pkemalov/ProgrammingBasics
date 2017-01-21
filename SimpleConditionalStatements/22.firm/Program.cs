using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workersOvertime = int.Parse(Console.ReadLine());

            double neededHours = Math.Floor((days * 8 * 0.9) + (workersOvertime * days * 2) - hours);

            if (neededHours>=0)
            {
                Console.WriteLine("Yes!{0} hours left.", neededHours);
            } 
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(neededHours));
            }
        }
    }
}
