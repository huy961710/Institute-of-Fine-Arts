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
    }
}
