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
            if (HttpContext.Session.GetString("ename") == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                IEnumerable<Staff> list = db.Staff.ToList();
                return View(list);
            }
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

                        var key = "b14ca5898a4e4133bbce2ea2315a1916";
                        staff.Password = AesEncDesc.EncryptString(key, staff.Password);
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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string accName, string accPass)
        {
            try
            {
                var staff = db.Staff.SingleOrDefault(s => s.StaffId.Equals(accName));
                if (staff != null)
                {
                    HttpContext.Session.SetString("ename", accName);
                    var key = "b14ca5898a4e4133bbce2ea2315a1916";
                    staff.Password = AesEncDesc.DecryptString(key, staff.Password);
                    if (staff.Password.Equals(accPass))
                    {
                        if (staff.Role == 0)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return RedirectToAction("Info", staff);
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Invalid Pasword....";
                    }
                }
                else
                {
                    ViewBag.Msg = "Invalid Username....";
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

                if (staff != null)
                {
                   db.Staff.Remove(staff);
                   db.SaveChanges();
                   return RedirectToAction("Index");
                }    
            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }

        public IActionResult Info(Staff staff)
        {
            if (staff != null)
            {
                return View(staff);
            }
            return View();
        }

        public IActionResult Logout()
        {
            var model = HttpContext.Session.GetString("ename");
            if(model!=null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");

            }
            return RedirectToAction("Index");
        }
    }
}
