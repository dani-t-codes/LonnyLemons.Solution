using Microsoft.AspNetCore.Mvc;

namespace LonnysLemons.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}