using Hackerrank.Common;
using Hackerrank.ConsoleApp;
using System.Collections.Generic;
using Xunit;

namespace Hackerrank.Tests
{
    public class BillDivisionResolveTests
    {
        [Theory, MemberData(nameof(DataBill))]
        public void Should_be_obtain_the_value_of_consumed_by_anna_expect_results_match(
            string expectedResult,
            AbstractConsole console,
            List<int> bill,
            int k,
            int b
        )
        {
            BillDivisionResolve.BonAppetit(console, bill, k, b);

            Assert.Equal(expectedResult, console.Contents[0]);
        }

        public static IEnumerable<object[]> DataBill
        {
            get
            {
                yield return new object[] { "5", new TestConsole(), new List<int> { 3, 10, 2, 9 }, 1, 12 };
                yield return new object[] { "Bon Appetit", new TestConsole(), new List<int> { 3, 10, 2, 9 }, 1, 7 };
                yield return new object[] { "7", new TestConsole(), new List<int> { 7, 10, 12, 5 }, 0, 20 };
            }
        }
    }
}
