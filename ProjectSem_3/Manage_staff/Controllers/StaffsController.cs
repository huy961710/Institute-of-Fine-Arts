using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manage_staff.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Manage_staff.Controllers
{
    public class StaffsController : Controller
    {
        StaffDB db;
        public StaffsController(StaffDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Staff> list = db.Staff.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create(Staff staff, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file.Length > 0)
                    {
                        string path = Path.Combine("wwwroot/images", file.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        file.CopyToAsync(stream);
                        staff.ProfileImage = "images/" + file.FileName;

                        db.Staff.Add(staff);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Staffs");
                    }
                }
                else
                {
                    ViewBag.Msg = "Failed .......";
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();
        }

        public IActionResult Edit(string id)
        {
            var stf = db.Staff.Find(id);
            if (stf != null)
            {
                return View(stf);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Staff staff, IFormFile file)
        {
            try
            {
                var editStaff = db.Staff.SingleOrDefault(c => c.StaffId.Equals(staff.StaffId));
                if (ModelState.IsValid)
                {
                    if (editStaff != null)
                    {
                        editStaff.ProfileImage = staff.ProfileImage;

                        if (file.Length > 0)
                        {
                            string path = Path.Combine("wwwroot/images", file.FileName);
                            var stream = new FileStream(path, FileMode.Create);
                            file.CopyToAsync(stream);
                            editStaff.ProfileImage = "images/" + file.FileName;

                            editStaff.Email = staff.Email;
                            editStaff.Phone = staff.Phone;
                            editStaff.Address = staff.Address;
                            db.SaveChanges();
                            return RedirectToAction("Index", "Staffs");
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

        public IActionResult Delete(string id)
        {
            try
            {
                var staff = db.Staff.SingleOrDefault(s => s.StaffId.Equals(id));
                //List<Competition> competition = db.Competition.ToList();
                //var com = competition.SingleOrDefault(c => c.StaffId.Equals(id));
                //List<Award> award = db.Award.ToList();
                //var awa = competition.SingleOrDefault(a => a.StaffId.Equals(id));
                //List<Remark> remark = db.Remark.ToList();
                //var rmk = competition.SingleOrDefault(r => r.StaffId.Equals(id));
                //List<Exhibition> exhibition = db.Exhibition.ToList();
                //var exh = competition.SingleOrDefault(e => e.StaffId.Equals(id));
                //List<Posting> posting = db.Posting.ToList();
                //var pst = competition.SingleOrDefault(p => p.StaffId.Equals(id));

                if (staff != null)
                {
                   db.Staff.Remove(staff);
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
