namespace Hackerrank.ConsoleApp
{
    public static class ViralAdvertisingResolve
    {
        public static int ViralAdvertising(int numberOfDays)
        {
            int peopleLiked = 5;
            int sum = 0;

            for (var i = 0; i < numberOfDays; i++)
            {
                sum += peopleLiked / 2;
                peopleLiked = peopleLiked / 2 * 3;
            }

            return sum;
        }
    }
}
