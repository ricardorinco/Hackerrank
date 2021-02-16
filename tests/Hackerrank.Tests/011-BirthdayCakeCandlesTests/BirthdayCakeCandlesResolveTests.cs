using Hackerrank.ConsoleApp._011_BirthdayCakeCandles;
using System.Collections.Generic;
using Xunit;

namespace Hackerrank.Tests._011_BirthdayCakeCandlesTests
{
    public class BirthdayCakeCandlesResolveTests
    {
        [Theory, MemberData(nameof(DataCandles))]
        public void Should_be_sum_of_numbers_contains_in_array_expect_results_match(int expectedResult, List<int> candles)
        {
            int result = BirthdayCakeCandlesResolve.BirthdayCakeCandles(candles);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> DataCandles
        {
            get
            {
                yield return new object[] { 2, new List<int> { 4, 4, 1, 3 } };
                yield return new object[] { 3, new List<int> { 43, 43, 43, 22, 1, 22, 22 } };
                yield return new object[] { 2, new List<int> { 3, 2, 1, 3 } };
            }
        }
    }
}
