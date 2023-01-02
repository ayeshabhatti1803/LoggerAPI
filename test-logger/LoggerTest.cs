using System;
using Xunit;
using logger.Implementation;
using logger.Infrastructure;
using logger.Helpers;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace test_logger
{
    public class LoggerTest
    {
        private ILogger logger;

        public LoggerTest()
        {
            logger = new MemoryLogger();
        }

        [Fact]
        public void TestEntriesNotNull()
        {
            var start = 0;
            var end = 0;
            var ex = Assert.Throws<Exception>(() => logger.GetLogs(start, end));
            Assert.Equal($"Start : {start} or End : {end} values are invalid", ex.Message);

        }


        [Fact]
        public void GetLog_EndValueIsSmallThanStart_Null()
        {
            var start = 5;
            var end = 3;
            var ex = Assert.Throws<Exception>(() => logger.GetLogs(start, end));
            Assert.Equal($"Start : {start} value must be less than End : {end} value", ex.Message);
        }



        [Fact]
        public void AddLog_ValidLogEntry_ShouldAdd()
        {
            var timestamp = DateTime.Now.Millisecond;
            var message = "This is test log";
            var severity = Severity.INFO;

            var response = logger.AddLog(timestamp, severity, message);

            Assert.True(response);
        }


        [Fact]
        public void AddLog_EmptyMessage_ShouldNotAdd()
        {
            var timestamp = DateTime.Now.Millisecond;
            var message = string.Empty;
            var severity = Severity.INFO;

            var ex = Assert.Throws<Exception>(() => logger.AddLog(timestamp, severity, message));
            Assert.Equal("Invalid Data, timestamp can't be less than 1 and message can't be null or empty", ex.Message);
            
        }

        [Fact]
        public void AddLog_InvalidTimeStamp_ShouldNotAdd()
        {
            var timestamp = 0;
            var message = "this is test message";
            var severity = Severity.INFO;

            var ex = Assert.Throws<Exception>(() => logger.AddLog(timestamp, severity, message));
            Assert.Equal("Invalid Data, timestamp can't be less than 1 and message can't be null or empty", ex.Message);

        }
    }
}
