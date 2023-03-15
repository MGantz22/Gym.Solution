using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Gym.Models;
using System.Collections.Generic;
using System.Linq;
namespace Gym.Controllers;

public class LocationsController : Controller
{
  private readonly GymContext _db;

  public LocationsController(GymContext db)
  {
      _db = db;
  }

  public ActionResult Index()
  {
    return View(_db.Locations.ToList());
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Location newLocation)
  {
    _db.Locations.Add(newLocation);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }
}