using Hackerrank.ConsoleApp;
using System;
using System.Collections.Generic;
using Xunit;

namespace Hackerrank.Tests
{
    public class FormingMagicSquareResolveTests
    {
        [Fact]
        public void Should_be_calculate_convert_minimal_cost_matrix_4_9_2__3_5_7__8_1_5()
        {
            var matrix = new List<int>();
            matrix.AddRange(Array.ConvertAll("4 9 2".Split(' '), Convert.ToInt32));
            matrix.AddRange(Array.ConvertAll("3 5 7".Split(' '), Convert.ToInt32));
            matrix.AddRange(Array.ConvertAll("8 1 5".Split(' '), Convert.ToInt32));

            var result = FormingMagicSquareResolve.FormingMagicSquare(matrix);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Should_be_calculate_convert_minimal_cost_matrix_4_8_2__4_5_7__6_1_6()
        {
            var matrix = new List<int>();
            matrix.AddRange(Array.ConvertAll("4 8 2".Split(' '), Convert.ToInt32));
            matrix.AddRange(Array.ConvertAll("4 5 7".Split(' '), Convert.ToInt32));
            matrix.AddRange(Array.ConvertAll("6 1 6".Split(' '), Convert.ToInt32));

            var result = FormingMagicSquareResolve.FormingMagicSquare(matrix);

            Assert.Equal(4, result);
        }
    }
}