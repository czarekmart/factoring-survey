using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FactoringSurvey.Models;
using Microsoft.AspNetCore.Hosting;

namespace FactoringSurvey.Controllers
{
    public class HomeController : Controller
    {
		private ISurveyRepository _repository;

		public HomeController(ISurveyRepository repo, IHostingEnvironment hostingEnvironment)
		{
			_repository = repo;
			_repository.SetHostingEnvironment(hostingEnvironment);
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
            ViewData["Message"] = "Your application description page.";

            return View();
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
