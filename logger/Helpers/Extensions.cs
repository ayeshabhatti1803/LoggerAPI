using logger.Models;
using logger.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logger.Helpers
{
    public static class Extensions
    {
        public static LogResponse ToLogResponse(this LogEntry logEntry)
        {
            var logResponse = new LogResponse();
            logResponse.TimeStamp = logEntry.GetTimestamp();
            logResponse.Message = logEntry.GetMessage();
            logResponse.Severity = logEntry.GetSeverity();
            return logResponse;
        }

    }
}
