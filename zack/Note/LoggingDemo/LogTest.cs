using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingDemo
{
    public class LogTest
    {
        private readonly ILogger<LogTest> _logger;
        public LogTest(ILogger<LogTest> logger) { 
         _logger= logger;
        }
        public void Test()
        {
            _logger.LogDebug("开始执行数据库同步");
            _logger.LogError("同步数数据库错误！");
        }
    }
}
