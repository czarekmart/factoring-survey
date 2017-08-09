using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FactoringSurvey.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace FactoringSurvey.Controllers
{
    public class HomeController : Controller
    {
		private ISurveyRepository _repository;
		private IHostingEnvironment _hostingEnvironment;
		private IConfiguration _configuration;

		public HomeController(ISurveyRepository repo, IHostingEnvironment hostingEnvironment, IConfiguration configuration)
		{
			_repository = repo;
			_hostingEnvironment = hostingEnvironment;
			_configuration = configuration;
			_repository.Configure(hostingEnvironment, configuration);
		}

        public ViewResult Index()
        {
			return View("Welcome");
        }

		[HttpGet]
		public ViewResult SurveyForm()
		{
			return View(new SurveyResponse());
		}

		[HttpPost]
		public ViewResult SurveyForm(SurveyResponse response)
		{
			if(ModelState.IsValid)
			{
				// Run it in the background
				Task.Run(() => _repository.AddResponse(response));

				return View("Thanks", response);
			}
			else
			{
				return View();
			}
		}

		public async Task<ViewResult> List()
		{
			var responses = await Task.Run(() => getResponseList());
			return View("List", responses);
		}

		private List<SurveyResponse> getResponseList()
		{
			return _repository.GetResponses().ToList();
		}

		public ViewResult ListSync()
		{
			return View("List", _repository.GetResponses());
		}

        public IActionResult About()
        {
			var env = string.Empty;
			env += string.Format("ApplicationName={0};", _hostingEnvironment.ApplicationName) + System.Environment.NewLine + "<br>";
			env += string.Format("ContentRootPath={0};", _hostingEnvironment.ContentRootPath) + System.Environment.NewLine + "<br>";
			env += string.Format("EnvironmentName={0};", _hostingEnvironment.EnvironmentName) + System.Environment.NewLine + "<br>";
			env += string.Format("IsDevelopment={0};", _hostingEnvironment.IsDevelopment()) + System.Environment.NewLine + "<br>";
			env += string.Format("IsProduction={0};", _hostingEnvironment.IsProduction()) + System.Environment.NewLine + "<br>";
			env += string.Format("IsStaging={0};", _hostingEnvironment.IsStaging()) + System.Environment.NewLine + "<br>";
			env += string.Format("WebRootPath={0};", _hostingEnvironment.WebRootPath) + System.Environment.NewLine + "<br>";
            ViewData["Message"] = env;

			var storagePath = System.IO.Path.Combine(_hostingEnvironment.WebRootPath, "repo");
			var error = false;
			if(!System.IO.Directory.Exists(storagePath))
			{
				try
				{
					System.IO.Directory.CreateDirectory(storagePath);
				}
				catch(Exception ex)
				{
					ViewData["Message2"] = "CreateDirectory: " + ex.Message;
					error = true;
				}
			}
			if(!error)
			{
				var dirContent = "Content of repo:" + "<br>";
				var jsonFiles = System.IO.Directory.GetFiles(storagePath, "*.json");
				foreach(var file in jsonFiles)
				{
					dirContent += "-- " + System.IO.Path.GetFileName(file) + "<br>";
				}
				ViewData["Message2"] = dirContent;
			}


            return View();
        }

		private int getRepoCount()
		{
			return System.IO.Directory.GetFiles(_repository.GetRepoPath(), "*.json").Length;
		}

		[HttpGet]
		public IActionResult Reset()
		{
			return View(new ResetInfo() { RepoCount = getRepoCount() });
		}

		[HttpPost]
		public IActionResult Reset(ResetInfo info)
		{
			if(string.IsNullOrEmpty(info.Password))
			{
				info.UserError = "Password was not specified. Please try again.";
			}
			else if(!info.IsValidPassword())
			{
				info.UserError = "Invalid Password. Please try again.";
			}
			else
			{
				var repoPath = _repository.GetRepoPath();
				foreach(var file in System.IO.Directory.GetFiles(repoPath, "*.json"))
				{
					System.IO.File.Delete(file);
				}
				info.UserError = string.Empty;
				info.Password = string.Empty;
			}
			info.RepoCount = getRepoCount();
			return View(info);
		}

        public IActionResult Contact()
        {
			ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
