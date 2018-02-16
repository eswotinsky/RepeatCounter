using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RepeatCounters.Models;

namespace RepeatCounters.Controllers
{
  public class HomeController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Create()
    {
        if (Request.Form["word-input"] == "" || Request.Form["sentence-input"] == "")
        {
            return View("Index");
        }
        RepeatCounter userInput = new RepeatCounter(Request.Form["word-input"], Request.Form["sentence-input"]);
        return View("Index", userInput);
    }
  }
}
