using Hackerrank.ConsoleApp;
using System;
using Xunit;


namespace Hackerrank.Tests
{
    public class DiagonalDifferenceResolveTests
    {
        [Fact]
        public void Should_be_calculate_the_absolute_difference_between_the_sums_of_diagonals()
        {
            var matrix = new int[3][];
            matrix[0] = Array.ConvertAll("11 2 4".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            matrix[1] = Array.ConvertAll("4 5 6".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            matrix[2] = Array.ConvertAll("10 8 -12".Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));

            var result = DiagonalDifferenceResolve.DiagonalDifference(matrix);

            Assert.Equal(15, result);
        }
    }
}
