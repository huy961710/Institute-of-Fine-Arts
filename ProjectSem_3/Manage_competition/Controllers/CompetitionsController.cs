using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_competition.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manage_competition.Controllers
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

        public IActionResult Edit(int id)
        {
            List<Staff> list = db.Staffs.ToList();
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            var comp = db.Competitions.Find(id);
            if (comp != null)
            {
                return View(comp);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Competition competition)
        {
            List<Staff> list = db.Staffs.ToList();
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            try
            {
                var editCompetition = db.Competitions.SingleOrDefault(c => c.CompetitionId.Equals(competition.CompetitionId));
                
                if (ModelState.IsValid)
                {
                    if (editCompetition != null)
                     {
                        editCompetition.CompetitionName = competition.CompetitionName;
                        editCompetition.StartDate = competition.StartDate;
                        editCompetition.EndDate = competition.EndDate;
                        editCompetition.StaffId = competition.StaffId;

                        DateTime editenddate = Convert.ToDateTime(competition.EndDate);
                        DateTime editstartdate = Convert.ToDateTime(competition.StartDate);
                        DateTime today = Convert.ToDateTime(DateTime.Today);
                        TimeSpan time = editenddate - editstartdate;
                        TimeSpan timetoday = editstartdate - today;
                        int edittime = time.Days;
                        int todaytime = timetoday.Days;

                        if(todaytime > 0)
                        {
                            if (edittime > 0)
                            {
                                db.SaveChanges();
                                return RedirectToAction("Index", "Competitions");
                            }
                            else
                            {
                                ViewBag.Msg = "EndDate cannot be earlier than StartDate. Update Failed";
                            }
                        }
                        else
                        {
                            ViewBag.Msg = "StartDate cannot be earlier than Current Time. Update Failed";
                        }
                     }
                     else
                     {
                         ViewBag.Msg = "Failed";
                     }
                }
                else
                {
                    ViewBag.Msg = "Failed";
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            try
            {
                var competition = db.Competitions.SingleOrDefault(c => c.CompetitionId.Equals(id));
                if (competition != null)
                {
                    db.Competitions.Remove(competition);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
