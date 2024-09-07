using System;
using ClockClass;
namespace ClockTest
{
    [TestFixture]
    public class ClockTest
	{
		private Clock _clock;

		[SetUp]
		public void SetUp()
		{
			_clock = new Clock();
		}

        [Test]
        public void TestClockStart()
        {
            Assert.IsTrue(_clock.DisplayTime() == "00:00:00");
        }

        [Test]
        public void TestClockSecond()
        {
            _clock.Tick();
            Assert.IsTrue(_clock.DisplayTime() == "00:00:01");
        }

        [Test]
        public void TestClockMinute()
        {
            for (int i = 0; i < 60; i++)
            {
                _clock.Tick();
            }    
            Assert.IsTrue(_clock.DisplayTime() == "00:01:00");
        }

        [Test]
        public void TestClockHour()
        {
            for (int i = 0; i < 3600; i++)
            {
                _clock.Tick();
            }
            Assert.IsTrue(_clock.DisplayTime() == "01:00:00");
        }

        [Test]
        public void TestClockDay()
        {
            for (int i = 0; i < 86400; i++)
            {
                _clock.Tick();
            }
            Assert.IsTrue(_clock.DisplayTime() == "00:00:00");
        }

        [Test]
        public void TestClockReset()
        {
            for (int i = 0; i < 3661; i++)
            {
                _clock.Tick();
            }
            Assert.IsTrue(_clock.DisplayTime() == "01:01:01");

            _clock.Reset();
            Assert.IsTrue(_clock.DisplayTime() == "00:00:00");

        }
    }
}

