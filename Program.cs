using System;
using System.Net;
using System.Net.Mail;

namespace smtp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fmail = "tarunrk2002@gmail.com";
            string pass_fmail = "xueb bybu ynjl yica"; 
            int otp = 123;

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(fmail),
                Subject = "OTP",
                IsBodyHtml = true,
                Body = "<html><body>hi this is your otp: " + otp + "</body></html>"
            };
            mailMessage.To.Add(new MailAddress("tarunrk2002@gmail.com"));

            using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(fmail, pass_fmail);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);
                Console.WriteLine("Email sent successfully.");

               
            }
        }
    }
}

