using Hackerrank.ConsoleApp;
using Xunit;

namespace Hackerrank.Tests
{
    public class SolveMeFirstResolveTests
    {
        [Fact]
        public void Should_be_sum_10_and_84_to_obtain_94()
        {
            const int value1 = 10;
            const int value2 = 84;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(94, result);
        }

        [Fact]
        public void Should_be_sum_2_and_4_to_obtain_6()
        {
            const int value1 = 2;
            const int value2 = 4;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(6, result);
        }

        [Fact]
        public void Should_be_sum_1218_and_14518_to_obtain_15736()
        {
            const int value1 = 1218;
            const int value2 = 14518;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(15736, result);
        }

        [Fact]
        public void Should_be_sum_21474_and_83647_to_obtain_105121()
        {
            const int value1 = 21474;
            const int value2 = 83647;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(105121, result);
        }

        [Fact]
        public void Should_be_sum_2147483647_and_2_to_obtain_2147483647()
        {
            const int value1 = 2147483647;
            const int value2 = -2;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(2147483645, result);
        }

        [Fact]
        public void Should_be_sum_52_and_minus_286_to_obtain_minus_234()
        {
            const int value1 = 52;
            const int value2 = -286;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(-234, result);
        }
    }
}
