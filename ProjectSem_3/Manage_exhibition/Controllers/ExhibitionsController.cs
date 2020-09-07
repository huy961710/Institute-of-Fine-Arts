using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_exhibition.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manage_exhibition.Controllers
{
    public class ExhibitionsController : Controller
    {
        ExhibitionDB db;
        public ExhibitionsController(ExhibitionDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = from s in db.Staffs
                       join e in db.Exhibitions
                       on s.StaffId equals e.StaffId
                       select new StaffExhibition
                       {
                           Staff = s,
                           Exhibition = e
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
        public IActionResult Create(Exhibition exhibition)
        {
            var list = db.Staffs.Where(s => s.Role.Equals(2));
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            try
            {
                if (ModelState.IsValid)
                {
                    db.Exhibitions.Add(exhibition);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Exhibitions");
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
            var list = db.Staffs.Where(s => s.Role.Equals(1) || s.Role.Equals(2));
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            var exh = db.Exhibitions.Find(id);
            if (exh != null)
            {
                return View(exh);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Exhibition exhibition)
        {
            var list = db.Staffs.Where(s => s.Role.Equals(1) || s.Role.Equals(2));
            ViewBag.data = new SelectList(list, "StaffId", "StaffName");

            try
            {
                var editExhibition = db.Exhibitions.SingleOrDefault(e => e.ExhibitionId.Equals(exhibition.ExhibitionId));

                if (ModelState.IsValid)
                {
                    if (editExhibition != null)
                    {
                        editExhibition.ExhibitionName = exhibition.ExhibitionName;
                        editExhibition.Place = exhibition.Place;
                        editExhibition.StartDate = exhibition.StartDate;
                        editExhibition.EndDate = exhibition.EndDate;
                        editExhibition.StaffId = exhibition.StaffId;

                        DateTime editenddate = Convert.ToDateTime(exhibition.EndDate);
                        DateTime editstartdate = Convert.ToDateTime(editExhibition.StartDate);
                        DateTime today = Convert.ToDateTime(DateTime.Today);
                        TimeSpan time = editenddate - editstartdate;
                        TimeSpan timetoday = editstartdate - today;
                        int edittime = time.Days;
                        int todaytime = timetoday.Days;

                        if (todaytime > 0)
                        {
                            if (edittime > 0)
                            {
                                db.SaveChanges();
                                return RedirectToAction("Index", "Exhibitions");
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
                var exhibition = db.Exhibitions.SingleOrDefault(e => e.ExhibitionId.Equals(id));
                if (exhibition != null)
                {
                    db.Exhibitions.Remove(exhibition);
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
