using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();
            double sumInMeters = number;

            if (inputMetric == "mm")
            {
                sumInMeters = number / 1000;
            }
            else if (inputMetric == "cm")
            {
                sumInMeters = number / 100;
            }
            else if (inputMetric == "mi")
            {
                sumInMeters = number / 0.000621371192;
            }
            else if (inputMetric == "in")
            {
                sumInMeters = number / 39.3700787;
            }
            else if (inputMetric == "km")
            {
                sumInMeters = number / 0.001;
            }
            else if (inputMetric == "ft")
            {
                sumInMeters = number / 3.2808399;
            }
            else if (inputMetric == "yd")
            {
                sumInMeters = number / 1.0936133;
            }

            double sumInOutputCurrency = sumInMeters;

            if (outputMetric == "mm")
            {
                sumInOutputCurrency = sumInMeters * 1000;
            }
            else if (outputMetric == "cm")
            {
                sumInOutputCurrency = sumInMeters * 100;
            }
            else if (outputMetric == "mi")
            {
                sumInOutputCurrency = sumInMeters * 0.000621371192;
            }
            else if (outputMetric == "in")
            {
                sumInOutputCurrency = sumInMeters * 39.3700787;
            }
            else if (outputMetric == "km")
            {
                sumInOutputCurrency = sumInMeters * 0.001;
            }
            else if (outputMetric == "ft")
            {
                sumInOutputCurrency = sumInMeters * 3.2808399;
            }
            else if (outputMetric == "yd")
            {
                sumInOutputCurrency = sumInMeters * 1.0936133;
            }
            Console.WriteLine(sumInOutputCurrency+" "+outputMetric);
        }
    }
}
