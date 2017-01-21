using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine()); 
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Hello, {0}, you are {1}-years old and your gender is {2}", name, age, gender);
            Console.WriteLine("Hello, {name}. You are {age} years old and your gender is {gender}");
        }
    }
}
