using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;
        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("StopWatch is already running");
            _startTime = DateTime.Now;
            _running = true;
        }
        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("StopWatch is not Running");
            _endTime = DateTime.Now;
            _running = false;

        }
        public TimeSpan GetInterval()
        {
            return _startTime - _endTime;
        }
    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            for (int i = 0; i < 2; i++)
            {
                stopwatch.Start();
                Thread.Sleep(1000);
                stopwatch.Stop();
                Console.WriteLine("duration :" + stopwatch.GetInterval());
                Console.WriteLine("press enter to run the stopwatch one more time");
                Console.ReadLine();
            }
        }
    }
}
