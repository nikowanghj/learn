using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailService
{
    public interface ISendEmailService
    {
        void SendEmail(string email);
    }
}
