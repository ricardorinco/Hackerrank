namespace Hackerrank.ConsoleApp
{
    public static class CatsAndAMouseResolve
    {
        public static string CatAndMouse(int catA, int catB, int mouse)
        {
            var distanceCatA = (catA - mouse).NonNegative();
            var distanceCatB = (catB - mouse).NonNegative();

            if (distanceCatA == distanceCatB)
                return "Mouse C";
            
            return distanceCatA > distanceCatB ? "Cat B" : "Cat A";
        }

        private static int NonNegative(this int number)
        {
            return number > 0 ? number : number * -1;
        }
    }
}