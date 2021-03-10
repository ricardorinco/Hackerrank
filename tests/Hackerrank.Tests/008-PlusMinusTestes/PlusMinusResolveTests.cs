﻿using Hackerrank.Common;
using Hackerrank.ConsoleApp;
using System.Collections.Generic;
using Xunit;

namespace Hackerrank.Tests
{
    public class PlusMinusResolveTests
    {
        [Theory, MemberData(nameof(DataRatio))]
        public void Should_be_obtains_ratios_of_the_elements_expect_results_match(
            List<decimal> expectedResults,
            AbstractConsole console,
            int[] arr
        )
        {
            PlusMinusResolve.PlusMinus(console, arr);

            Assert.Equal(string.Format("{0:0.000000}", expectedResults[0]), console.Contents[0]);
            Assert.Equal(string.Format("{0:0.000000}", expectedResults[1]), console.Contents[1]);
            Assert.Equal(string.Format("{0:0.000000}", expectedResults[2]), console.Contents[2]);
        }

        public static IEnumerable<object[]> DataRatio
        {
            get
            {
                yield return new object[] { new List<decimal> { 0.500000m, 0.333333m, 0.166667m }, new TestConsole(), new int[] { -4, 3, -9, 0, 4, 1 } };
                yield return new object[] { new List<decimal> { 0.400000m, 0.400000m, 0.200000m }, new TestConsole(), new int[] { 1, 1, 0, -1, -1 } };
            }
        }
    }
}
