using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/message")]
    public ActionResult Message() {
      return View();
    }

    [HttpGet("/form")]
    public ActionResult Form() {
      return View();
    }

    [HttpPost("/repeatCounter")]
    public ActionResult Create(string word, string sentence){
      RepeatCounter rc = new RepeatCounter(word, sentence);
      return View("Message", rc);
    }
  }
}
