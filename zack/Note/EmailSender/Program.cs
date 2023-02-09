// See https://aka.ms/new-console-template for more information


using ConfigService;
using LogService;
using MailService;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection  service = new ServiceCollection();
service.AddScoped<ISendEmailService, SendEmailService>();
//service.AddScoped<ILogProvider, LogProvider>();
service.AddLogService();
//service.AddScoped<IConfigService, ConfigServiceProvider>();
service.AddScoped(typeof(IConfigService),s => new IniConfigService {FilePath = "D:\\learn\\zack\\Note\\EmailSender\\Mail.ini" });
using (var sp = service.BuildServiceProvider())
{
    //第一个根对象只能使用 servicelocator
    var mailService =  sp.GetRequiredService<ISendEmailService>();
    mailService.SendEmail("daada");
}

