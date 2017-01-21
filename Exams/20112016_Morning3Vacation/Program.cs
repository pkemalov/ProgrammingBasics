using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Morning3Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            if (transport == "train" && adults + students < 50)
            {
                var transportCost = (adults * 24.99 + students * 14.99) * 2;
                var hotelCost = nights * 82.99;
                var commision = (transportCost + hotelCost) * 0.1;
                var total = transportCost + hotelCost + commision;
                Console.WriteLine("{0:f2}", total);
            }
            else if (transport == "train" && adults + students >= 50)
            {
                var transportCost = (adults * 24.99 + students * 14.99) * 2 * 0.5;
                var hotelCost = nights * 82.99;
                var commision = (transportCost + hotelCost) * 0.1;
                var total = transportCost + hotelCost + commision;
                Console.WriteLine("{0:f2}", total);
            }
            else if (transport == "bus")
            {
                var transportCost = (adults * 32.50 + students * 28.50) * 2;
                var hotelCost = nights * 82.99;
                var commision = (transportCost + hotelCost) * 0.1;
                var total = transportCost + hotelCost + commision;
                Console.WriteLine("{0:f2}", total);
            }
            else if (transport == "boat")
            {
                var transportCost = (adults * 42.99 + students * 39.99) * 2;
                var hotelCost = nights * 82.99;
                var commision = (transportCost + hotelCost) * 0.1;
                var total = transportCost + hotelCost + commision;
                Console.WriteLine("{0:f2}", total);
            }
            else if (transport == "airplane")
            {
                var transportCost = (adults * 70.00 + students * 50.00) * 2;
                var hotelCost = nights * 82.99;
                var commision = (transportCost + hotelCost) * 0.1;
                var total = transportCost + hotelCost + commision;
                Console.WriteLine("{0:f2}", total);
            }
        }
    }
}
