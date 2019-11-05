using System.Collections.Generic;

namespace Mailing.Lib
{
    public class HelloMail : MailSender
    {
        protected override string GetBody()
        {
            return "Hello content";
        }

        protected override List<string> GetRecipients()
        {
            var result = new List<string>
            {
                "miles@miniasp.com"
            };

            return result;
        }

        protected override string GetSubject()
        {
            return "Test Subject";
        }
    }
}