using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestNet7
{
    public static class TestIteration
    {
        private static readonly Random random = new (80085);
        
        public static int Size { get; set; }
        //[Params(100, 100_000, 1_000_000)]
        private static List<int> _items;

        public  static void Setup()
        {
            _items = Enumerable.Range(1,Size).Select(x => random.Next()).ToList();
        }

        public static void For() 
        {
            for (int i = 0; i < _items.Count; i++)
            {
                var item = _items[i];
            }
        }

        public static void Foreach()
        {
            foreach(var item in _items)
            {
                
            }
        }

        public static void Foreach_Linq()
        {
            _items.ForEach(item => { });
        }

        public static void Parallel_Foreach()
        {
            Parallel.ForEach(_items, item => { });
        }

        public static void Parallel_Linq()
        {
            _items.AsParallel().ForAll(item => { }); 
        }

        // Use span when the collection is not being modified

        public static void Foreach_Span()
        {
            foreach(var item in CollectionsMarshal.AsSpan(_items))
            {

            }
        }

        public static void For_Span()
        {
            var asSpan = CollectionsMarshal.AsSpan(_items);

            for (int i = 0; i < asSpan.Length; i++)
            {
                var item = asSpan[i];
            }
        }
    }
}
