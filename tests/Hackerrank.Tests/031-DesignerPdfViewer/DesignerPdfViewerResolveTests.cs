using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class DesignerPdfViewerResolveTests
    {
        [Theory]
        [InlineData(8, new[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 1, 1, 5, 5, 1, 5, 2, 5, 5, 5, 5, 5, 5 }, "torn")]
        [InlineData(9, new[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, "abc")]
        [InlineData(28, new[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 }, "zaba")]
        public void Should_be_find_the_selection_area_for_word_expect_results_match(
            int expectedResult,
            int[] heights,
            string word
        )
        {
            var result = DesignerPdfViewerResolve.DesignerPdfViewer(heights, word);

            Assert.Equal(expectedResult, result);
        }
    }
}