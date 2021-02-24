using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class AVeryBigSumResolveTests
    {
        [Theory]
        [InlineData(5000000015, new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005, })]
        public void Should_be_calculate_of_elements_in_array_expect_results_match(long expectedResult, long[] numbers)
        {
            long result = AVeryBigSumResolve.AVeryBigSum(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
