namespace Hackerrank.ConsoleApp
{
    public class Triplet
    {
        public int One { get; set; }
        public int Two { get; set; }
        public int Three { get; set; }

        private int points;
        public int Points
        {
            get { return points; }
        }
        public void AddPoint()
        {
            points += 1;
        }
    }
}
