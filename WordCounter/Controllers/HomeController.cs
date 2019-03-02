using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult message() {
      RepeatCounter rc = new RepeatCounter("fire", "fire fire bob bob FIRE.");
      return View(rc);
    }
  }
}
