using Hackerrank.ConsoleApp._001_SolveMeFirst;
using Xunit;

namespace Hackerrank.UnitTest._001_SolveMeFirstUnitTest
{
    public class SolveMeFirstResolveUnitTest
    {
        [Fact]
        public void Should_be_sum_10_and_84_to_obtain_94()
        {
            int value1 = 10;
            int value2 = 84;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(94, result);
        }

        [Fact]
        public void Should_be_sum_2_and_4_to_obtain_6()
        {
            int value1 = 2;
            int value2 = 4;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(6, result);
        }

        [Fact]
        public void Should_be_sum_1218_and_14518_to_obtain_15736()
        {
            int value1 = 1218;
            int value2 = 14518;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(15736, result);
        }

        [Fact]
        public void Should_be_sum_21474_and_83647_to_obtain_105121()
        {
            int value1 = 21474;
            int value2 = 83647;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(105121, result);
        }

        [Fact]
        public void Should_be_sum_2147483647_and_2_to_obtain_2147483647()
        {
            int value1 = 2147483647;
            int value2 = -2;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(2147483645, result);
        }

        [Fact]
        public void Should_be_sum_52_and_minus_286_to_obtain_minus_234()
        {
            int value1 = 52;
            int value2 = -286;

            long result = SolveMeFirstResolve.SolveMeFirst(value1, value2);

            Assert.Equal(-234, result);
        }
    }
}
