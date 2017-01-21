using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var sumVowels = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='a')
                {
                    sumVowels += 1;
                }
                else if (word[i] == 'e')
                {
                    sumVowels += 2;
                }
                else if (word[i] == 'i')
                {
                    sumVowels += 3;
                }
                else if (word[i] == 'o')
                {
                    sumVowels += 4;
                }
                else if (word[i] == 'u')
                {
                    sumVowels += 5;
                }
            }
            Console.WriteLine(sumVowels);

        }
    }
}
