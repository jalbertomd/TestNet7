﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNet7.Loop
{
    public static class Extensions
    {
        public static CustomIntEnumerator GetEnumerator(this Range range)
        {
            return new CustomIntEnumerator(range);
        }

        public static CustomIntEnumerator GetEnumerator(this int number)
        {
            return new CustomIntEnumerator(new Range(0, number));
        }
    }

    public ref struct CustomIntEnumerator
    {
        private int _current;
        private readonly int _end;

        public CustomIntEnumerator(Range range)
        {
            if (range.End.IsFromEnd)
            {
                throw new NotSupportedException();
            }

            _current = range.Start.Value - 1;
            _end = range.End.Value;
        }

        public int Current => _current;

        public bool MoveNext()
        {
            _current++;
            return _current <= _end;
        }
    }
}
