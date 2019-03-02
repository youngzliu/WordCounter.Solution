using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/message")]
    public ActionResult Message() {
      RepeatCounter rc = new RepeatCounter("bob", "foo");
      return View(rc);
    }

    [HttpGet("/")]
    public ActionResult Index(){
      return View();
    }

    [HttpGet("/form")]
    public ActionResult Form() {
      return View();
    }

    [HttpPost("/newCounter")]
    public ActionResult newCounter(string word, string sentence){
      RepeatCounter rc = new RepeatCounter(word, sentence);
      return View("Message", rc);
    }
  }
}
