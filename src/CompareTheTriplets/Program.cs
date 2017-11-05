using System;

namespace CompareTheTriplets
{
    public class Program
    {
        static void Main(string[] args)
        {
            var personOne = new Triplet();
            var personTwo = new Triplet();

            var inputs = Console.ReadLine().Split(' ');
            personOne.One = Int32.Parse(inputs[0]);
            personOne.Two = Int32.Parse(inputs[1]);
            personOne.Three = Int32.Parse(inputs[2]);

            inputs = Console.ReadLine().Split(' ');
            personTwo.One = Int32.Parse(inputs[0]);
            personTwo.Two = Int32.Parse(inputs[1]);
            personTwo.Three = Int32.Parse(inputs[2]);

            VerifyPoints(personOne, personTwo);

            Console.ReadKey();
        }

        private static void VerifyPoints(Triplet personOne, Triplet personTwo)
        {
            if (personOne.One > personTwo.One)
                personOne.AddPoint();
            else if (personOne.One != personTwo.One)
                personTwo.AddPoint();

            if (personOne.Two > personTwo.Two)
                personOne.AddPoint();
            else if (personOne.Two != personTwo.Two)
                personTwo.AddPoint();

            if (personOne.Three > personTwo.Three)
                personOne.AddPoint();
            else if (personOne.Three != personTwo.Three)
                personTwo.AddPoint();

            Console.WriteLine($"{personOne.Points} {personTwo.Points}");
        }
    }

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
