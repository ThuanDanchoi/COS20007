using System;
namespace ClockClass
{
	public class Clock
	{
		private Counter _seconds;
		private Counter _minutes;
		private Counter _hours;


		public Clock()
		{
			_seconds = new Counter("seconds");
			_minutes = new Counter("minutes");
			_hours = new Counter("hours");
		}

		public void Tick()
		{
			_seconds.Increment();

			if (_seconds.Ticks == 60)
			{
				_seconds.Reset();
				_minutes.Increment();

				if (_minutes.Ticks == 60)
				{
					_minutes.Reset();
					_hours.Increment();

					if (_hours.Ticks == 24)
					{
						_hours.Reset();
					}
				}
			}
		}

		public void Reset()
		{
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }

		public string DisplayTime()
		{
            return string.Format("{0:D2}:{1:D2}:{2:D2}", _hours.Ticks, _minutes.Ticks, _seconds.Ticks);

        }
    }
}

