using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class SavePrisonerResolveTests
    {
        [Theory]
        [InlineData(2, 5, 2, 1)]
        [InlineData(3, 5, 2, 2)]
        [InlineData(6, 7, 19, 2)]
        [InlineData(3, 3, 7, 3)]
        public void Should_be_chair_number_occupied__receive_candy_expect_results_match(
            int expectedResult,
            int numberOfPrisoners,
            int numberOfSweets,
            int prisonerId
        )
        {
            var result = SavePrisonerResolve.SaveThePrisoner(numberOfPrisoners, numberOfSweets, prisonerId);

            Assert.Equal(expectedResult, result);
        }
    }
}
