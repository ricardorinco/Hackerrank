using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class UtopianTreeResolveTests
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(7, 4)]
        [InlineData(6, 3)]
        public void Should_be_tall_will_tree_after_growth_cycles_expect_results_match(
            int expectedResult,
            int cycles
        )
        {
            var valleys = UtopianTreeResolve.UtopianTree(cycles);

            Assert.Equal(expectedResult, valleys);
        }
    }
}
