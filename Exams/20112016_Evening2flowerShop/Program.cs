using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Evening2flowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int ziumbiuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            var order = 0.95*(magnolii * 3.25 + ziumbiuli * 4 + roses * 3.50 + cactuses * 8);

            if (order>=giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(order-giftPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice-order));
            }

        }
    }
}
