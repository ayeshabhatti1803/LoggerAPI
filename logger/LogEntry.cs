using System;

namespace logger
{
    /// <summary>
    /// An object that stores a single log entry.
    /// </summary>
    // (Please don't change this class in ways that would make our unit tests fail.)
    public class LogEntry
    {
        private long timestamp;
        private Logger.Severity severity;
        private String message;

        public LogEntry(long timestamp, Logger.Severity severity, String message)
        {
            this.timestamp = timestamp;
            this.severity = severity;
            this.message = message;
        }

        public long GetTimestamp()
        {
            return timestamp;
        }

        public Logger.Severity GetSeverity()
        {
            return severity;
        }

        public String GetMessage()
        {
            return message;
        }
    }
}