namespace Hackerrank.ConsoleApp
{
    public class Triplet
    {
        public int One { get; set; }
        public int Two { get; set; }
        public int Three { get; set; }

        public int Points { get; private set; }

        public void AddPoint()
        {
            Points += 1;
        }
    }
}
