using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------
namespace ChainOfResponsibility
{
    class Error111Class : Handler
    {
        public override void Logging(int ErrorLvl, string ErrorText)
        {
            MailAddress from = new MailAddress("ErrorMail@info.com", "ChainOfResponsibility");

            MailAddress to = new MailAddress("maxali946@gmail.com");

            MailMessage mail = new MailMessage(from, to);

            mail.Subject = "Error";

            mail.Body = $"<h2>{ErrorText}</h2>";

            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            if (ErrorLvl == 3)
                smtp.Send(mail);
            else
                Successor.Logging(ErrorLvl, ErrorText);
        }
    }
}
//----------------------------------------------