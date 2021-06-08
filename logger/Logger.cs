using System;
using System.Collections.Generic;

namespace logger
{
    /// <summary>
    /// This class implements an in-memory logging service.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Add a log entry.
        /// </summary>
        /// <param name="timestamp">Milliseconds since epoch</param>
        /// <param name="severity">Severity of the event, using the Severity enum</param>
        /// <param name="message">Free-form message of the event</param>
        public void Log(long timestamp, Severity severity, String message)
        {
            // TODO
        }

        /// <summary>
        /// Get the log entries of the given timestamp range.
        /// </summary>
        /// <param name="start">Start of the range, as milliseconds since epoch, inclusive</param>
        /// <param name="end">End of the range, exclusive</param>
        /// <returns>A flat list of all log entries within the range, ordered by timestamp</returns>
        public List<LogEntry> Entries(long start, long end)
        {
            return null;
        }

        /// <summary>
        /// Enumeration for the severity of a log entry.
        /// </summary>
        public enum Severity {
            DEBUG,
            INFO,
            WARN,
            ERROR
        }
    }
}
