using MailSender.ServiceApp;
using MailSender.ServiceApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace MailSender.Controllers
{
    [Route("api/[controller]")]
    public class EMailController : Controller
    {
        private readonly IEmailSender _emailSender;
        public EMailController(IEmailSender emailSender)
        {
             _emailSender= emailSender;
        }
        [HttpPost]
        public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
        {
            var result = await _emailSender.SendEmail(request.FromAddress, request.FromName, request.ToAddress, request.ToName, request.Subject, request.PlainTextContent, request.HtmlContent);
            if (result.IsSuccess)
            {
                return Ok(new { Message = result.Message });
            }
            else
            {
                return BadRequest(new { Error = result.Message });
            }
        }
    }
}
//