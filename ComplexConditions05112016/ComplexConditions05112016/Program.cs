using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexConditions05112016
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number == 1) //същото до 19 включително
            {
                Console.WriteLine("one");
            }
            if (number == 2)
            {
                Console.WriteLine("two");
            }

            else if (number >= 20 && number <= 99)
            {
                var firstDigit = number / 10;
                var secondDigit = number % 10;
                var numberName = ""; //string, който стои празен, към него след това добавяме втората цифра

                //construct first part of number name
                if (firstDigit == 2)
                {
                    numberName = "twenty";
                }
                else if (firstDigit == 3)
                {
                    numberName = "thirty";
                }
                else if (firstDigit == 4)
                {
                    numberName = "fourty"; // и т.н.
                }
                else if (firstDigit == 5)
                {
                    numberName = "fifty"; // и т.н.
                }
                else if (firstDigit == 6)
                {
                    numberName = "sixty"; // и т.н.
                }
                else if (firstDigit == 7)
                {
                    numberName = "seventy"; // и т.н.
                }
                else if (firstDigit == 8)
                {
                    numberName = "eighty"; // и т.н.
                }
                else if (firstDigit == 9)
                {
                    numberName = "ninety"; // и т.н.
                }

                //construct second part of number name

                if (secondDigit == 1)
                {
                    numberName += " one";
                }
                else if (secondDigit == 2)
                {
                    numberName += " two";
                }
                else if (secondDigit == 3)
                {
                    numberName += " three"; //и т.н
                }
                else if (secondDigit == 4)
                {
                    numberName += " four"; //и т.н
                }
                else if (secondDigit == 5)
                {
                    numberName += " five"; //и т.н
                }
                else if (secondDigit == 6)
                {
                    numberName += " six"; //и т.н
                }
                else if (secondDigit == 7)
                {
                    numberName += " seven"; //и т.н
                }
                else if (secondDigit == 8)
                {
                    numberName += " eight"; //и т.н
                }
                else if (secondDigit == 9)
                {
                    numberName += " nine"; //и т.н
                }
                Console.WriteLine(numberName);
            }
            else if (number == 100)
            {
                Console.WriteLine("hundred");
            }
        }
    }
}
