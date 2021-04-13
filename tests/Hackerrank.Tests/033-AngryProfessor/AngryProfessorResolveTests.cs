using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class AngryProfessorResolveTests
    {
        [Theory]
        [InlineData("NO", 3, new[] { -2, -1, 0, 1, 2 })]
        [InlineData("YES", 3, new[] { -1, -3, 4, 2 })]
        [InlineData("NO", 2, new[] { 0, -1, 2, 1 })]
        public void Should_be_the_class_is_cancelled_expect_results_match(string expectedResult, int threshold, int[] students)
        {
            var willGoOn = AngryProfessorResolve.AngryProfessor(threshold, students);

            Assert.Equal(expectedResult, willGoOn);
        }
    }
}
