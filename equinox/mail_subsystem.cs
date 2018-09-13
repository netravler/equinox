using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Configuration;

namespace equinox
{
    public class mail_subsystem
    {
    private string to_address;
    private string message;
    private string from_address;
    private string subject;
    
    public mail_subsystem(){}

    public mail_subsystem(string to_address, string message, string from_address, string subject)
    {
        this.To_Address = to_address;
        this.Message = message;
        this.From_Address = from_address;
        this.Subject = subject;

        MailMessage mail = new MailMessage();
        mail.To.Add(to_address);
        mail.From = new MailAddress(from_address);
        mail.Subject = subject;
        string MessageOut = message;
        mail.Body = MessageOut;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = ConfigurationSettings.AppSettings["SMTP"];
        //smtp.Send(mail);
        //return "";
    }


        public string To_Address
        {
            get
            {
                return to_address;
            }
            set
            {
                to_address = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }

        public string From_Address
        {
            get
            {
                return from_address;
            }
            set
            {
                from_address = value;
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }
    }
}
