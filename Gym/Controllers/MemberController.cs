using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Gym.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gym.Controllers
{
    public class MembersController : Controller
    {
        private readonly GymContext _db;

    public MembersController(GymContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        List<Member> model = _db.Members
                                        .include(member => member.class)
                                        .ToList();
        return View();
    }

    [HttpPost]
    public ActionResult Create(Member member)

    }
}