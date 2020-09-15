using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSem3_merged.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ProjectSem3_merged.Controllers
{
    public class CompetitionsController : Controller
    {
        ProjectDB db;
        public CompetitionsController(ProjectDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = from c in db.Competitions
                       join s in db.Staffs
                       on c.StaffId equals s.StaffId
                       select new CombineModels
                       {
                           Staff = s,
                           Competition = c
                       };
            return View(list);
        }

        public IActionResult Create()
        {
            var list = db.Staffs.Where(s => s.Role.Equals(2));
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Competition competition, IFormFile file)
        {
            var list = db.Staffs.Where(s => s.Role.Equals(2));
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            try
            {
                if (ModelState.IsValid)
                {
                    if (file.Length > 0)
                    {
                        string path = Path.Combine("wwwroot/images", file.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        file.CopyToAsync(stream);
                        competition.CompetitionImages = "../images/" + file.FileName;

                        db.Competitions.Add(competition);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Competitions");
                    }
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
            var competition = db.Competitions.Find(id);
            if (competition != null)
            {
                return View(competition);
            }
            else
            {
                return View();
            }
        }
        public IActionResult Edit(Competition competition, IFormFile file)
        {
            try
            {
                var editCompetition = db.Competitions.SingleOrDefault(c => c.CompetitionId.Equals(competition.CompetitionId));
                if (ModelState.IsValid)
                {
                    if (editCompetition != null)
                    {
                        editCompetition.CompetitionImages = competition.CompetitionImages;

                        if (file.Length > 0)
                        {
                            string path = Path.Combine("wwwroot/images", file.FileName);
                            var stream = new FileStream(path, FileMode.Create);
                            file.CopyToAsync(stream);
                            competition.CompetitionImages = "../images/" + file.FileName;

                            editCompetition.StartDate = competition.StartDate;
                            editCompetition.EndDate = competition.EndDate;
                            editCompetition.Description = competition.Description;

                            db.SaveChanges();
                            return RedirectToAction("Index", "Competitions");
                        }
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

        public IActionResult Delete(int id)
        {
            try
            {
                var competition = db.Competitions.SingleOrDefault(c => c.CompetitionId.Equals(id));
                if (competition != null)
                {
                    db.Competitions.Remove(competition);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Competitions");
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
