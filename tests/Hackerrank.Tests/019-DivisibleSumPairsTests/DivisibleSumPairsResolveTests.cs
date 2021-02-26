using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class DivisibleSumPairsResolveTests
    {
        [Theory]
        [InlineData(3, 6, 5, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(5, 6, 3, new int[] { 1, 3, 2, 6, 1, 2 })]
        public void Should_be_obtains_the_number_of_possible_divisions_expect_results_match(
            int expectedResult,
            int length,
            int divisor,
            int[] numbers
        )
        {
            var result = DivisibleSumPairsResolve.DivisibleSumPairs(length, divisor, numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
