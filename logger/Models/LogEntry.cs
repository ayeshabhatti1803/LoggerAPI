using System;
using logger.Implementation;
using logger.Helpers;

namespace logger.Models
{
    /// <summary>
    /// An object that stores a single log entry.
    /// </summary>
    // (Please don't change this class in ways that would make our unit tests fail.)
    public class LogEntry
    {
        private long timestamp;
        private Severity severity;
        private string message;

        public LogEntry(long timestamp, Severity severity, string message)
        {
            this.timestamp = timestamp;
            this.severity = severity;
            this.message = message;
        }

        public long GetTimestamp()
        {
            return timestamp;
        }

        public Severity GetSeverity()
        {
            return severity;
        }

        public string GetMessage()
        {
            return message;
        }
    }
}