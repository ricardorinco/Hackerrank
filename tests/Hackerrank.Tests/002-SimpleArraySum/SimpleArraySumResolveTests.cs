using Hackerrank.ConsoleApp._002_SimpleArraySum;
using Xunit;

namespace Hackerrank.Tests._002_SimpleArraySum
{
    public class SimpleArraySumResolveTests
    {
        [Theory]
        [InlineData(6, new int[] { 1, 2, 3 })]
        [InlineData(-55, new int[] { 21, 4, -80 })]
        public void Should_be_sum_of_numbers_contains_in_array_expect_results_match(int expectedResult, int[] numbers)
        {
            int result = SimpleArraySumResolve.SimpleArraySum(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
