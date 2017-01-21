using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class EqualPairsExercise
    {
        static void Main(string[] args)
        {
            var numberOfPairs = int.Parse(
                Console.ReadLine());

            // We read the first pair before the loop to avoid the if-check inside it.
            // For comparison, see the EqualPairsExercise.txt file.
            var firstPairFirstNumber = int.Parse(
                Console.ReadLine());
            var firstPairSecondNumber = int.Parse(
                Console.ReadLine());

            var lastPairValue = firstPairFirstNumber +
                firstPairSecondNumber;

            var maxDifference = 0;
            for (var i = 0;
                i < numberOfPairs - 1;
                i++)
            {
                var currentPairFirstNumber = int.Parse(
                    Console.ReadLine());
                var currentPairSecondNumber = int.Parse(
                    Console.ReadLine());

                var currentPairValue = currentPairFirstNumber +
                    currentPairSecondNumber;

                var currentDifference = Math.Abs(currentPairValue -
                    lastPairValue);

                if (currentDifference > maxDifference)
                {
                    maxDifference = currentDifference;
                }

                lastPairValue = currentPairValue;
            }

            if (maxDifference == 0)
            {
                Console.WriteLine("Yes, value={0}",
                    lastPairValue);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}",
                    maxDifference);
            }
        }
    }
}
