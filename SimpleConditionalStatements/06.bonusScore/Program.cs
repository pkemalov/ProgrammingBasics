    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _06.bonusScore
    {
        class Program
        {
            static void Main(string[] args)
            {
                double number = double.Parse(Console.ReadLine());
                double bonusScore = 0;
                if (number <=100)
                {
                    bonusScore = bonusScore + 5;
                }
                else if (number > 100 && number <=1000)
                {
                    bonusScore = number *20/100;    
                }
                else 
                {
                    bonusScore = number * 10 / 100;
                }
                if (number % 2 ==0)
                {
                    bonusScore = bonusScore + 1;
                }
                else if (number % 10 == 5)
                {
                    bonusScore = bonusScore + 2;
                }

                Console.WriteLine(bonusScore);
                Console.WriteLine(bonusScore + number);
            }
        }
    }
