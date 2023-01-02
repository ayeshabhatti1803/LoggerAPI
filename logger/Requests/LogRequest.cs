using logger.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace logger.Requests
{
    public class logRequest
    {
        public long TimeStamp { get; set; }
        public Severity Severity { get; set; }
        public string Message { get; set; }
    }
}
