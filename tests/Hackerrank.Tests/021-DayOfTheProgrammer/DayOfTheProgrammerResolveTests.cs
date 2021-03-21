using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class DayOfTheProgrammerResolveTests
    {
        [Theory]
        [InlineData("12.09.1800", 1800)]
        [InlineData("12.09.1900", 1900)]
        [InlineData("13.09.1915", 1915)]
        [InlineData("12.09.1916", 1916)]
        [InlineData("26.09.1918", 1918)]
        [InlineData("13.09.1986", 1986)]
        [InlineData("12.09.1996", 1996)]
        [InlineData("12.09.2000", 2000)]
        [InlineData("12.09.2016", 2016)]
        [InlineData("13.09.2017", 2017)]
        [InlineData("13.09.2021", 2021)]
        public void Should_be_obtain_the_data_of_256_day_of_the_year_expect_results_match(string expectedResult, int year)
        {
            var result = DayOfTheProgrammerResolve.DayOfProgrammer(year);

            Assert.Equal(expectedResult, result);
        }
    }
}
