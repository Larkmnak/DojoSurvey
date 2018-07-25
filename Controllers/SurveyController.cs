using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SurveyController.Controllers
{
    
    public class Survey : Controller
    {
        
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("method")]
        public IActionResult method(string InputName, string InputLocation, string InputLanguage, string InputComment)
        {
            Dictionary<string,string> surveyResults = new Dictionary<string,string>();
            surveyResults.Add("Name", InputName);
            surveyResults.Add("Location", InputLocation);
            surveyResults.Add("Language", InputLanguage);
            surveyResults.Add("Comment", InputComment);
            ViewBag.ViewResults = surveyResults;
            foreach(var result in ViewBag.ViewResults)
            {
                Console.WriteLine(result.Key + " - " + result.Value);
            }
            return View("Results");
        }
    }
}