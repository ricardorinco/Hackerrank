using System.Collections.Generic;
using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class SubarrayDivisionResolveTests
    {
        [Theory, MemberData(nameof(DataChocolateBar))]
        public void Should_be_obtains_final_grades_in_array_expect_results_match(
            int expectedResult,
            List<int> squares,
            int d,
            int m
        )
        {
            var result = SubarrayDivisionResolve.Birthday(squares, d, m);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> DataChocolateBar
        {
            get
            {
                yield return new object[] { 2, new List<int> { 1, 2, 1, 3, 2 }, 3, 2 };
                yield return new object[] { 0, new List<int> { 1, 1, 1, 1, 1, 1 }, 3, 2 };
                yield return new object[] { 1, new List<int> { 4 }, 4, 1 };
            }
        }
    }
}