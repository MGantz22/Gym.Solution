using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Gym.Models;
using System.Collections.Generic;
using System.Linq;
namespace Gym.Controllers;

public class InstructorsController : Controller
{
    private readonly GymContext _db;

    public InstructorsController(GymContext db)
    {
        _db =db;
    }

    public ActionResult Index()
    {
        return View(_db.Instructors.ToList());
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Instructor newInstructor)
    {
        _db.Instructors.Add(newInstructor);
        _db.SaveChanges();
        return RedirectToAction("index");
    }

}