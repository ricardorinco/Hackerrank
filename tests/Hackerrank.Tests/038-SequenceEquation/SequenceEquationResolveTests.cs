using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class SequenceEquationResolveTests
    {
        [Theory]
        [InlineData(new[] { 2, 3, 1 }, new[] { 2, 3, 1 })]
        [InlineData(new[] { 1, 3, 5, 4, 2 }, new[] { 4, 3, 5, 1, 2 })]
        public void Should_be_find_the_number_of_sequences_expect_results_match(
            int[] expectedResult,
            int[] values
        )
        {
            var results = SequenceEquationResolve.PermutationEquation(values);

            Assert.Equal(expectedResult, results);
        }
    }
}
