using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class NumberLineJumpsResolveTests
    {
        [Theory]
        [InlineData("YES", 0, 3, 4, 2)]
        [InlineData("NO", 0, 2, 5, 3)]
        public void Should_be_obtains_the_same_land_location_after_same_number_of_jumps_expect_results_match(
            string expectedResult,
            int start1,
            int jumpDistance1,
            int start2,
            int jumpDistance2
        )
        {
            var canLandSameLocation = NumberLineJumpsResolve.Kangaroo(start1, jumpDistance1, start2, jumpDistance2);

            Assert.Equal(expectedResult, canLandSameLocation);
        }
    }
}