using Hackerrank.ConsoleApp;
using System;
using Xunit;

namespace Hackerrank.Tests
{
    public class FormingMagicSquareResolveTests
    {
        [Fact]
        public void Should_be_calculate_convert_minimal_cost_matrix_4_9_2__3_5_7__8_1_5()
        {
            var matrix = new int[3][];
            matrix[0] = Array.ConvertAll("4 9 2".Split(' '), Convert.ToInt32);
            matrix[1] = Array.ConvertAll("3 5 7".Split(' '), Convert.ToInt32);
            matrix[2] = Array.ConvertAll("8 1 5".Split(' '), Convert.ToInt32);

            var result = FormingMagicSquareResolve.FormingMagicSquare(matrix);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Should_be_calculate_convert_minimal_cost_matrix_4_8_2__4_5_7__6_1_6()
        {
            var matrix = new int[3][];
            matrix[0] = Array.ConvertAll("4 8 2".Split(' '), Convert.ToInt32);
            matrix[1] = Array.ConvertAll("4 5 7".Split(' '), Convert.ToInt32);
            matrix[2] = Array.ConvertAll("6 1 6".Split(' '), Convert.ToInt32);

            var result = FormingMagicSquareResolve.FormingMagicSquare(matrix);

            Assert.Equal(4, result);
        }
    }
}
