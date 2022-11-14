using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNet7.ExplaningSpan
{
    public class ExpSpan
    {
        private static readonly string _dateAsText = "08 07 2022";

        public static (int day, int month, int year) DateWithStringAndSubstring()
        {
            var dayAsText = _dateAsText[..2];
            var monthAsText = _dateAsText.Substring(3, 2);
            var yearAsText = _dateAsText[6..];

            var day = int.Parse(dayAsText);
            var month = int.Parse(monthAsText);
            var year = int.Parse(yearAsText);

            return (day, month, year);
        }

        public static (int day, int month, int year) DateWithStringAndSpan()
        {
            ReadOnlySpan<char> dateAsSpan = _dateAsText;

            var dayAsText = dateAsSpan[..2];
            var monthAsText = dateAsSpan.Slice(3, 2);
            var yearAsText = dateAsSpan[6..];

            var day = int.Parse(dayAsText);
            var month = int.Parse(monthAsText);
            var year = int.Parse(yearAsText);

            return (day, month, year);
        }

        public static ReadOnlySpan<char> YearAsText()
        {
            ReadOnlySpan<char> dateAsSpan = _dateAsText;

            var yearAsText = dateAsSpan[6..];

            return yearAsText;
        }
    }
}
