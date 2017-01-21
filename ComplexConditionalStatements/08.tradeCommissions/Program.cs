using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.tradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());

            if (town =="sofia" && (s >=0 && s<=500))
            {
                Console.WriteLine("{0:F2}", 0.05*s);
            }
            else if (town == "varna" && (s >= 0 && s <= 500))
            {
                Console.WriteLine("{0:F2}", 0.045 * s);
            }
            else if (town == "plovdiv" && (s >= 0 && s <= 500))
            {
                Console.WriteLine("{0:F2}", 0.055 * s);
            }
            else
            {
                Console.WriteLine("error");
            }

            if (town == "sofia" && (s > 500 && s <= 1000))
            {
                Console.WriteLine("{0:F2}", 0.07 * s);
            }
            else if (town == "varna" && (s > 500 && s <= 1000))
            {
                Console.WriteLine("{0:F2}", 0.075 * s);
            }
            else if (town == "plovdiv" && (s > 500 && s <= 1000))
            {
                Console.WriteLine("{0:F2}", 0.08 * s);
            }
            else
            {
                Console.WriteLine("error");
            }

            if (town == "sofia" && (s > 1000 && s <= 10000))
            {
                Console.WriteLine("{0:F2}", 0.08 * s);
            }
            else if (town == "varna" && (s > 1000 && s <= 10000))
            {
                Console.WriteLine("{0:F2}", 0.10 * s);
            }
            else if (town == "plovdiv" && (s > 1000 && s <= 10000))
            {
                Console.WriteLine("{0:F2}", 0.12 * s);
            }
            else
            {
                Console.WriteLine("error");
            }

            if (town == "sofia" && s > 10000)
            {
                Console.WriteLine("{0:F2}", 0.12 * s);
            }
            else if (town == "varna" && s > 10000)
            {
                Console.WriteLine("{0:F2}", 0.13 * s);
            }
            else if (town == "plovdiv" && s > 10000)
            {
                Console.WriteLine("{0:F2}", 0.145 * s);
            }
            else
            {
                Console.WriteLine("error");
            }

            if (s<0)
            {
                Console.WriteLine("error");
            }
        }
    }
}
