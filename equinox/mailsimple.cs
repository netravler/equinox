using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
//using SMTP;


namespace equinox
{
    public partial class mailsimple : Form
    {
        public mailsimple()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            /*
            MailMessage message = new MailMessage();
            message.From = new MailAddress("pheintz@hotmail.com");
            message.To.Add(new MailAddress("pheintz@jackhenry.com"));
            
            message.Subject = "baseline test";

            message.Body = "Test";
            SmtpClient client = new SmtpClient();

            client.Send(message);
            */
            
            //SMTP.SmtpDirect.SmtpServer = txtSmtpServer.Text;
            SMTP.SmtpDirect.SmtpServer = "newmail.jackhenry.com";

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.Body = rtbBody.Text;
            //msg.From = tbFrom.Text;
            msg.To.Add(tbTo.Text);
            msg.Subject = tbSubject.Text;

            msg.Headers.Add("Reply-to", tbFrom.Text);
            
            /* no attachments at this time:)
            if (strAttachmentFile != null)
            {
                MailAttachment myAttachment = new MailAttachment(strAttachmentFile);


                msg.Attachments.Add(myAttachment);

            }
            */

            if (SMTP.SmtpDirect.Send(msg))
            {
                MessageBox.Show("Sent OK");
            }
            else
            {
                MessageBox.Show("Something BAD Happened!");
            }
             
        }
    }
}
