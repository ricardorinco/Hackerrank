using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class SalesByMatchResolveTests
    {
        [Theory]
        [InlineData(2, 7, new int[] { 1, 2, 1, 2, 1, 3, 2 })]
        [InlineData(3, 9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 28 })]
        [InlineData(4, 10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 })]
        [InlineData(4, 14, new int[] { 4, 8, 4, 8, 4, 8, 4, 4, 8, 7, 8, 9, 10, 22 })]
        public void Should_be_find_the_number_of_pairs_expect_results_match(
            int expectedResult,
            int n,
            int[] ar
        )
        {
            var result = SalesByMatchResolve.SockMerchant(n, ar);

            Assert.Equal(expectedResult, result);
        }
    }
}
