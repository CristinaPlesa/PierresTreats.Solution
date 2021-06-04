using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {
     private readonly PierresTreatsContext _db;
      public HomeController(PierresTreatsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Treat> treats = _db.Treats.ToList();
      List<Flavor> flavors = _db.Flavors.ToList();
      model.Add("treats", treats);
      model.Add("flavors", flavors);
      return View(model);
    }
  }
}