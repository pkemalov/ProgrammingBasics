using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (numberNights > 7 && numberNights <= 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", 65 * numberNights);
                    Console.WriteLine("Studio: {0:F2} lv.", 50 * numberNights - 0.05 * 50 * numberNights);
                }
                else if (numberNights > 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", 65 * numberNights - 0.10 * 65 * numberNights);
                    Console.WriteLine("Studio: {0:F2} lv.", 50 * numberNights - 0.30 * 50 * numberNights);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", 65 * numberNights);
                    Console.WriteLine("Studio: {0:F2} lv.", 50 * numberNights);
                }
            }
            else if (month == "June" || month == "September")
            {
                if (numberNights > 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", 68.70 * numberNights - 0.10 * 68.70 * numberNights);
                    Console.WriteLine("Studio: {0:F2} lv.", 75.20 * numberNights - 0.20 * 75.20 * numberNights);
                }
                else 
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", 68.70 * numberNights);
                    Console.WriteLine("Studio: {0:F2} lv.", 75.20 * numberNights);
                }
            }
            else if (month == "July" || month == "August")
            {
                if (numberNights > 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", 77 * numberNights - 0.10 * 77 * numberNights);
                    Console.WriteLine("Studio: {0:F2} lv.", 76 * numberNights);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", 77 * numberNights);
                    Console.WriteLine("Studio: {0:F2} lv.", 76 * numberNights);
                }
            }
        }
    }
}
