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
    List<Class> model = _db.Classes.ToList();
    return View(model);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Class class)
  {
    _db.Classes.Add(class);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  public ActionResult Details(int id)
  {
    Class thisClass = _db.Classes
      .Include(class => class.Members)
      .ThenInclude(member => member.JoinEntities)
      .FirstOrDefault(class => class.ClassId == id);
    return View(thisClass);
  }  
}
