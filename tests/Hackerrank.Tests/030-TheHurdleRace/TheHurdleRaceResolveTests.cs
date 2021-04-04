using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class TheHurdleRaceResolveTests
    {
        [Theory]
        [InlineData(2, 1, new[] { 1, 2, 3, 3, 2 })]
        [InlineData(2, 4, new[] { 1, 6, 3, 5, 2 })]
        [InlineData(0, 7, new[] { 2, 5, 4, 5, 2 })]
        public void Should_be_many_doses_potion_must_character_take_to_able_jump_all_hurdles_expect_results_match(
            int expectedResult,
            int k,
            int[] heights
        )
        {
            var valleys = TheHurdleRaceResolve.HurdleRace(k, heights);

            Assert.Equal(expectedResult, valleys);
        }
    }
}
