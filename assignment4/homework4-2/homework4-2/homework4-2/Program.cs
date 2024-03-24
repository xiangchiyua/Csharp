using System.Data;
using System.Runtime.CompilerServices;
using System;

namespace homework4_2
{
    /*
     使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
     在闹钟走时时或者响铃时，在控制台显示提示信息。
     */
    public delegate void AlarmHandler(object sender, TimeEventArgs args);
    public delegate void TickHandler(object sender, System.DateTime args);
    public class TimeEventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
    }
    public class Clock
    {
        private int hour, minute;
        private TimeEventArgs time;
        public event AlarmHandler onAlarm;
        public event TickHandler onTick;
        public void Alarm(object sender, TimeEventArgs time)
        {
            Console.WriteLine($"您设定的时间到啦！");
        }
        public void Tick(object sender,System.DateTime time)
        {
            Console.WriteLine("滴答");
        }
        public Clock(int hour, int minute)
        {
            this.hour = hour;this.minute = minute;
            onTick += Tick;
            TimeEventArgs args = new TimeEventArgs() { Hour = hour, Minute = minute };
            onAlarm += Alarm;
        }
        public void Start()
        {
            while(true)
            {
                System.DateTime now= DateTime.Now;
                onTick(this, now);
                if (now.Hour == hour && now.Minute == minute)
                {
                    onAlarm(this,time);
                }
                System.Threading.Thread.Sleep(500);
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock(16,56);
            clock.Start();
        }
    }
}
