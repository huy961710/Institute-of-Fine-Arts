using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectSem3_merged.Models;
using Microsoft.AspNetCore.Http;

namespace ProjectSem3_merged.Controllers
{
    public class HomeController : Controller
    {
        ProjectDB db;
        public HomeController(ProjectDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            ViewBag.data = db.Competitions.ToList();

            var list = from p in db.Postings
                       join s in db.Staffs on p.StaffId equals s.StaffId
                       join c in db.Competitions on p.CompetitionId equals c.CompetitionId
                       join d in db.Designs on p.DesignId equals d.DesignId
                       join stu in db.Students on d.StudentId equals stu.StudentId
                       where p.Mark.Equals("best")
                       select new CombineModels
                       {
                          Posting = p,
                          Design = d,
                          Competition = c,
                          Staff = s,
                          Student = stu
                       };
                return View(list);
        }
    }
}
