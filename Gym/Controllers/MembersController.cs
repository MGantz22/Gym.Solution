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
        return View(_db.Members.ToList());
            
        }

        public ActionResult Create()
        {
        ViewBag.ClassId = new SelectList(_db.Classes, "ClassId","Name");
        return View();
        }
        [HttpPost]
        public ActionResult Create(Member member)
        {
            _db.Members.Add(member);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    
        public ActionResult Edit(int id)
        {
            Member thisMember = _db.Members.FirstOrDefault(member => member.MemberId == id);
            ViewBag.ClassId = new SelectList(_db.Classes, "ClassId", "ClassName");
            return View(thisMember);
        }

        [HttpPost]
        public ActionResult Edit(Member member)
        {
            _db.Members.Update(member);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddClass(int id)
        {
            Member thisMember = _db.Members.FirstOrDefault(members => members.MemberId == id);
            ViewBag.ClassId = new SelectList(_db.Classes, "ClassId", "Name");
            return View(thisMember);
        }

        [HttpPost]
        public ActionResult AddClass(Member member, int classId)
        {
            #nullable enable
            ClassMember? joinEntity = _db.ClassMembers.FirstOrDefault(join => (join.ClassId == classId && join.MemberId == member.MemberId));
            #nullable disable
            if (joinEntity == null && classId !=0)
            {
                _db.ClassMembers.Add(new ClassMember() {ClassId = classId, MemberId = member.MemberId });
                _db.SaveChanges();
            }
            return RedirectToAction("Details", new {id = member.MemberId});
        }




    }
}