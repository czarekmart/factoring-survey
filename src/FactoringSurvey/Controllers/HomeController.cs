using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FactoringSurvey.Models;

namespace FactoringSurvey.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Welcome");
        }

		[HttpGet]
		public ViewResult SurveyForm()
		{
			return View();
		}

		[HttpPost]
		public ViewResult SurveyForm(SurveyResponse response)
		{
			if(ModelState.IsValid)
			{
				Repository.AddResponse(response);
				return View("Thanks", response);
			}
			else
			{
				return View();
			}
		}

		public ViewResult ListResponses()
		{
			return View(Repository.Responses);
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
