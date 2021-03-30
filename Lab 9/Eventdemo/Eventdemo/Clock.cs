using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eventdemo
{
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;
        private object timeinfo;

        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeinfo);
        public event SecondChangeHandler SecondChanged;

        public void Run()
        {
            for(; ; )
            {
                Thread.Sleep(100);
                System.DateTime dt = System.DateTime.Now;
                if (dt.Second != second)
                {
                    TimeInfoEventArgs timeinfo = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
                    if (SecondChanged != null)
                    {
                        SecondChanged(this,timeinfo);
                    }

                }
                this.second = dt.Second;
                this.minute = dt.Minute;
                this.hour = dt.Hour;
            }
        }

    }
}
