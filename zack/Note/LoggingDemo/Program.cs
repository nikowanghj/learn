
using LoggingDemo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

ServiceCollection service= new ServiceCollection();
//把日志加到控制台
service.AddLogging(logBuilder => {
   logBuilder.AddConsole();
   logBuilder.SetMinimumLevel(LogLevel.Debug);
   //使用nlog记录到文件
   logBuilder.AddNLog();
});
service.AddScoped(typeof(LogTest));
using (var sp = service.BuildServiceProvider())
{
    var logTest = sp.GetService<LogTest>();
    logTest?.Test();
}