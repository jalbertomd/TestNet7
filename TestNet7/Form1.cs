using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using TestNet7.AwaitAnything;
using TestNet7.ExplaningSpan;

namespace TestNet7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStrings_Click(object sender, EventArgs e)
        {
            //TestRegex(/*lang=regex*/"");
            TestStringSyntax.TestRegex(@"^a\d+|b\w*");
            TestStringSyntax.TestDateTime(DateTime.Now,"d");
            TestStringSyntax.TestJson("""
                [{
                    "name":"Juan",
                    "age": 42
                }]
                """);
        }

        private void btnSpan_Click(object sender, EventArgs e)
        {
            var res = ExpSpan.DateWithStringAndSubstring();

            var year = ExpSpan.YearAsText();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            BetterLoop.Loop();
        }

        private async Task btnAwait_ClickAsync(object sender, EventArgs e)
        {
            var sw = Stopwatch.StartNew();

            await Delay.Seconds(2);
            await TimeSpan.FromSeconds(2);
            await 2.Seconds();
            await 2;

            Debug.WriteLine($"Waited for {sw.ElapsedMilliseconds} ms");
        }
    }
}