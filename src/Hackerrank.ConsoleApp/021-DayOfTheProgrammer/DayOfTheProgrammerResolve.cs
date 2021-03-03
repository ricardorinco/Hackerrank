namespace Hackerrank.ConsoleApp
{
    public static class DayOfTheProgrammerResolve
    {
        private static readonly int daysUntilAugustLeapYear = 244;
        private static readonly int daysTillAugustNonLeapYear = 243;

        public static string DayOfProgrammer(int year)
        {
            if (year >= 1919)
                return GetDateGregorianCalendar(year);
            else if (year <= 1917)
                return GetDateJulianCalendar(year);

            return "26.09.1918";
        }

        private static string GetDateJulianCalendar(int year)
        {
            var programmerDateInSeptember = IsJulianLeapYear(year) ? 256 - daysUntilAugustLeapYear : 256 - daysTillAugustNonLeapYear;
            var dateWithFormat = programmerDateInSeptember + ".09." + year.ToString();
            
            return dateWithFormat;
        }

        private static string GetDateGregorianCalendar(int year)
        {
            var programmerDateInSeptember = IsGregorianLeapYear(year) ? 256 - daysUntilAugustLeapYear : 256 - daysTillAugustNonLeapYear;
            var dateWithFormat = programmerDateInSeptember + ".09." + year.ToString();

            return dateWithFormat;
        }

        private static bool IsJulianLeapYear(int year)
        {
            if (year % 4 == 0)
                return true;

            return false;
        }

        private static bool IsGregorianLeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                return true;

            return false;
        }
    }
}
