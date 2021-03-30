using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class CatsAndAMouseResolveTests
    {
        [Theory]
        [InlineData("Cat B", 2, 5, 4)]
        [InlineData("Cat B", 1, 2, 3)]
        [InlineData("Mouse C", 1, 3, 2)]
        public void Should_be_the_position_of_cats_and_a_mouse_expect_results_match(
            string expectedResult,
            int catA,
            int catB,
            int mouse
        )
        {
            var result = CatsAndAMouseResolve.CatAndMouse(catA, catB, mouse);

            Assert.Equal(expectedResult, result);
        }
    }
}