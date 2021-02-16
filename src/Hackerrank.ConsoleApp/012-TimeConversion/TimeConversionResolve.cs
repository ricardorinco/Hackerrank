using System;

namespace Hackerrank.ConsoleApp._012_TimeConversion
{
    public class TimeConversionResolve
    {
        public static string TimeConversion(string hours)
        {
            var hoursParse = DateTime.Parse(hours);

            return hoursParse.ToString("HH:mm:ss"); ;
        }
    }
}
