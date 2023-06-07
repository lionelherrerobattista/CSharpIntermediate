using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        public TimeSpan Duration { get; private set; }
        private DateTime _start;
        private bool _isRunning;

        public Stopwatch()
        {
            _isRunning = false;
        }

        public void Start()
        {
            if (!this._isRunning)
            {
                this._start = DateTime.Now;
                this._isRunning = true;
            }
            else
            {
                throw new InvalidOperationException();
            }

        }
        public void Stop()
        {
            this.Duration = DateTime.Now - this._start;
            this._isRunning = false;
        }
    }
}
