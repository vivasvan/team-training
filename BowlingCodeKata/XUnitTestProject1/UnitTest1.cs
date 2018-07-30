using System;
using Xunit;

namespace XUnitTestProject1
{
    using BowlingCodeKata;

    public class UnitTest1
    {
        [Fact]
        public void FourAndTwoIsSix()
        {
            var frame = new Frame { FirstThrow = 4, SecondThrow = 2 };
            Assert.Equal(frame.Score(null), 6);
        }

        [Fact]
        public void SpareCase()
        {
            var frame = new Frame { FirstThrow = 4, SecondThrow = 6 };
            var nextframe = new Frame { FirstThrow = 4, SecondThrow = 2 };

            Assert.Equal(frame.Score(nextframe), 14);
        }

        [Fact]
        public void StrikeCase()
        {
            var frame = new Frame { FirstThrow = 10, SecondThrow = 0 };
            var nextframe = new Frame { FirstThrow = 4, SecondThrow = 2 };

            Assert.Equal(frame.Score(nextframe), 16);
        }

    }
}
