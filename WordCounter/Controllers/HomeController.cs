using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult index() { return View(); }

  }
}
