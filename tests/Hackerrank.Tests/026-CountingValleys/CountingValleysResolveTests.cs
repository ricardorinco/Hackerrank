using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class CountingValleysResolveTests
    {
        [Theory]
        [InlineData(1, 8, "UDDDUDUU")]
        [InlineData(2, 12, "DDUUDDUDUUUD")]
        [InlineData(2, 10, "DUDDDUUDUU")]
        [InlineData(2, 100, "DUDUUUUUUUUDUDDUUDUUDDDUUDDDDDUUDUUUUDDDUUUUUUUDDUDUDUUUDDDDUUDDDUDDDDUUDDUDDUUUDUUUDUUDUDUDDDDDDDDD")]
        [InlineData(0, 1, "DU")]
        [InlineData(1, 2, "DU")]
        [InlineData(0, 3, "DDU")]
        [InlineData(5, 20, "DDUUDDUUDDUUDDUUDDUU")]
        [InlineData(0, 10, "UUUUUDUUUU")]
        public void Should_be_number_of_valleys_expect_results_match(int expectedResult, int steps, string path)
        {
            var valleys = CountingValleysResolve.CountingValleys(steps, path);

            Assert.Equal(expectedResult, valleys);
        }
    }
}
