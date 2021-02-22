using System.Collections.Generic;
using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class BetweenTwoSetsResolveTests
    {
        [Theory, MemberData(nameof(DataGrades))]
        public void Should_be_obtains_final_grades_in_array_expect_results_match(int expectedResult, List<int> a, List<int> b)
        {
            int result = BetweenTwoSetsResolve.GetTotalX(a, b);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> DataGrades
        {
            get
            {
                yield return new object[] { 2, new List<int> { 2, 6 }, new List<int> { 24, 36 } };
                yield return new object[] { 2, new List<int> { 3, 4 }, new List<int> { 24, 48 } };
                yield return new object[] { 3, new List<int> { 2, 4 }, new List<int> { 16, 32, 96 } };
            }
        }
    }
}