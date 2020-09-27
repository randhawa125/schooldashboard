using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ayush.Services
{
    public class MessageService: IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage mailMessage = new MailMessage();
            try
            {

                MailAddress fromAddress = new MailAddress("otp@upclass.in", "Upclass");
                smtpClient.Host = "smtp.zoho.in";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;

                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("otp@upclass.in", "26June2020#");
                mailMessage.From = fromAddress;
                mailMessage.To.Add(email);
                mailMessage.Subject = subject;
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = message;
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                //Exception Handling
            }
        }

        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}
