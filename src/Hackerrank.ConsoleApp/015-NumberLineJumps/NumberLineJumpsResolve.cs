namespace Hackerrank.ConsoleApp
{
    public static class NumberLineJumpsResolve
    {
        public static string Kangaroo(int start1, int jumpDistance1, int start2, int jumpDistance2)
        {
            if (start2 > start1 && jumpDistance2 > jumpDistance1)
                return "NO";
            
            if (jumpDistance1 == jumpDistance2)
                return "NO";

            if (
                (start2 - start1) % (jumpDistance1 - jumpDistance2) == 0
                || (start2 - start1) % (jumpDistance2 - jumpDistance1) == 0)
            {
                return "YES";
            }

            return "NO";
        }
    }
}