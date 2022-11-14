using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInTests2
{
    public interface IDatetimeProvider
    {
        public DateTimeOffset Now { get; }
    }

    public class DatetimeProvider : IDatetimeProvider
    {
        public DateTimeOffset Now => DateTimeOffset.Now;
    }
}
