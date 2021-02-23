using System.Collections.Generic;

namespace Hackerrank.ConsoleApp
{
    public static class CompareTheTripletsResolve
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var points = new List<int>();
            var personOne = new Triplet() { One = a[0], Two = a[1], Three = a[2] };
            var personTwo = new Triplet() { One = b[0], Two = b[1], Three = b[2] };

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

            points.AddRange(new List<int>() { personOne.Points, personTwo.Points });

            return points;
        }
    }
}
