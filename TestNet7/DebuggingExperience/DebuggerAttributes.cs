using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNet7.DebuggingExperience
{
    internal class DebuggerAttributes
    {
    }

    public record SubPoint(int X, int Y);

    [DebuggerDisplay("X: {X}, Y: {Y}, Sum: {X+Y}")]
    //[DebuggerTypeProxy(typeof(PointProxy))]
    public class Point
    {
        public int X { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Y { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public SubPoint[] SubPoints { get; } = new []
        {
            new SubPoint(4, 20),
            new SubPoint(13, 37)
        };

        public Point(int x, int y)
        {
            X = x; 
            Y = y;
        }

        //[DebuggerHidden]
        [DebuggerStepThrough]
        public double DistanceTo(Point p)
        {
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }

        private class PointProxy
        {
            private readonly Point _point;
            public PointProxy(Point point)
            {
                _point = point;
            }

            public int A => _point.X;
            public int B => _point.Y;
        }
    }
}
