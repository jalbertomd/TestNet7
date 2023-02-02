using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestNet7.AwaitAnything
{
    public class Delay
    {
        public TimeSpan TimeSpan { get; }

        private Delay(TimeSpan timeSpan)
        {
            TimeSpan = timeSpan;
        }

        public static Delay Seconds(int seconds)
        {
            return new Delay(TimeSpan.FromSeconds(seconds)); 
        }

        //public TaskAwaiter GetAwaiter()
        //{
        //    return Task.Delay(_timeSpan).GetAwaiter();
        //}
    }
}
