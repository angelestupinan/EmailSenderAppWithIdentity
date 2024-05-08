using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Net;
using System.Security.Claims;


namespace EmailSenderAppWithIdentity { 

    public class EmailSender : IEmailSender
    {
        private readonly IEmailService _emailService;

        public EmailSender(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            EmailMessageModel emailMessage = new(email,
            subject,
            htmlMessage);

            await _emailService.Send(emailMessage);
            //var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            //{
            //    Credentials = new NetworkCredential("d0d6dfb095b5fd", "9458f262ff121d"),
            //    EnableSsl = true
            //};
            //client.Send("HiYou@gmail.com", "havohih908@dxice.com", "Hello world", "testbody");
            //System.Console.WriteLine("Sent");
        }
    }
}
