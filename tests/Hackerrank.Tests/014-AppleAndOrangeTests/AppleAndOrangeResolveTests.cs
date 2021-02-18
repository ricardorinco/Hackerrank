using System.Collections.Generic;
using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class AppleAndOrangeTests
    {
        [Theory]
        [InlineData(1, 1, 7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 } )]
        public void Should_be_obtains_fruits_falls_land_house_sam_expect_results_match(
            int totalApplesExpectedResult,
            int totalOrangesExpectedResult,
            int s,
            int t,
            int a,
            int b,
            int[] apples,
            int[] oranges
        )
        {
            var totalApples = AppleAndOrangeResolve.CountFruit(s, t, a, apples);
            var totalOranges = AppleAndOrangeResolve.CountFruit(s, t, b, oranges);

            Assert.Equal(totalApplesExpectedResult, totalApples);
            Assert.Equal(totalOrangesExpectedResult, totalOranges);
        }
    }
}