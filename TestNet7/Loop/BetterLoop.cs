using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNet7.Loop;

namespace TestNet7
{
    public class BetterLoop
    {
        public static void Loop()
        {
            foreach (var i in 0..10)
            {
                Debug.WriteLine(i);
            }
        }        
    }

    
}
