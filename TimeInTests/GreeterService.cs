using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNet7.Datetime
{
    public class GreeterService
    {
        public string GenerateGreetText()
        {
            var dateTimeNow = DateTimeOffset.Now;

            return dateTimeNow.Hour switch
            {
                >= 5 and <12 => "Good morning",
                >= 12 and <18 => "Good afternoon",
                _ => "Good evening"
            };
        }
    }
}
