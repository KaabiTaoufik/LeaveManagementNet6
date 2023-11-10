using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.web.Services
{
    public class EmailSender : IEmailSender
    {
        private string smtpMail;
        private string smtpHost;
        private int smtpPort;
        public EmailSender() { }
        public EmailSender(string host, int port, string mail) {
            this.smtpHost = host;
            this.smtpPort = port;
            this.smtpMail = mail;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage 
            { 
                From = new MailAddress(smtpMail),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(smtpHost, smtpPort);
            client.Send(message);

            return Task.CompletedTask;
        }
    }
}
