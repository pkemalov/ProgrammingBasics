using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.fruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string banana = Console.ReadLine();
            
            if (banana == "banana" || banana == "apple" || banana == "kiwi" || banana == "cherry" || banana == "lemon" || banana == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (banana == "tomato" || banana == "cucumber" || banana == "pepper" || banana == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
    
