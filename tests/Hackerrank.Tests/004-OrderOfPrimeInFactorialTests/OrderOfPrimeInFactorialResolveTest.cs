using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class OrderOfPrimeInFactorialResolveTest
    {
        [Theory]
        [InlineData(2, 2, 6)]
        [InlineData(2, 3, 6)]
        public void Should_be_number_of_times_appears_in_the_prime_factorization_expect_results_match(int expectedResult, long p, long l)
        {
            long result = OrderOfPrimeInFactorialResolve.Solve(p, l);

            Assert.Equal(expectedResult, result);
        }
    }
}
