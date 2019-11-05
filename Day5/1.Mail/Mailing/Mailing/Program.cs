using Mailing.Lib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mailing
{
    class Program
    {
        static void Main(string[] args)
        {
            var mail = new MailSender();

            string recipients = "def@miniasp.com,abc@abc.com";
            string subject = "test course";
            string body = "hi there";

            mail.SendMail(recipients, subject, body);

            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}
