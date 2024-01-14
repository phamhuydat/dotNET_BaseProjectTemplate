using App.Web.Common.Mailer;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class SendMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromServices] AppMailConfiguration mailconf, string MailTo, string subject, string content)
        {
            AppMailer appMailer = new AppMailer(mailconf);
            appMailer.Sender = new AppMailSender
            {
                Content = content,
                Subject = subject,
            };
            appMailer.Reciver = new AppMailReciver
            {
                Email = MailTo
            };
            appMailer.Send();
            return RedirectToAction(nameof(Index));
        }
    }
}
