using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace LonnysLemons.Controllers
{
  public class CarsController: Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Cars> allCars = CarsController.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string description)
    {
      Cars myCars = new Cars(description);
      return RedirectToAction("Index");
    }

  }
}