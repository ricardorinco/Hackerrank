using Hackerrank.ConsoleApp._012_TimeConversion;
using Xunit;

namespace Hackerrank.Tests._012_TimeConversionTests
{
    public class TimeConversionResolveTests
    {
        [Fact]
        public void Should_be_converted_12AM_to_obtain_00()
        {
            string hour = "12:01:00AM";
            string result = TimeConversionResolve.TimeConversion(hour);

            Assert.Equal("00:01:00", result);
        }

        [Fact]
        public void Should_be_converted_01AM_to_obtain_01()
        {
            string hour = "01:24:38AM";
            string result = TimeConversionResolve.TimeConversion(hour);

            Assert.Equal("01:24:38", result);
        }

        [Fact]
        public void Should_be_converted_02AM_to_obtain_02()
        {
            string hour = "02:18:22AM";
            string result = TimeConversionResolve.TimeConversion(hour);

            Assert.Equal("02:18:22", result);
        }

        [Fact]
        public void Should_be_converted_12PM_to_obtain_12()
        {
            string hour = "12:28:00PM";
            string result = TimeConversionResolve.TimeConversion(hour);

            Assert.Equal("12:28:00", result);
        }

        [Fact]
        public void Should_be_converted_08PM_to_obtain_20()
        {
            string hour = "08:12:59PM";
            string result = TimeConversionResolve.TimeConversion(hour);

            Assert.Equal("20:12:59", result);
        }

        [Fact]
        public void Should_be_converted_11PM_to_obtain_23()
        {
            string hour = "11:08:52PM";
            string result = TimeConversionResolve.TimeConversion(hour);

            Assert.Equal("23:08:52", result);
        }
    }
}
