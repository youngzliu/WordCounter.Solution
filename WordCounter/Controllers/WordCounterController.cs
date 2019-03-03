using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/repeatCounter")]
    public ActionResult Index() {
      return View();
    }

    [HttpGet("/repeatCounter/new")]
    public ActionResult New() {
      return View();
    }

    [HttpPost("/repeatCounter")]
    public ActionResult Create(string word, string sentence){
      RepeatCounter rc = new RepeatCounter(word, sentence);
      return View("Index", rc);
    }
  }
}
