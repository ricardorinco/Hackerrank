using Hackerrank.ConsoleApp;
using System.Collections.Generic;
using Xunit;

namespace Hackerrank.Tests
{
    public class CompareTheTripletsResolveTests
    {
        [Theory, MemberData(nameof(DataTriplet))]
        public void Should_be_comparison_points_in_triplets_expect_results_match(List<int> expectedResults, List<int> a, List<int> b)
        {
            var result = CompareTheTripletsResolve.CompareTriplets(a, b);

            Assert.Equal(expectedResults, result);
        }

        public static IEnumerable<object[]> DataTriplet
        {
            get
            {
                yield return new object[] { new List<int> { 1, 1 }, new List<int> { 5, 6, 7 }, new List<int> { 3, 6, 10 } };
                yield return new object[] { new List<int> { 2, 1 }, new List<int> { 17, 28, 30 }, new List<int> { 99, 16, 8 } };
            }
        }
    }
}
