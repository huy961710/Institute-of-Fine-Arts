using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//step 1
using Manage_student.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
namespace Manage_student.Controllers
{
    public class StudentsController : Controller
    {
        //step 2
        StudentDB db;
        public StudentsController(StudentDB db)
        {
            this.db = db;
        }

        //step 3
        //INDEX for Staff
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("staffname") == null) //check session
            {
                return RedirectToAction("Login");
            }
            else{
                //IEnumerable<Student> list = db.Student.ToList();
                var list = from s in db.Student
                           join c in db.Competitions on s.CompetitionId equals c.CompetitionId into table1
                           from c in table1.DefaultIfEmpty() //if Competition is null Student still display
                           select new StudentCompetition
                           {
                               Student = s,
                               Competition = c
                           };
                return View(list);
            }
        }
        //STAFF role (manager) LOGIN
        public IActionResult Login()
        {            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(StaffLogin staffLogin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = db.Staff.Where(s => s.StaffId.Equals(staffLogin.StaffId)).FirstOrDefault();
                    if (model != null) //if found
                    {
                        var key = "b14ca5898a4e4133bbce2ea2315a1916";
                        model.Password = AesEncDesc.DecryptString(key, model.Password);
                        if (model.Password.Equals(staffLogin.Password))
                        {
                            if (model.Role==1) //Manager
                            {
                                HttpContext.Session.SetString("staffname", staffLogin.StaffId); //session
                                return RedirectToAction("Index");
                            }
                            //else
                            //{
                            //    return RedirectToAction("Info", staff);
                            //}
                        }
                        else
                        {
                            ViewBag.Msg = "Wrong Password";
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Username not found";
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            return View();
        }

        //LOGOUT
        public IActionResult Logout()
        {
            var model = HttpContext.Session.GetString("staffname");
            if (model != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");

            }
            return View();
        }

        //CREATE
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("staffname") == null) //check login
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateViewStudent validateStudent, Student student, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid && file != null) //check CreateViewStudent and profileimages
                {
                    if (file.Length > 0 && Path.GetExtension(file.FileName).ToLower().Equals(".jpg")) //profile images must be .jpg
                    {
                        //choose image
                        string path = Path.Combine("wwwroot/images", file.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        file.CopyToAsync(stream);
                        student.ProfileImage = "../images/" + file.FileName;
                        //key
                        var key = "b14ca5898a4e4133bbce2ea2315a1916";
                        student.Password = AesEncDesc.EncryptString(key, student.Password);
                        db.Student.Add(student);
                        db.SaveChanges();
                        stream.Close();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Msg = "Profile images must be .jpg";
                        return View();
                    }
                }
                {
                    ViewBag.Msg = "Failed";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            return View();
        }

        //EDIT
        public IActionResult Edit(string id)
        {
            if (HttpContext.Session.GetString("staffname") == null) //check session
            {
                return RedirectToAction("Login");
            }
            else
            {
                var model = db.Student.Find(id);
                if (model != null)
                {
                    return View(model); ;
                }
                else
                {
                    return View();
                }
            } //end check session
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student, IFormFile file)
        {            
            try
            {
                var model = db.Student.SingleOrDefault(s => s.StudentId.Equals(student.StudentId));
                if (ModelState.IsValid)
                {
                    if (model != null)
                    {                      
                        if (file != null && file.Length > 0 && Path.GetExtension(file.FileName).ToLower().Equals(".jpg")) //profile images must be .jpg
                        {
                            string path = Path.Combine("wwwroot/images", file.FileName);
                            var stream = new FileStream(path, FileMode.Create);
                            file.CopyToAsync(stream);
                            model.FirstName = student.FirstName;
                            model.LastName = student.LastName;
                            model.DateOfBirth = student.DateOfBirth;
                            model.Gender = student.Gender;
                            model.Phone = student.Phone;
                            model.Email = student.Email;
                            model.JoinDate = student.JoinDate;
                            model.Address = student.Address;
                            student.ProfileImage = "../images/" + file.FileName;
                            model.ProfileImage = student.ProfileImage;
                            //Staff cannot change Student CompetitionId and Password
                            db.SaveChanges();
                            stream.Close();
                            return RedirectToAction("Index");                            
                        }
                        else if (file == null) //if no change profile images
                        {
                            model.FirstName = student.FirstName;
                            model.LastName = student.LastName;
                            model.DateOfBirth = student.DateOfBirth;
                            model.Gender = student.Gender;
                            model.Phone = student.Phone;
                            model.Email = student.Email;
                            model.JoinDate = student.JoinDate;
                            model.Address = student.Address;
                            db.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewBag.Msg = "Profile images must be .jpg";
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Failed";
                    }
                }   
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            ViewBag.Msg = "Update Failed";
            return View();
        }

        //DELETE
        public IActionResult Delete(string id)
        {
            if (HttpContext.Session.GetString("staffname") == null) //check session
            {
                return RedirectToAction("Login");
            }
            else
            {
                try
                {
                    var model = db.Student.SingleOrDefault(s => s.StudentId.Equals(id));

                    if (model != null)
                    {
                        db.Student.Remove(model);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return View();
            } //end check session
        }
    }
}
