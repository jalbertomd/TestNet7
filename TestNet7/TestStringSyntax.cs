using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNet7
{
    public static class TestStringSyntax
    {
        public static void TestRegex([StringSyntax(StringSyntaxAttribute.Regex)] string regex)
        {

        }

        public static void TestDateTime(DateTime date, [StringSyntax(StringSyntaxAttribute.DateTimeFormat)] string format)
        {

        }

        public static void TestJson([StringSyntax(StringSyntaxAttribute.Json)] string json)
        {

        }
    }
}
