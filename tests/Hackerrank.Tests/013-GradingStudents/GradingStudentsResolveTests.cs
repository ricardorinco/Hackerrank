using System.Collections.Generic;
using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class GradingStudentsResolveTests
    {
        [Theory, MemberData(nameof(DataGrades))]
        public void Should_be_obtains_final_grades_in_array_expect_results_match(List<int> expectedResult, List<int> grades)
        {
            List<int> result = GradingStudentsResolve.GradingStudents(grades);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> DataGrades
        {
            get
            {
                yield return new object[] { new List<int> { 75, 67, 40, 33 }, new List<int> { 73, 67, 38, 33 } };
                yield return new object[] { new List<int> { 95, 100, 32, 50, 33 }, new List<int> { 95, 98, 32, 48, 33 } };
            }
        }
    }
}