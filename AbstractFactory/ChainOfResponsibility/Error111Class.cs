﻿using System;
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
        public override void Logging(MyException exception)
        {
            MailAddress from = new MailAddress("ErrorMail@info.com", "ChainOfResponsibility");

            MailAddress to = new MailAddress("maxali946@gmail.com");

            MailMessage mail = new MailMessage(from, to);

            mail.Subject = "Error";

            mail.Body = $"<h2>{exception.Message}</h2>";

            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.EnableSsl = true;

            //smtp.Send(mail);

            Console.WriteLine("Mail Send in address: maxali946@gmail.com");
        }
    }
}
//----------------------------------------------