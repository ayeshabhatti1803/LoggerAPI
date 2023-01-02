using System;
using System.Collections.Generic;
using logger.Infrastructure;
using logger.Models;
using logger.Helpers;
using System.Linq;
using logger.Response;
using System.Diagnostics;

namespace logger.Implementation
{
    /// <summary>
    /// This class implements an in-memory logging service.
    /// </summary>
    public class MemoryLogger : ILogger
    {

        private static List<LogEntry> _logs;

        static MemoryLogger()
        {
            _logs = new List<LogEntry>();
        }
        
        /// <summary>
        /// Add a log entry.
        /// </summary>
        /// <param name="timestamp">Milliseconds since epoch</param>
        /// <param name="severity">Severity of the event, using the Severity enum</param>
        /// <param name="message">Free-form message of the event</param>
        public bool AddLog(long timestamp, Severity severity, string message)
        {
            if (timestamp < 1 || string.IsNullOrEmpty(message))
                throw new Exception($"Invalid Data, timestamp can't be less than 1 and message can't be null or empty");

            var logEntry = new LogEntry(timestamp, severity, message);

            _logs.Add(logEntry);

            return true;
        }

        /// <summary>
        /// Get the log entries of the given timestamp range.
        /// </summary>
        /// <param name="start">Start of the range, as milliseconds since epoch, inclusive</param>
        /// <param name="end">End of the range, exclusive</param>
        /// <returns>A flat list of all log entries within the range, ordered by timestamp</returns>
        public List<LogResponse> GetLogs(long start, long end)
        {
            if (start < 1 || end < 1)
                throw new Exception($"Start : {start} or End : {end} values are invalid");

            if (start > end)
                throw new Exception($"Start : {start} value must be less than End : {end} value");

            var result = _logs.Where(log => log.GetTimestamp() >= start && log.GetTimestamp() <= end).Select(x=>x.ToLogResponse()).ToList();

            return result;
        }

    }
}
