using Hackerrank.Common;
using Hackerrank.ConsoleApp;
using System.Collections.Generic;
using Xunit;

namespace Hackerrank.Tests
{
    public class StaircaseResolveTests
    {
        [Theory, MemberData(nameof(DataStar))]
        public void Should_be_obtains_the_draw_of_star_expect_results_match(
            List<string> expectedResults,
            AbstractConsole console,
            int staircaseSize
        )
        {
            StaircaseResolve.Resolve(console, staircaseSize);

            for (int i = 0; i < console.Contents.Count; i++)
                Assert.Equal(expectedResults[i], console.Contents[i]);
        }

        public static IEnumerable<object[]> DataStar
        {
            get
            {
                yield return new object[] { new List<string> { "   #", "  ##", " ###", "####" }, new TestConsole(), 4 };
                yield return new object[] { new List<string> { "     #", "    ##", "   ###", "  ####", " #####", "######" }, new TestConsole(), 6 };
            }
        }
    }
}
