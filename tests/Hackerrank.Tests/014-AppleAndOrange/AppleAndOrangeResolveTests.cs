using Hackerrank.ConsoleApp;
using System.Collections.Generic;
using Hackerrank.Common.Console;
using Xunit;

namespace Hackerrank.Tests
{
    public class AppleAndOrangeTests
    {
        [Theory, MemberData(nameof(DataFruits))]
        public void Should_be_obtains_fruits_falls_land_house_sam_expect_results_match(
            int totalApplesExpectedResult,
            int totalOrangesExpectedResult,
            AbstractConsole console,
            int s,
            int t,
            int a,
            int b,
            int[] apples,
            int[] oranges
        )
        {
            AppleAndOrangeResolve.CountApplesAndOranges(console, s, t, a, b, apples, oranges);

            var totalApples = console.Contents[0];
            var totalOranges = console.Contents[1];

            Assert.Equal(totalApplesExpectedResult.ToString(), totalApples);
            Assert.Equal(totalOrangesExpectedResult.ToString(), totalOranges);
        }

        public static IEnumerable<object[]> DataFruits
        {
            get
            {
                yield return new object[] { 1, 1, new TestConsole(), 7, 11, 5, 15, new[] { -2, 2, 1 }, new[] { 5, -6 } };
            }
        }
    }
}