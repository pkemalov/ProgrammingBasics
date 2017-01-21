using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.minNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var givenNumber = 100000000000;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < givenNumber)
                {
                    givenNumber = num;
                }
            }
            Console.WriteLine(givenNumber);
        }
    }
}
