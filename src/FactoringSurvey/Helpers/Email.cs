using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoringSurvey.Helpers
{
	public class EmailRecipient
	{
		public string Name { get; set; }
		public string EmailAddress { get; set; }
	}
    public class Email
    {
		public static void SendEmail(EmailRecipient[] recipients, string subject, string messageBody)
		{
			try
			{
				var emailMessage = new MimeMessage();
 
				emailMessage.From.Add(new MailboxAddress("Factoring Survey", "free.all.cezars@gmail.com"));
				foreach(var r in recipients)
					emailMessage.To.Add(new MailboxAddress(r.Name, r.EmailAddress));

				emailMessage.Subject = subject;
				emailMessage.Body = new TextPart("plain") { Text = messageBody };
 
				using (var client = new MailKit.Net.Smtp.SmtpClient())
				{
					client.Connect("smtp.gmail.com", 587);


					// Note: since we don't have an OAuth2 token, disable
					// the XOAUTH2 authentication mechanism.
					client.AuthenticationMechanisms.Remove("XOAUTH2");

					// Note: only needed if the SMTP server requires authentication
					client.Authenticate("free.all.cezars", "Mohawk.123");

					client.Send(emailMessage);
					client.Disconnect(true);
				}
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Error writing email: " + ex.Message);
				throw;
			}
		}
    }
}
