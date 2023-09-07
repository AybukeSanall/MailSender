using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.ServiceApp.Model
{
    public class EmailSendResult
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }

    }
}
