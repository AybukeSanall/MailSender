using MailSender.ServiceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.ServiceApp
{
    public interface IEmailSender
    {
        Task <EmailSendResult> SendEmail(string fromAddress,string fromName, string toAddress,string toName, string subject, string plainTextContent, string htmlContent);
    }
}
