namespace Hackerrank.ConsoleApp
{
    public static class SavePrisonerResolve
    {
        public static int SaveThePrisoner(int numberOfPrisoners, int numberOfSweets, int prisonerId)
        {
            var remainingPrisonersBeforeEnd = numberOfPrisoners - prisonerId + 1;
            if (numberOfSweets > remainingPrisonersBeforeEnd)
            {
                prisonerId = 1;
                numberOfSweets -= remainingPrisonersBeforeEnd;
                numberOfSweets %= numberOfPrisoners;
            }

            if (numberOfSweets == 0)
                prisonerId = numberOfPrisoners;
            else
                prisonerId += numberOfSweets - 1;

            return prisonerId;
        }
    }
}
