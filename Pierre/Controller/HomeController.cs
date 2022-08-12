using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Pierre.Controllers
{
    public class HomeController : Controller
    {
      private readonly PierreContext _db;

      public HomeController(PierreContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Flavors = _db.Flavors.ToList();
        ViewBag.Treats = _db.Treats.ToList();
        return View();
      }

    }
}