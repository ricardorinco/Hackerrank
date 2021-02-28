using Hackerrank.ConsoleApp;
using System.Collections.Generic;
using Xunit;

namespace Hackerrank.Tests
{
    public class MigratoryBirdsResolveTests
    {
        [Theory, MemberData(nameof(DataBirds))]
        public void Should_be_obtain_id_of_the_most_frequently_sighted_type_expect_results_match(
            int expectedResult,
            List<int> birds
        )
        {
            var result = MigratoryBirdsResolve.MigratoryBirds(birds);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> DataBirds
        {
            get
            {
                yield return new object[] { 4, new List<int> { 1, 4, 4, 4, 5, 3 } };
                yield return new object[] { 2, new List<int> { 2, 1, 1, 3, 2, 3, 4, 5, 2, 5 } };
                yield return new object[] { 3, new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 } };
            }
        }
    }
}
