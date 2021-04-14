using System;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class BeautifulDaysMoviesResolve
    {
        public static int BeautifulDays(int startDay, int endDay, int divisor)
        {
            var days = 0;
            for (var i = startDay; i <= endDay; i++)
            {
                var reverseString = new string(i.ToString().Reverse().ToArray());
                var reverseNumber = int.Parse(reverseString);
                var d = Math.Abs(i - reverseNumber);
                var r = d % divisor;

                if (r == 0)
                    days++;
            }

            return days;
        }
    }
}
