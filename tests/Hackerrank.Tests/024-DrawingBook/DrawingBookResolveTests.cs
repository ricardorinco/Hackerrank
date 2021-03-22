using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class DrawingBookResolveTests
    {
        [Theory]
        [InlineData(1, 5, 3)]
        [InlineData(1, 6, 2)]
        [InlineData(0, 5, 4)]
        public void Should_be_find_the_number_of_minimum_pages_turn_expect_results_match(
            int expectedResult,
            int n,
            int p
        )
        {
            var result = DrawingBookResolve.PageCount(n, p);

            Assert.Equal(expectedResult, result);
        }
    }
}
