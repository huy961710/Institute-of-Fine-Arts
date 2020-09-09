using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_award.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manage_award.Controllers
{
    public class AwardsController : Controller
    {
        AwardDB db;
        public AwardsController(AwardDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = from a in db.Awards
                       join c in db.Competitions on a.CompetitionID equals c.CompetitionId
                       join s in db.Staffs on a.StaffId equals s.StaffId
                       join p in db.Postings on a.PostingID equals p.PostingId
                       select new AwardStaffCompetitionPosting
                       {
                           Award = a,
                           Competition = c,
                           Staff = s,
                           Posting = p
                       };
            return View(list);
        }

        public IActionResult Create()
        {
            var list = db.Staffs.Where(s => s.Role.Equals(2));
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            var list2 = db.Competitions.ToList();
            ViewBag.data2 = new SelectList(list2, "CompetitionId", "CompetitionName");

            var list3 = db.Postings.Where(p=>p.Mark.Equals("best"));
            ViewBag.data3 = new SelectList(list3, "PostingId", "PostDescription");

            return View();
        }
        [HttpPost]
        public IActionResult Create(Award award)
        {
            var list = db.Staffs.Where(s => s.Role.Equals(2));
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            var list2 = db.Competitions.ToList();
            ViewBag.data2 = new SelectList(list2, "CompetitionId", "CompetitionName");

            var list3 = db.Postings.Where(p => p.Mark.Equals("best"));
            ViewBag.data3 = new SelectList(list3, "PostingId", "PostDescription");

            try
            {
                if (ModelState.IsValid)
                {
                    db.Awards.Add(award);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Awards");
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
