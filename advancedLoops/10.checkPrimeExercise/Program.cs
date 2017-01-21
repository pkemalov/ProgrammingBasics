using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.checkPrimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var prime = true;

            if (n<2)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n%i==0)
                    {
                        prime = false;
                        break;
                    }
                    else
                    {
                        prime = true;
                    }        
                }
            }
            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
