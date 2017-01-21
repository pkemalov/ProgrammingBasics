using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberHrizantemi = int.Parse(Console.ReadLine());
            int numberRoses = int.Parse(Console.ReadLine());
            int numberLale = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            var total = 0.00;

            if (holiday == 'Y')
            {
                total = 1.15 * (numberHrizantemi* 2.00+numberRoses* 4.10+numberLale* 2.50);

                if (season == "Spring" || season == "Summer")
                {
                    
                    if (season == "Spring" && numberLale > 7)
                    {
                        total = 0.95 * total;
                        if ((numberHrizantemi + numberRoses + numberLale) > 20)
                        {
                            total = 0.95* 0.80 * total;
                        }
                    }
                    else if (season == "Spring" && numberLale <= 7)
                    {
                        total = 1 * total;
                        if ((numberHrizantemi + numberRoses + numberLale) > 20)
                        {
                            total = 0.80 * total;
                        }
                    }
                }
                else if (season == "Аutumn" || season == "Winter")
                {
                    total = 1.15 * (numberHrizantemi * 3.75 + numberRoses * 4.50 + numberLale * 4.15);
                    
                    if (season == "Winter" && numberRoses > 10)
                    {
                        total = 0.9 * total;
                        if ((numberHrizantemi + numberRoses + numberLale) > 20)
                        {
                            total = 0.9*0.80 * total;
                        }
                    }
                    else if (season == "Winter" && numberRoses <= 10)
                    {
                        total = 1 * total;
                        if ((numberHrizantemi + numberRoses + numberLale) > 20)
                        {
                            total = 0.80 * total;
                        }
                    }
                }
            }

            if (holiday == 'N')
            {
                total = (numberHrizantemi * 2.00 + numberRoses * 4.10 + numberLale * 2.50);

                if (season == "Spring" || season == "Summer")
                {

                    if (season == "Spring" && numberLale > 7)
                    {
                        total = 0.95 * total;
                        if ((numberHrizantemi + numberRoses + numberLale) > 20)
                        {
                            total = 0.95*0.80 * total;
                        }
                    }
                    else if (season == "Spring" && numberLale <= 7)
                    {
                        total = 1 * total;
                        if ((numberHrizantemi + numberRoses + numberLale) > 20)
                        {
                            total = 0.80 * total;
                        }
                    }
                }
                else if (season == "Аutumn" || season == "Winter")
                {
                    total = (numberHrizantemi * 3.75 + numberRoses * 4.50 + numberLale * 4.15);

                    if (season == "Winter" && numberRoses > 10)
                    {
                        total = 0.9 * total;
                        if ((numberHrizantemi + numberRoses + numberLale) > 20)
                        {
                            total = 0.9*0.80 * total;
                        }
                    }
                    else if (season == "Winter" && numberRoses <= 10)
                    {
                        total = 1 * total;
                        if ((numberHrizantemi + numberRoses + numberLale) > 20)
                        {
                            total = 0.80 * total;
                        }
                    }
                }
            }

            Console.WriteLine("{0:f2}", total + 2);

        }
    }
}
