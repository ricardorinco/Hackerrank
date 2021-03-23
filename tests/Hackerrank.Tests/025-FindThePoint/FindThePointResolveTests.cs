using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class FindThePointResolveTests
    {
        [Theory]
        [InlineData(new[] { 2, 2 }, 0, 0, 1, 1 )]
        [InlineData(new[] { 3, 3 }, 1, 1, 2, 2 )]
        [InlineData(new[] { 6, 1 }, 4, 3, 5, 2 )]
        [InlineData(new[] { 8, 8 }, 2, 4, 5, 6 )]
        [InlineData(new[] { 3, 2 }, 1, 2, 2, 2 )]
        [InlineData(new[] { 1, 1 }, 1, 1, 1, 1 )]
        [InlineData(new[] { 3, 0 }, 1, 2, 2, 1 )]
        [InlineData(new[] { 13, 8 }, 1, 8, 7, 8 )]
        [InlineData(new[] { -7, 1 }, 9, 1, 1, 1 )]
        [InlineData(new[] { -2, 0 }, 8, 4, 3, 2 )]
        [InlineData(new[] { 11, -6 }, 7, 8, 9, 1 )]
        public void Should_be_find_the_point_of_r_expect_results_match(
            int[] expectedResult,
            int px,
            int py,
            int qx,
            int qy
        )
        {
            var points = FindThePointResolve.FindPoint(px, py, qx, qy);

            Assert.Equal(expectedResult, points);
        }
    }
}
