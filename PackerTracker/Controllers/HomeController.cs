using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Catalog starterItem = new Catalog("string", "may", 32, "camping");
      return View();
    }

  }
}