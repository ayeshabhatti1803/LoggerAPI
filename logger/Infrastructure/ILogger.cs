using logger.Models;
using System.Collections.Generic;
using logger.Helpers;
using logger.Response;

namespace logger.Infrastructure
{
    public interface ILogger
    {
        bool AddLog(long timestamp, Severity severity, string message);
        List<LogResponse> GetLogs(long start, long end);
    }
}
