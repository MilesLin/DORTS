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
            MailSender helloMail = new HelloMail();
            helloMail.SendMail();

            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}
