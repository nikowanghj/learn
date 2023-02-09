using ConfigService;
using LogService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailService
{
    public class SendEmailService:ISendEmailService
    {
        private readonly ILogProvider _logProvider;
        private readonly IConfigService _configService;
        public SendEmailService(
            ILogProvider logProvider,
            IConfigService configService
            ) { 
            _logProvider= logProvider;
            _configService= configService;
            }
        public void SendEmail(string email)
        {
            _logProvider.LogInfo("准备发送邮件");
            var url = _configService.GetValue("smtService");
            var account = _configService.GetValue("UserName");
            var pwd = _configService.GetValue("Password");
            Console.WriteLine("邮件服务地址：{0}，{1}，{2}",url,account,pwd);
            Console.WriteLine("成功发送邮件{0}",email);
            _logProvider.LogInfo("成功发送邮件");
        }
    }
}
