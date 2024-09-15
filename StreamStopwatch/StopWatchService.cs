using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace StreamStopwatch
{
    public class StopWatchService
    {
        private TimeSpan baseTime;
        private Stopwatch timer;
        public StopWatchService()
        {
            baseTime = TimeSpan.Zero;
            timer = new Stopwatch();
        }
        public bool TimerEnabled
        {
            get
            {
                return timer.IsRunning;
            }
        }
        public void StartTimer()
        {
            timer.Start();
        }

        public void StopTimer()
        {
            timer.Stop();
        }

        public void ResetTimer()
        {
            timer.Reset();
        }
        public TimeSpan GetTime()
        {
            return timer.Elapsed.Add(baseTime);
        }
        public void SetTime(TimeSpan time)
        {
            baseTime = time;
        }
    }
}
