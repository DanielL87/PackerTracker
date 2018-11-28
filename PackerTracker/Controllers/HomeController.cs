using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;


namespace PackerTracker.Controllers
{
  public class HomeController : Controller
  {
     
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Catalog> allCatalogues = Catalog.GetAll();
      return View(allCatalogues);
    }

    [HttpGet("/trips/new")]
    public ActionResult CreateForm() 
    {
        return View();
    }

    [HttpPost("/")]
    public ActionResult Create(string location, string month, int budget, string description)
    {
        Catalog myItem = new Catalog(location, month, budget, description);
        return RedirectToAction("Index");
    }
    

  }  
}