using System;
using System.IO;
using Xunit;

namespace LeapYear.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestIsDivisibleByFour()
        {
            Assert.True(Program.IsLeapYear(1604));
            Assert.False(Program.IsLeapYear(1700));
            Assert.False(Program.IsLeapYear(1800));
        }

        [Fact]
        public void TestIsDivisibleByHundred()
        {
            Assert.True(Program.IsLeapYear(4000));
            Assert.False(Program.IsLeapYear(1905));
        }

        [Fact]
        public void TestIsDivisibleByFourhoundred()
        {
            Assert.True(Program.IsLeapYear(2000));
            Assert.True(Program.IsLeapYear(1600));
            Assert.False(Program.IsLeapYear(1800));
        }
    }
}
