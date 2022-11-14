using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNet7
{
    public static class TestOrder
    {
        private static readonly Random random = new(420);
        private static int[] items = Enumerable.Range(1,100).Select(x => random.Next()).ToArray();

        public static void Order()
        {
            var ordered = items.OrderBy(x => x).ToArray();
            var orderedDesc = items.OrderByDescending(x => x).ToArray();

            //.net 7
            var ordered7 = items.Order().ToArray();
            var orderedDesc7 = items.OrderDescending().ToArray();


        }

        public static void Sort()
        {
            // Faster
            Array.Sort(items);
            //items.Sort(); for lists
        }

        public static void Span_Sort()
        {
            Span<int> items = Enumerable.Range(1, 100).Select(x => random.Next()).ToArray();
            items.Sort();
            //items.ToArray();
        }
    }
}
