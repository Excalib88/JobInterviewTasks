using ClockArrowsAngle;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ClockArrowsTests
    {
        private ClockArrows _clockArrows;

        [SetUp]
        public void Setup()
        {
            _clockArrows = new ClockArrows();
        }

        [Test]
        public void If12HoursAnd00Minutes_ShouldBe0()
        {
            var actualResult = _clockArrows.CalculateAngle(12, 0);

            Assert.AreEqual(0, actualResult);
        }

        [Test]
        public void If2HoursAnd05Minutes_ShouldBe330()
        {
            var actualResult = _clockArrows.CalculateAngle(2, 5);

            Assert.AreEqual(330, actualResult);
        }

        [Test]
        public void If6HoursAnd45Minutes_ShouldBe90()
        {
            var actualResult = _clockArrows.CalculateAngle(6, 45);

            Assert.AreEqual(90, actualResult);
        }

        [Test]
        public void If9HoursAnd15Minutes_ShouldBe180()
        {
            var actualResult = _clockArrows.CalculateAngle(9, 15);

            Assert.AreEqual(180, actualResult);
        }

        [Test]
        public void IfMinus2HoursAnd80Minutes_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => _clockArrows.CalculateAngle(-2, 80));
        }
    }
}