using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class BetweenTwoSetsResolve
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            var totalXs = 0;
            var maximumA = a.Max();
            var minimumB = b.Min();
            var counter = 1;
            var multipleOfMaxA = maximumA;

            while (multipleOfMaxA <= minimumB)
            {
                var factorOfAll = a.All(item => multipleOfMaxA % item == 0);

                if (factorOfAll)
                {
                    if (b.Any(item => item % multipleOfMaxA != 0))
                    {
                        factorOfAll = false;
                    }
                }

                if (factorOfAll)
                    totalXs++;

                counter++;
                multipleOfMaxA = maximumA * counter;
            }
            
            return totalXs;
        }
    }
}