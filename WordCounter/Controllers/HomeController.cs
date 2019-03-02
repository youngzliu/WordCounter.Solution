using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/message")]
    public ActionResult Message(string word, string sentence) {
      RepeatCounter rc = new RepeatCounter(word, sentence);
      return View(rc);
    }

    [Route("/")]
    public ActionResult Form() {return View();}
  }
}
