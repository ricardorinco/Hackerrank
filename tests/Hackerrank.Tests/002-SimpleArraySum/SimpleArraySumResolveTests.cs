using System.Collections.Generic;
using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class SimpleArraySumResolveTests
    {
        [Theory]
        [InlineData(6, new[] { 1, 2, 3 })]
        [InlineData(-55, new[] { 21, 4, -80 })]
        public void Should_be_sum_of_numbers_contains_in_array_expect_results_match(
            int expectedResult,
            IEnumerable<int> numbers
        )
        {
            var result = SimpleArraySumResolve.SimpleArraySum(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
