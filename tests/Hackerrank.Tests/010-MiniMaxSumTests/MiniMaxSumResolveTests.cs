using Hackerrank.Common;
using Hackerrank.ConsoleApp;
using System.Collections.Generic;
using Xunit;

namespace Hackerrank.Tests
{
    public class MiniMaxSumResolveTests
    {
        [Theory, MemberData(nameof(DataNumber))]
        public void Should_be_obtains_sum_min_and_max_numbers_expect_results_match(
            string resultExpectedResult,
            AbstractConsole console,
            int[] numbers
        )
        {
            MiniMaxSumResolve.MiniMaxSum(console, numbers);

            var result = console.Contents[0];

            Assert.Equal(resultExpectedResult.ToString(), result);
        }

        public static IEnumerable<object[]> DataNumber
        {
            get
            {
                yield return new object[] { "16 24", new TestConsole(), new int[] { 1, 3, 5, 7, 9 } };
                yield return new object[] { "10 14", new AppConsole(), new int[] { 1, 2, 3, 4, 5 } };
            }
        }
    }
}
