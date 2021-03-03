using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class DayOfTheProgrammerResolveTests
    {
        [Theory]
        [InlineData("12.09.1800", 1800)]
        [InlineData("12.09.2016", 2016)]
        [InlineData("13.09.2017", 2017)]
        public void Should_be_obtain_the_data_of_256_day_of_the_year_expect_results_match(string expectedResult, int year)
        {
            var result = DayOfTheProgrammerResolve.DayOfProgrammer(year);

            Assert.Equal(expectedResult, result);
        }
    }
}
