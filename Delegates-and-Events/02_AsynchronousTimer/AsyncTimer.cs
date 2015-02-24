using System;
using System.Timers;

namespace _02_AsynchronousTimer
{
    class AsyncTimer
    {
        private int ticks;
        private int tickNumber = 0;
        private System.Timers.Timer timer;
        private System.Action method;

        public AsyncTimer(Action method, int ticks, int t)
        {
            this.ticks = ticks;
            this.timer = new System.Timers.Timer(t);
            this.method = method;

            this.timer.Elapsed += new ElapsedEventHandler(Action);

            this.timer.Enabled = true;
        }

        private void Action(object source, ElapsedEventArgs e)
        {
            this.tickNumber++;
            method();

            if (this.tickNumber == this.ticks)
            {
                this.timer.Enabled = false; 
            }
        }
    }
} 
