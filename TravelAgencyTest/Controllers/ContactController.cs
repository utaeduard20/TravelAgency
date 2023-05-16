using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Controllers
{
    public class ContactController : Controller
    {
        private EmailAddress FromAndToEmailAddress;
        private IEmailService EmailService;

        public ContactController(EmailAddress _fromAddress,
            IEmailService _emailService)
        {
            FromAndToEmailAddress = _fromAddress;
            EmailService = _emailService;
        }

        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                EmailMessage msgToSend = new EmailMessage
                {
                    FromAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    ToAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    Content = $"Here is your message: Name: {model.Name}, " +
                        $"Email: {model.Email}, Message: {model.Message}",
                    Subject = "Contact Page - Travelly-Tour"
                };

                EmailService.Send(msgToSend);
                return RedirectToAction("Contact");
            }
            else
            {
                return Contact();
            }
        }

    }
}