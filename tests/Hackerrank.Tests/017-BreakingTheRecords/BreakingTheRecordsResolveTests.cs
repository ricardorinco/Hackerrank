using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class BreakingTheRecordsResolveTests
    {
        [Theory]
        [InlineData(new[] { 1, 1 }, new[] { 12, 24, 10, 24 })]
        [InlineData(new[] { 2, 4 }, new[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 })]
        [InlineData(new[] { 4, 0 }, new[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42, })]
        public void Should_be_find_the_number_of_times_breaks_records_for_most_and_least_points_expect_results_match(
            int[] expectedResult,
            int[] scores
        )
        {
            var records = BreakingTheRecordsResolve.BreakingRecords(scores);

            Assert.Equal(expectedResult, records);
        }
    }
}
