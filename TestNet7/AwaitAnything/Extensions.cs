using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestNet7.AwaitAnything
{
    public static class Extensions
    {
        public static TaskAwaiter GetAwaiter(this Delay delay)
        {
            return Task.Delay(delay.TimeSpan).GetAwaiter();
        }

        public static TaskAwaiter GetAwaiter(this TimeSpan timeSpan)
        {
            return Task.Delay(timeSpan).GetAwaiter();
        }

        public static TimeSpan Seconds(this int seconds)
        {
            return TimeSpan.FromSeconds(seconds);
        }

        public static TaskAwaiter GetAwaiter(this int seconds)
        {
            return Task.Delay(TimeSpan.FromSeconds(seconds)).GetAwaiter();
        }
    }
}
