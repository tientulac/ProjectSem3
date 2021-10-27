using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public static class StaticMail
    {
        public static ResponseBase SendEmail(String ToEmail, String Subject, String Body, String Password, String FromEmail, List<string> BCC)
        {
            ResponseBase res = new ResponseBase();
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.UseDefaultCredentials = false;
            mail.From = new MailAddress(FromEmail);
            mail.To.Add(ToEmail);
            mail.Subject = Subject;
            mail.Body = Body;
            foreach (var item in BCC)
            {
                mail.Bcc.Add(item);
            }
            mail.IsBodyHtml = true;
            SmtpServer.EnableSsl = true;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(FromEmail, Password);
            try
            {
                // Cần cho phép các ứng dụng kém an toàn truy cập vào tài khoản email
                // Cho phép tại: https://myaccount.google.com/lesssecureapps
                SmtpServer.Send(mail);
                res.Status = StatusID.Success;
            }

            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return res;
        }

        public static ResponseBase SendEmailDetail(String Subject, String Body, String Password, String FromEmail, string ToEmail)
        {
            ResponseBase res = new ResponseBase();
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.UseDefaultCredentials = false;
            mail.From = new MailAddress(FromEmail);
            mail.To.Add(ToEmail);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpServer.EnableSsl = true;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(FromEmail, Password);
            try
            {
                // Cần cho phép các ứng dụng kém an toàn truy cập vào tài khoản email
                // Cho phép tại: https://myaccount.google.com/lesssecureapps
                SmtpServer.Send(mail);
                res.Status = StatusID.Success;
            }

            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return res;
        }
    }
}