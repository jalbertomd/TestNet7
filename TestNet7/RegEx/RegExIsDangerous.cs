using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestNet7.RegExp
{
    internal class RegExIsDangerous
    {
        
        public void TestRegEx()
        {
            var regex = new Regex(@"", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.NonBacktracking,
                TimeSpan.FromMilliseconds(10));

            var sw = Stopwatch.StartNew();

            try
            {
                var matched = regex.IsMatch("");
                Debug.WriteLine($"Matched {matched} in {sw.ElapsedMilliseconds}");
            }
            catch (RegexMatchTimeoutException ex)
            {

                throw;
            }

            //sw.Stop();
        }
    }
}
