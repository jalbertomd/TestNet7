﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeInTests2;

namespace TestNet7.Datetime
{
    public class GreeterService
    {
        private readonly IDatetimeProvider _dateTimeProvider;
        public GreeterService(IDatetimeProvider dateTimeProvider) 
        { 
            _dateTimeProvider = dateTimeProvider;
        }

        public string GenerateGreetText()
        {
            var dateTimeNow = _dateTimeProvider.Now;

            return dateTimeNow.Hour switch
            {
                >= 5 and <12 => "Good morning",
                >= 12 and <18 => "Good afternoon",
                _ => "Good evening"
            };
        }
    }
}
