using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;
using MimeKit;

namespace FactoringSurvey.Models
{
	public class SurveyFileRepository : ISurveyRepository
	{
		private IHostingEnvironment _hostingEnvironment;
		private static List<SurveyResponse> _responses = new List<SurveyResponse>();

		private string getRepositoryFolder()
		{
			var folder = System.IO.Path.Combine(_hostingEnvironment.WebRootPath, "repo");
			if(System.IO.Directory.Exists(folder))
				System.IO.Directory.CreateDirectory(folder);
			return folder;
		}
		public string GetRepoPath()
		{
			return getRepositoryFolder();
		}

		public async Task SendEmailAsync(string email, string subject, string message)
		{
			var emailMessage = new MimeMessage();
 
			emailMessage.From.Add(new MailboxAddress("Factoring Survey", "free.all.cezars@gmail.com"));
			emailMessage.To.Add(new MailboxAddress("Gosia Mart", email));
			emailMessage.Subject = subject;
			emailMessage.Body = new TextPart("plain") { Text = message };
 
			using (var client = new MailKit.Net.Smtp.SmtpClient())
			{
				client.LocalDomain = "some.domain.com";                
				await client.ConnectAsync("smtp.relay.uri", 25, MailKit.Security.SecureSocketOptions.None).ConfigureAwait(false);
				await client.SendAsync(emailMessage).ConfigureAwait(false);
				await client.DisconnectAsync(true).ConfigureAwait(false);
			}
		}
		public void SendEmail(string email, string subject, string messageBody)
		{
			try
			{
				var emailMessage = new MimeMessage();
 
				emailMessage.From.Add(new MailboxAddress("Factoring Survey", "free.all.cezars@gmail.com"));
				emailMessage.To.Add(new MailboxAddress("Gosia Mart", email));
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

		private void emailSurveyNotification(string json)
		{
			//var mailMessage = new MailMessage()
		}
		public void SetHostingEnvironment(IHostingEnvironment hostingEnvironment)
		{
			_hostingEnvironment = hostingEnvironment;
		}

		public void AddResponse(SurveyResponse response)
		{
			var now = DateTime.Now;
			var fileName = string.Format("survey_{0:D4}{1:D2}{2:D2}{3:D2}{4:D2}{5:D2}_{6}.json", 
				now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, 
				Guid.NewGuid().ToString());
			var filePath = System.IO.Path.Combine(getRepositoryFolder(), fileName);

			var settings = new JsonSerializerSettings()
			{
				NullValueHandling = NullValueHandling.Ignore,
				Formatting = Formatting.Indented
			};
			var json = JsonConvert.SerializeObject(response, settings);
			if(!string.IsNullOrEmpty(json))
			{
				try
				{
					System.IO.File.WriteAllText(filePath, json);
				}
				catch(Exception ex)
				{
					System.Diagnostics.Debug.WriteLine("Error Json.Serialize: " + ex.Message);
				}

				// Send notification email

				SendEmail("czarekmart@me.com", "Factoring Survey Response", json);
			}
			System.Diagnostics.Debug.WriteLine(string.Format("  >>  Done AddResponse: {0}", (DateTime.Now - now).TotalMilliseconds));
		}


		public IEnumerable<SurveyResponse> GetResponses()
		{
			var jsonFiles = System.IO.Directory.GetFiles(getRepositoryFolder());
			foreach(var file in jsonFiles)
			{
				var json = System.IO.File.ReadAllText(file);
				SurveyResponse response = null;
				try
				{
					response = JsonConvert.DeserializeObject<SurveyResponse>(json);
				}
				catch(Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(string.Format("File {0} is not valid survery response: {1}", file, ex.Message));
					throw;
				}
				if(response != null && !string.IsNullOrEmpty(response.Name))
					yield return response;
			}
		}
	}
}
