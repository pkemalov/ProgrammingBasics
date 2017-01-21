using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28082016_3hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());
            var totalPriceStudio = 1.00;
            var totalPriceApp = 1.00;

            if (month == "May")
            {
                if (numberNights > 7 && numberNights <= 14)
                {
                    totalPriceStudio = 50 * numberNights - 0.05 * 50 * numberNights;
                    totalPriceApp = 65 * numberNights;
                }
                else if (numberNights > 14)
                {
                    totalPriceStudio = 50 * numberNights - 0.30 * 50 * numberNights;
                    totalPriceApp = 65 * numberNights - 0.10 * 65 * numberNights;
                }
                else
                {
                    totalPriceStudio = 50 * numberNights;
                    totalPriceApp = 65 * numberNights;
                }
            }

            else if (month == "October")
            {
                if (numberNights > 7 && numberNights <= 14)
                {
                    totalPriceStudio = 50 * numberNights - 0.05 * 50 * numberNights;
                    totalPriceApp = 65 * numberNights;
                }
                else if (numberNights > 14)
                {
                    totalPriceStudio = 50 * numberNights - 0.30 * 50 * numberNights;
                    totalPriceApp = 65 * numberNights - 0.10 * 65 * numberNights;
                }
                else
                {
                    totalPriceStudio = 50 * numberNights;
                    totalPriceApp = 65 * numberNights;
                }
            }

            else if (month == "June")
            {

                if (numberNights > 14)
                {
                    totalPriceStudio = 75.20 * numberNights - 0.20 * 75.20 * numberNights;
                    totalPriceApp = 68.70 * numberNights - 0.10 * 68.70 * numberNights;
                }
                else
                {
                    totalPriceStudio = 75.20 * numberNights;
                    totalPriceApp = 68.70 * numberNights;
                }
            }

            else if (month == "September")
            {

                if (numberNights > 14)
                {
                    totalPriceStudio = 75.20 * numberNights - 0.20 * 75.20 * numberNights;
                    totalPriceApp = 68.70 * numberNights - 0.10 * 68.70 * numberNights;
                }
                else
                {
                    totalPriceStudio = 75.20 * numberNights;
                    totalPriceApp = 68.70 * numberNights;
                }
            }

            else if (month == "July")
            {

                if (numberNights > 14)
                {
                    totalPriceStudio = 76 * numberNights;
                    totalPriceApp = 77 * numberNights - 0.10 * 77 * numberNights;
                }
                else
                {
                    totalPriceStudio = 76 * numberNights;
                    totalPriceApp = 77 * numberNights;
                }
            }

            else if (month == "August")
            {

                if (numberNights > 14)
                {
                    totalPriceStudio = 76 * numberNights;
                    totalPriceApp = 77 * numberNights - 0.10 * 77 * numberNights;
                }
                else
                {
                    totalPriceStudio = 76 * numberNights;
                    totalPriceApp = 77 * numberNights;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", totalPriceApp);
            Console.WriteLine("Studio: {0:f2} lv.", totalPriceStudio);
        }
    }
}


