using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double razhod = 5.4;
            int kilometers = 500;
            double tank = 100;

            double kolkoSgteMinem = tank / razhod;

            bool isFuelEnough = kolkoSgteMinem >= kilometers;

            if (!isFuelEnough)
            {
                Console.WriteLine("zarejdame");
            }

            Console.WriteLine("stigame");

            
        }
    }
}
