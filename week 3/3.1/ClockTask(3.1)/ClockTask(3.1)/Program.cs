using ClockClass;

namespace ClockClass;

class Program
{ 
    static void Main(string[] args)
    {
        Clock clock = new Clock();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Clock Time: " + clock.DisplayTime());

            clock.Tick();
            Thread.Sleep(1);
        }
    }
}

