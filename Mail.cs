using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Text;

using EASendMail;

namespace ptWeb.Controllers
{
    public class Mail
    {
        public void SendMail(string subject, string message, string email)
        {
            try
            {
                //these settings for HOTMAIL 
                
                SmtpMail oMail = new SmtpMail("TryIt");

                // Set sender email address, please change it to yours
                oMail.From = "YOURMAİL@hotmail.com";

                // Set recipient email address, please change it to yours
                oMail.To = email;

                // Set email subject
                oMail.Subject = subject;

                // Set email body
                oMail.TextBody = message;

                // Your SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.office365.com");

                oServer.User = "YOURMAİL@hotmail.com";
                oServer.Password = "YOURPASSWORD";
                oServer.Port = 587;

                // detect TLS connection automatically
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);

            }
            catch (Exception ep)
            {
                  
            }
        }
    }
}
