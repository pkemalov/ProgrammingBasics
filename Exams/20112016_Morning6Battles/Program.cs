using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112016_Morning6Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemones1 = int.Parse(Console.ReadLine());
            int pokemones2 = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            var battles = 0;

            for (int i = 1; i <= pokemones1; i++)
            {
                for (int j = 1; j <= pokemones2; j++)
                {
                    if (battles<maxBattles)
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                        battles += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (battles>maxBattles)
                {
                    break;
                }
            }
        }
    }
}
