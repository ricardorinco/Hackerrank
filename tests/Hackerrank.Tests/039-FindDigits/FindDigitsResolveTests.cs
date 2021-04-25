using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class FindDigitsResolveTests
    {
        [Theory]
        [InlineData(3, 124)]
        [InlineData(3, 111)]
        [InlineData(1, 10)]
        [InlineData(2, 12)]
        [InlineData(3, 1012)]
        public void Should_be_the_number_of_divisors_expect_results_match(
            int expectedResult,
            int number
        )
        {
            var results = FindDigitsResolve.FindDigits(number);

            Assert.Equal(expectedResult, results);
        }
    }
}
