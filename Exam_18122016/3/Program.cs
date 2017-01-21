using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberHrizantemi = int.Parse(Console.ReadLine());
            int numberRoses = int.Parse(Console.ReadLine());
            int numberLaleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            var totalPriceBuket = 0.00;



            if (season == "Spring" || season == "Summer")
            {
                var priceHrizantemi = 2.00;
                var priceRoses = 4.10;
                var priceLaleta = 2.50;
                totalPriceBuket = numberHrizantemi * priceHrizantemi + numberRoses * priceRoses + numberLaleta * priceLaleta;

                if (holiday == 'Y')
                {
                    totalPriceBuket = 1.15 * totalPriceBuket;

                    if (numberLaleta > 7)
                    {
                        totalPriceBuket = 0.95 * totalPriceBuket;

                        if ((numberHrizantemi + numberRoses + numberLaleta) > 20)
                        {
                            totalPriceBuket = 0.8 * totalPriceBuket;
                        }
                    }
                }
                if (holiday == 'N')
                {
                    totalPriceBuket = 1 * totalPriceBuket;
                    if (numberLaleta > 7)
                    {
                        totalPriceBuket = 0.95 * totalPriceBuket;

                        if ((numberHrizantemi + numberRoses + numberLaleta) > 20)
                        {
                            totalPriceBuket = 0.8 * totalPriceBuket;
                        }
                    }
                    else
                    {
                        totalPriceBuket = 1 * totalPriceBuket;
                        if ((numberHrizantemi + numberRoses + numberLaleta) > 20)
                        {
                            totalPriceBuket = 0.8 * totalPriceBuket;
                        }
                    }
                }
            }

            else if (season == "Аutumn" || season == "Winter")
            {
                var priceHrizantemi = 3.75;
                var priceRoses = 4.50;
                var priceLaleta = 4.15;
                totalPriceBuket = numberHrizantemi * priceHrizantemi + numberRoses * priceRoses + numberLaleta * priceLaleta;

                if (holiday == 'Y')
                {
                    totalPriceBuket = 1.15 * totalPriceBuket;

                    if (numberRoses > 10)
                    {
                        totalPriceBuket = 0.9 * totalPriceBuket;

                        if ((numberHrizantemi + numberRoses + numberLaleta) > 20)
                        {
                            totalPriceBuket = 0.8 * totalPriceBuket;
                        }
                    }
                }
                if (holiday == 'N')
                {
                    if (numberRoses > 10)
                    {
                        totalPriceBuket = 0.9 * totalPriceBuket;

                        if ((numberHrizantemi + numberRoses + numberLaleta) > 20)
                        {
                            totalPriceBuket = 0.8 * totalPriceBuket;
                        }
                    }
                    else
                    {
                        totalPriceBuket = 1 * totalPriceBuket;
                        if ((numberHrizantemi + numberRoses + numberLaleta) > 20)
                        {
                            totalPriceBuket = 0.8 * totalPriceBuket;
                        }
                    }
                }
            }

            var final = totalPriceBuket + 2;

            Console.WriteLine("{0:f2}", final);
        }


    }
}

