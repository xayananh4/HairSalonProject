using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Models;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Client> model = _db.Stylists.ToList();
      return View(model);
    }
  
  
  
  
  }
}