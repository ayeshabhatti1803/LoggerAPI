using System;
using Xunit;
using logger;

namespace test_logger
{
    public class LoggerTest
    {
        private Logger logger;

        public LoggerTest()
        {
            logger = new Logger();
        }

        [Fact]
        public void TestEntriesNotNull()
        {
            Assert.NotNull(logger.Entries(0, 0));
        }
    }
}
