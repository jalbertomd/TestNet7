using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;

namespace TestNet7.CLI
{
    internal class TestCliWrap
    {
        public void Run() 
        {
            Cli.Wrap("File")
                //.WithArguments(new[]
                //{
                //    "P1",
                //    "P2",
                //    "P3"
                //})
                .WithArguments(args => args
                    .Add("P1")
                    .Add("P2")
                    .Add("P3")
                )
                .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine))
                .ExecuteBufferedAsync();
        }
    }
}
