using Microsoft.AspNetCore.Mvc;
using Dealership.Models;

namespace Dealership.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Car starterCar = new Car("Add new car to inventory.");
      return View(starterCar);
    }
    
  }
}