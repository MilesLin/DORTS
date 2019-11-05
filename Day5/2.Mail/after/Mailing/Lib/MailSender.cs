using System.Collections.Generic;
using System.Configuration;
using System.Net.Mail;

namespace Mailing.Lib
{
    public abstract class MailSender
    {
        protected abstract string GetBody();
        protected abstract string GetSubject();
        protected abstract List<string> GetRecipients();
        protected virtual string GetSenderName()
        {
            return "dorts-test@abc.com";
        }

        public void SendMail()
        {
            string smtpServer = ConfigurationManager.AppSettings.Get("SmtpServer");
            string smtpAccount = ConfigurationManager.AppSettings.Get("SmtpAccount");
            string smtpPassword = ConfigurationManager.AppSettings.Get("SmtpPassword");

            string mailSender = GetSenderName();
            string recipients = string.Join(",", GetRecipients());
            string subject = GetSubject();
            string body = GetBody();

            using (SmtpClient client = new SmtpClient(smtpServer))
            {
                client.Credentials = new System.Net.NetworkCredential(smtpAccount, smtpPassword);

                client.Send(mailSender, recipients, subject, body);
            }
        }
    }
}