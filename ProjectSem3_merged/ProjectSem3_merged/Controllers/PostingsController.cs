using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSem3_merged.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Internal;

namespace ProjectSem3_merged.Controllers
{
    public class PostingsController : Controller
    {
        ProjectDB db;
        public PostingsController(ProjectDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = from p in db.Postings
                       join d in db.Designs on p.DesignId equals d.DesignId
                       join c in db.Competitions on p.CompetitionId equals c.CompetitionId
                       join s in db.Staffs on p.StaffId equals s.StaffId
                       select new CombineModels
                       {
                           Posting = p,
                           Design = d,
                           Competition = c,
                           Staff = s
                       };
            return View(list);
        }

        public IActionResult Edit(int id)
        {
            var list = db.Staffs.Where(s => s.Role.Equals(2));
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            var posting = db.Postings.Find(id);
            if (posting != null)
            {
                return View(posting);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Posting posting)
        {
            var list = db.Staffs.Where(s => s.Role.Equals(2));
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            try
            {
                var editPosting = db.Postings.SingleOrDefault(p => p.PostingId.Equals(posting.PostingId));
                if (ModelState.IsValid)
                {
                    if (editPosting != null)
                    {
                        editPosting.PostDescription = posting.PostDescription;
                        editPosting.Mark = posting.Mark;
                        editPosting.Remark = posting.Remark;
                        editPosting.StaffId = posting.StaffId;

                        db.SaveChanges();
                        return RedirectToAction("Index", "Postings");
                    }
                    else
                    {
                        ViewBag.Msg = "Failed .......";
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }
    }
}
