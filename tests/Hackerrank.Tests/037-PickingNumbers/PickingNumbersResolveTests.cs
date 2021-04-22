using System.Collections.Generic;
using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class PickingNumbersResolveTestes
    {
        [Theory, MemberData(nameof(DataNumbers))]
        public void Should_be_obtain_the_value_of_consumed_by_anna_expect_results_match(
            int expectedResult,
            List<int> numbers
        )
        {
            var number = PickingNumbersResolve.PickingNumbers(numbers);

            Assert.Equal(expectedResult, number);
        }
        
        public static IEnumerable<object[]> DataNumbers
        {
            get
            {
                yield return new object[] { 5, new List<int> { 1, 1, 2, 2, 4, 4, 5, 5, 5 } };
                yield return new object[] { 3, new List<int> { 4, 6, 5, 3, 3, 1 } };
                yield return new object[] { 5, new List<int> { 1, 2, 2, 3, 1, 2 } };
            }
        }
    }
}