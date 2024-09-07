using ClockClass;

namespace ClockTest;

[TestFixture]
public class CounterTest
{
    private Counter _counter;

    [SetUp]
    public void Setup()
    {
        _counter = new Counter("Counter name:");
    }

    [Test]
    public void TestCounterStart()
    {
        Assert.IsTrue(_counter.Ticks == 0);
    }

    [Test]
    public void TestCounterIncreases()
    {
        _counter.Increment();
        Assert.IsTrue(_counter.Ticks == 1);
    }

    [Test]
    public void TestCounterMultipleTimesIncreases()
    {
        int MultipleCount = 2;
        for (int i = 0; i < MultipleCount; i++)
        {
            _counter.Increment();
        }

        Assert.IsTrue(_counter.Ticks == MultipleCount);
    }

    [Test]
    public void TestCounterReset()
    {
        _counter.Increment();
        _counter.Reset();

        Assert.IsTrue(_counter.Ticks == 0);
    }
}
