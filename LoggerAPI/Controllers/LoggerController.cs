using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using logger.Infrastructure;
using System;
using logger.Requests;
using Microsoft.AspNetCore.Identity;

namespace LoggerAPI.Controllers
{
    [ApiController]
    public class LoggerController : ControllerBase
    {
        private ILogger _logger;
        public LoggerController(ILogger logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        [Route("/api/v1/log/{start}/{end}")]
        public IActionResult GetLogs(long start,long end)
        {
            return Ok(_logger.GetLogs(start, end));
        }

        [HttpPost]
        [Route("/api/v1/log")]
        public IActionResult Addlogs(logRequest logRequest)
        {
            return  Ok(_logger.AddLog(logRequest.TimeStamp, logRequest.Severity, logRequest.Message));
        }
    }
}
