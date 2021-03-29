using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class ElectronicsShopResolveTest
    {
        [Theory]
        [InlineData(58, new[] { 40, 50, 60 }, new[] { 5, 8, 12 }, 60)]
        [InlineData(9, new[] { 3, 1 }, new[] { 5, 2, 8 }, 10)]
        [InlineData(-1, new[] { 4 }, new[] { 5 }, 5)]
        public void Should_be_find_the_most_expensive_keyboard_usb_driver_purchased_expect_results_match(
            int expectedResult,
            int[] keyboards,
            int[] drives,
            int budget
        )
        {
            var kit = ElectronicsShopResolve.GetMoneySpent(keyboards, drives, budget);

            Assert.Equal(expectedResult, kit);
        }
    }
}