using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24042016_4cleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int moneyPerYear = 0;
            int bonus = 10;
            int numberToys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    moneyPerYear = moneyPerYear + bonus-1;
                    bonus = bonus + 10;
                }
                else
                {
                    numberToys=numberToys+1;
                }
            }
            var saved = moneyPerYear + numberToys * toyPrice;
            if (saved>=washingMachine)
            {
                Console.WriteLine("Yes! {0:f2}", saved-washingMachine);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingMachine - saved);
            }
        }
    }
}
