using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class BeautifulDaysMoviesResolveTests
    {
        [Theory]
        [InlineData(2, 20, 23, 6)]
        [InlineData(33, 13, 45, 3)]
        public void Should_be_the_class_is_cancelled_expect_results_match(
            int expectedResult,
            int startDay,
            int endDay,
            int divisor
        )
        {
            var result = BeautifulDaysMoviesResolve.BeautifulDays(startDay, endDay, divisor);

            Assert.Equal(expectedResult, result);
        }
    }
}
