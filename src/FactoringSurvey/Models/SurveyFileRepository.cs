using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MimeKit;
using FactoringSurvey.Helpers;

namespace FactoringSurvey.Models
{
	public class SurveyFileRepository : ISurveyRepository
	{
		private Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;
		private Microsoft.Extensions.Configuration.IConfiguration _configuration;
		private static List<SurveyResponse> _responses = new List<SurveyResponse>();

		private string getRepositoryFolder()
		{
			var folder = System.IO.Path.Combine(_hostingEnvironment.WebRootPath, "repo");
			if(!System.IO.Directory.Exists(folder))
				System.IO.Directory.CreateDirectory(folder);
			return folder;
		}
		public string GetRepoPath()
		{
			return getRepositoryFolder();
		}


		public void Configure(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment, Microsoft.Extensions.Configuration.IConfiguration configuration)
		{
			_hostingEnvironment = hostingEnvironment;
			_configuration = configuration;
		}

		public void AddResponse(SurveyResponse response)
		{
			response.SurveyTime = DateTime.Now;
			var fileName = string.Format("survey_{0:D4}{1:D2}{2:D2}{3:D2}{4:D2}{5:D2}_{6}.json", 
				response.SurveyTime.Year, response.SurveyTime.Month, response.SurveyTime.Day, response.SurveyTime.Hour, response.SurveyTime.Minute, response.SurveyTime.Second, 
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
				//var confirmationEmail = _configuration["Confirmation:Email"];
				//if(!string.IsNullOrEmpty(confirmationEmail))
				{
					Helpers.Email.SendEmail( new[]
						{
							new EmailRecipient { Name = "Gosia Mart", EmailAddress = "gosiamart@icloud.com" },
							new EmailRecipient { Name = "Cezar Mart", EmailAddress = "czarekmart@me.com" }
						}, 
						"Survey response from " + response.Name, 
						json);
				}
			}
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
