using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WinForms.Services
{
    internal static class EmailService
    {
        private static async void SendEmail(MailMessage mail)
        {
            await Task.Run(() =>
            {
                using (SmtpClient client = new SmtpClient
                {
                    //TODO: EnableSsl = true,
                    UseDefaultCredentials = false,
                    Port = Properties.Settings.Default.port,
                    Host = Properties.Settings.Default.host,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(Properties.Settings.Default.email, Properties.Settings.Default.email_pwd)
                })
                {
                    client.Send(mail);
                }
            });
        }

        private static MailMessage BuildMailMessage(string to, string subject, string body)
        {
            try
            {
                MailAddress _to = new MailAddress(to);
                MailAddress from = new MailAddress(Properties.Settings.Default.email);
                return new MailMessage(from, _to)
                {
                    Body = body,
                    Subject = subject,
                    IsBodyHtml = true,
                    Priority = MailPriority.Normal
                };
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException(": Destinatario o remitente.");
            }
        }

        /// <summary>
        /// Sends email.
        /// </summary>
        /// <param name="to">Addresse</param>
        /// <param name="subject">Email subject</param>
        /// <param name="body">Email content</param>
        /// <param name="attachments">Files to be attached</param>
        public static void SendEmail(string to, string subject, string body, IEnumerable<string> attachments)
        {
            if (attachments == null)
                throw new ArgumentNullException("Argumento \"attachments\" sin inicializar.");
            
            var mail = BuildMailMessage(to, subject, body);

            foreach (string attachment in attachments)
                mail.Attachments.Add(new Attachment(attachment));

            SendEmail(mail);
        }
        
        /// <summary>
        /// Sends email.
        /// </summary>
        /// <param name="to">Addressee</param>
        /// <param name="subject">Email subject</param>
        /// <param name="body">Email content</param>
        public static void SendEmail(string to, string subject, string body)
        {
            var mail = BuildMailMessage(to, subject, body);
            SendEmail(mail);
        }
    }
}
