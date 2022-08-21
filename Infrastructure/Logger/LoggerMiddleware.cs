using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logger
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerManager _logger;
        public LoggerMiddleware(RequestDelegate next, ILoggerManager logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                _logger.LogInfo($"Method: {context.Request.Method}, Routing: {context.Request.Path}");
                await _next(context);
                _logger.LogInfo($"StatusCode: {context.Response.StatusCode}");
            }
            catch (Exception e)
            {
                _logger.LogError($": {e.Message}");
            }
        }
    }
}
