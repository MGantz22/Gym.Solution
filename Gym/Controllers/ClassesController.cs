using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Microsoft.AspNetCore.Mvc;
using Gym.Models;
using System.Collections.Generic;
using System.Linq;
namespace Gym.Controllers;



public class ClassesController : Controller
{
  private readonly GymContext _db;

  public ClassesController(GymContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    List<Class> model = _db.Classes
      .Include(model=> model.Instructor)
      .Include(model=>model.Location)
      .ToList();
    return View(model);
  }

  public ActionResult Create()
  {
    // ViewBag.LocationInstructor = new SelectList(_db.LocationInstructors)
    ViewBag.LocationId = new SelectList(_db.Locations, "LocationId", "LocationName");
    ViewBag.InstructorId = new SelectList(_db.Instructors, "InstructorId", "InstructorName");
    return View();
  }

  [HttpPost]
  public ActionResult Create(Class newClass)
  {
    _db.Classes.Add(newClass);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  public ActionResult Details(int id)
  {
    Class thisClass = _db.Classes
      .Include(thingy => thingy.JoinEntities)
      .ThenInclude(thingy => thingy.Member)
      .FirstOrDefault(thingy => thingy.ClassId == id);
    return View(thisClass);
  }  
}
