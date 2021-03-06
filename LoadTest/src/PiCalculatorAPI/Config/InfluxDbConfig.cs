﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiCalculatorAPI.Config
{
    public class InfluxDbConfig
    {
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DatabaseConfig DatabaseInfo { get; set; }
    }
}
