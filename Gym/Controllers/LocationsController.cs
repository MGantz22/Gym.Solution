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

  public ActionResult Details(int id)
  {
    Location thisLocation = _db.Locations
      .Include(item => item.JoinEntities)
      .ThenInclude(item=>item.Instructor)
      .FirstOrDefault(fish => fish.LocationId == id);
    return View(thisLocation);
  }

  public ActionResult AddInstructor(int id)
  {
    Location thisLocation = _db.Locations.FirstOrDefault(locations => locations.LocationId == id);
    ViewBag.InstructorId = new SelectList(_db.Instructors, "InstructorId", "InstructorName");
    return View(thisLocation);
  }

  [HttpPost]
  public ActionResult AddLocationInstructor (Location location, int instructorId)
  {
  #nullable enable
  LocationInstructor? joinEntity = _db.LocationInstructors.FirstOrDefault(join => (join.InstructorId == instructorId && join.LocationId == location.LocationId));
  #nullable disable
  if(joinEntity == null && instructorId != 0)
  {
    _db.LocationInstructors.Add(new LocationInstructor() {InstructorId = instructorId, LocationId = location.LocationId });
    _db.SaveChanges();

  }

  return RedirectToAction("Details" , new {id = location.LocationId});
  }
}