using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Gym.Models;
using System.Collections.Generic;
using System.Linq;
namespace Gym.Controllers;

public class TypeOfClassController : Controller
{
  private readonly GymContext _db;

  public TypeOfClassController(GymContext db)
  {
      _db = db;
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(TypeOfClass newType)
  {
    _db.ClassTypes.Add(newType);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  public ActionResult Index()
  {
    return View(_db.ClassTypes.ToList());
  }
}