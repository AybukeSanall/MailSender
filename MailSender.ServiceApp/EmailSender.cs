using MailSender.ServiceApp.Model;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.ServiceApp
{
    public class EmailSender : IEmailSender
    {
        private readonly IOptions<AppSettings> _appSettings;
        public EmailSender(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }
        public async Task<EmailSendResult> SendEmail(string fromAddress,string fromName, string toAddress,string toName, string subject, string plainTextContent, string htmlContent)
        {

            var result = new EmailSendResult();
            try
            {
                var apiKey = _appSettings.Value.SendGridApiKey;
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress(fromAddress, fromName);
                var to = new EmailAddress(toAddress, toName);
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);
                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted)
                {
                    result.IsSuccess = true;
                    result.Message = "Mailiniz başarıyla gönderildi";
                }
                else
                {
                    result.IsSuccess = false;
                    result.Message = "Mail gönderme sırasında bir hata oluştu";
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = "Mail gönderme sırasında bir hata oluştu";
            }

            return result;
        }
    }
}
