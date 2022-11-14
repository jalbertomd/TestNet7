using System.Diagnostics.CodeAnalysis;
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
    }
}