using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        private DateTime _start;
        private bool _isRunning;
        public TimeSpan Duration { get; private set; }

        public Stopwatch()
        {
            _isRunning = false;
        }

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException();
        
            _start = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException();
         
            Duration = DateTime.Now - _start;
            _isRunning = false;
        }
    }
}
