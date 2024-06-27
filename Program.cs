using System;
using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace smtp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fmail = "tarunrk2002@gmail.com";
            string pass_fmail = "xueb bybu ynjl yica"; 
            int otp = 0;
            Random rand = new Random();
            otp = rand.Next(111,999);


            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(fmail),
                Subject = "OTP",
                IsBodyHtml = true,
                Body = "<html><body>hi this is your otp: " + otp + "</body></html>"
            };
            mailMessage.To.Add(new MailAddress("tarunrk2002@gmail.com"));
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com") {
            Port = 587,
            Credentials = new NetworkCredential(fmail, pass_fmail),
            EnableSsl = true
            };
            smtpClient.Send(mailMessage);

            
          
            Console.WriteLine("Email sent successfully.");
        }
    }
}

