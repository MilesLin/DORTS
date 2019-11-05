using System.Configuration;
using System.Net.Mail;

namespace Mailing.Lib
{
    public class MailSender
    {
        public void SendMail(string recipients, string subject, string body)
        {
            string smtpServer = ConfigurationManager.AppSettings.Get("SmtpServer");
            string smtpAccount = ConfigurationManager.AppSettings.Get("SmtpAccount");
            string smtpPassword = ConfigurationManager.AppSettings.Get("SmtpPassword");
            string mailSender = ConfigurationManager.AppSettings.Get("MailSender"); // 這個可以設定成 virtual

            using (SmtpClient client = new SmtpClient(smtpServer))
            {
                client.Credentials = new System.Net.NetworkCredential(smtpAccount, smtpPassword);

                client.Send(mailSender, recipients, subject, body);
            }
        }
        ~MailSender()
        {
            System.Console.WriteLine("回收");
        }
    }
}