using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace CommingSoon.Models
{
    public class EmailService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            // Plug in your email service here to send an email.
            // await configSendGridasync(message);

            try
            {
                MailMessage mail = new MailMessage();
                // Replace smtp_username with your Amazon SES SMTP user name.
                String SMTP_USERNAME = ConfigurationManager.AppSettings["SMTP_Username"];

                // Replace smtp_password with your Amazon SES SMTP user name.
                String SMTP_PASSWORD = ConfigurationManager.AppSettings["SMTP_Password"];

                String HOST = ConfigurationManager.AppSettings["AWSHost"];
                SmtpClient SmtpServer = new SmtpClient(HOST);

                mail.IsBodyHtml = true;
                mail.From = new MailAddress("platform@trendiver.com", "Trendiver Livestreaming & VOD");
                mail.To.Add(message.Destination);
                mail.Subject = message.Subject;
                mail.Body = message.Body;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
            catch (Exception ex)
            {
            }
        }

    }
}