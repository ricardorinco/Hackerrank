
namespace Hackerrank.ConsoleApp
{
    public static class UtopianTreeResolve
    {
        public static int UtopianTree(int cycles)
        {
            var currentHeight = 1;
            for (var i = 1; i <= cycles; i++)
            {
                if (i % 2 == 0)
                    currentHeight += 1;
                else
                    currentHeight *= 2;
            }

            return currentHeight;
        }
    }
}
