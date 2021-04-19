using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class ViralAdvertisingResolveTests
    {
        [Theory]
        [InlineData(9, 3)]
        [InlineData(15, 4)]
        public void Should_be_how_many_people_have_liked_end_of_given_day_expect_results_match(int expectedResult, int numberOfDays)
        {
            var willGoOn = ViralAdvertisingResolve.ViralAdvertising(numberOfDays);

            Assert.Equal(expectedResult, willGoOn);
        }
    }
}
