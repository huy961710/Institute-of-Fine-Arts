﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSem3_merged.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ProjectSem3_merged.Controllers
{
    public class StaffsController : Controller
    {
        ProjectDB db;
        public StaffsController(ProjectDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var list = db.Staffs.ToList();
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
                        staff.ProfileImage = "../images/" + file.FileName;

                        var key = "b14ca5898a4e4133bbce2ea2315a1916";
                        staff.Password = AesEncDesc.EncryptString(key, staff.Password);
                        db.Staffs.Add(staff);
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
            var stf = db.Staffs.Find(id);
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
                var editStaff = db.Staffs.SingleOrDefault(c => c.StaffId.Equals(staff.StaffId));
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
                            editStaff.ProfileImage = "../images/" + file.FileName;

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
                var staff = db.Staffs.SingleOrDefault(s => s.StaffId.Equals(id));

                if (staff != null)
                {
                    db.Staffs.Remove(staff);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Staffs");
                }
            }
            catch (Exception)
            {
                return BadRequest("Cannot delete object that is existed in other tables");
            }
            return View();
        }
    }
}
