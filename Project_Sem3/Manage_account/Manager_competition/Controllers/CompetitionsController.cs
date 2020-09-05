using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manager_competition.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manager_competition.Controllers
{
    public class CompetitionsController : Controller
    {
        CompetitionDB db;
        public CompetitionsController(CompetitionDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = from s in db.Staffs
                       join c in db.Competitions
                       on s.StaffId equals c.StaffId
                       select new StaffCompetition
                       {
                           Staff = s,
                           Competition = c
                       };
            return View(list);
        }

        public IActionResult Create()
        {
            List<Staff> list = db.Staffs.ToList();
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Competition competition)
        {
            List<Staff> list = db.Staffs.ToList();
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            try
            {
                if (ModelState.IsValid)
                {
                    db.Competitions.Add(competition);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Competitions");
                }
                else
                {
                    ViewBag.Msg = "Failed .......";
                }
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
            }
            return View();
        }
    }
}
