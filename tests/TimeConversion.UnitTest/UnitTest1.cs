using Xunit;

namespace TimeConversion.UnitTest
{
    public class TimeConversionUnitTest
    {
        #region AM

        [Fact]
        public void Should_be_converted_12AM_to_00()
        {
            string hour = "12:01:00AM";
            string result = Program.timeConversion(hour);

            Assert.Equal("00:01:00", result);
        }

        [Fact]
        public void Should_be_converted_01AM_to_01()
        {
            string hour = "01:24:38AM";
            string result = Program.timeConversion(hour);

            Assert.Equal("01:24:38", result);
        }

        [Fact]
        public void Should_be_converted_02AM_to_02()
        {
            string hour = "02:18:22AM";
            string result = Program.timeConversion(hour);

            Assert.Equal("02:18:22", result);
        }

        #endregion

        #region PM

        [Fact]
        public void Should_be_converted_12PM_to_12()
        {
            string hour = "12:28:00PM";
            string result = Program.timeConversion(hour);

            Assert.Equal("12:28:00", result);
        }

        [Fact]
        public void Should_be_converted_08PM_to_20()
        {
            string hour = "08:12:59PM";
            string result = Program.timeConversion(hour);

            Assert.Equal("20:12:59", result);
        }

        [Fact]
        public void Should_be_converted_11PM_to_23()
        {
            string hour = "11:08:52PM";
            string result = Program.timeConversion(hour);

            Assert.Equal("23:08:52", result);
        }

        #endregion
    }
}
