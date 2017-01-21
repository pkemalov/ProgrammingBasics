using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26032016_tubes
{
    class Program
    {
        static void Main(string[] args)
        {
            var pool = int.Parse(Console.ReadLine());
            var firstTube = int.Parse(Console.ReadLine());
            var secondTube = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            var result = pool - (firstTube * hours + secondTube * hours);
            var zapulvane = firstTube * hours + secondTube * hours;

            if (result >=0)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (firstTube * hours + secondTube * hours) / pool*100, Math.Truncate((firstTube * hours / zapulvane)*100), Math.Truncate((secondTube * hours / zapulvane) * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, zapulvane-pool);
            }
        }
    }
}
