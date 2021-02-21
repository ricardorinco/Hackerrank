namespace Hackerrank.ConsoleApp
{
    public static class OrderOfPrimeInFactorialResolve
    {
        public static long Solve(long p, long l)
        {
            long divisibleByP = 0;
            long auxiliary = 0;

            var resultA = l / p / p;
            var resultB = l / p % p;
            var resultC = l % p;

            if (resultA > 0)
                divisibleByP += resultA * p;

            while (resultA > 0)
            {
                auxiliary += resultA;
                resultA /= p;
            }

            auxiliary %= p;

            if (auxiliary > 0)
                auxiliary = p - auxiliary;

            if (auxiliary < resultB)
                divisibleByP += p;
            else if (auxiliary == resultB)
                divisibleByP += resultC + 1;

            return divisibleByP - 1;
        }
    }
}
