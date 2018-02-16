using Microsoft.AspNetCore.Mvc;
using RepeatCounters.Models;
using System.Collections.Generic;

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
      RepeatCounter userInput = new RepeatCounter(Request.Form["word-input"], Request.Form["sentence-input"]);
      return View("Index", userInput);
    }

  }
}
